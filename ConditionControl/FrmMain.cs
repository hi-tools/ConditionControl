using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConditionControl
{
    public partial class FrmMain : Form
    {
        public int NoeConstractor { get; set; } // 0=> list , 2=>datatable , 3=> DG
        List<Fields> lst = new List<Fields>();
        List<SqlCondition> lstTress;

        /// <summary>
        /// شرط اس کیو ال
        /// </summary>
        public string CurrentCondition
        {
            get
            {
                GetSqlCondition();
                return StrResSql;
            }
        }
        DataTable DT;
        public FrmMain(DataTable dt)
        {
            InitializeComponent();
            DT = dt;
            if (DT == null)
            {
                DT = new DataTable();
            }
            NoeConstractor = 1;
        }

        public FrmMain(DataGridView dg)
        {
            InitializeComponent();
            DT = (DataTable)(dg.DataSource);
            if (DT == null)
            {
                DT = new DataTable();
            }
            NoeConstractor = 2;
        }

        public FrmMain()
        {
            InitializeComponent();
            contextMenuStrip1.Font = Font;
            NoeConstractor = 0;
            lstTress = new List<SqlCondition>();
            lst.Add(new Fields()
            {
                Name = "Name",
                Noe = NoeType.NoeString,
                Script = "",
                Title = "نام"
            });
            lst.Add(new Fields()
            {
                Name = "Tarikh",
                Noe = NoeType.NoeDate,
                Script = "",
                Title = "تاریخ"
            });
            lst.Add(new Fields()
            {
                Name = "Mablagh",
                Noe = NoeType.Number,
                Script = "",
                Title = "مبلغ"
            });
            //**************************
            NoeConstractor = 1;
            DT = new DataTable();
            DT.Columns.Add("ID", typeof(int));
            DT.Columns.Add("NameHa", typeof(string));
            DT.Columns.Add("Mablagh", typeof(long));

            DT.Columns[0].Caption = "کد";
            DT.Columns[1].Caption = "نام";
            DT.Columns[2].Caption = "مبلغ";
            for (int i = 0; i < 10; i++)
            {
                DT.Rows.Add(i + 1, "Amin" + (i + 1).ToString(), 200 * i);
            }
            //************************
        }

        #region Methods

        private void RefreshTree()
        {
            treeView1.ExpandAll();
        }

        private int FindFreeCode()
        {
            if (lstTress.Any() == false)
            {
                return 1;
            }
            return lstTress.Max(a => a.ID);
        }

        private int CountNodes = 0;
        private int GetCountTreeViewNode()
        {
            CountNodes = 0;
            if (treeView1.Nodes.Count == 0)
            {
                return 0;
            }
            foreach (TreeNode item in treeView1.Nodes)
            {
                if (item.Nodes.Count > 0)
                {
                    ++CountNodes;
                    ComputeChild(item.Nodes);
                }
                else
                {
                    ++CountNodes;
                }
            }
            return CountNodes;
        }
        private void ComputeChild(TreeNodeCollection node)
        {
            foreach (TreeNode item in node)
            {
                if (item.Nodes.Count > 0)
                {
                    ++CountNodes;
                    ComputeChild(item.Nodes);
                }
                else
                {
                    ++CountNodes;
                }
            }
        }

        private string StrResSql = string.Empty;
        private string StrResSqlDetail = string.Empty;
        private void GetSqlCondition()
        {
            StrResSql = string.Empty;
            StrResSqlDetail = string.Empty;
            if (treeView1.Nodes.Count == 0)
            {
                StrResSql = string.Empty;
                return;
            }
            string temp = string.Empty;
            foreach (TreeNode item in treeView1.Nodes)
            {
                StrResSqlDetail = string.Empty;
                temp = item.Tag.ToString().Trim().Substring(0, item.Tag.ToString().Trim().Length - 1);
                if (item.Nodes.Count > 0)
                {
                    StrResSql = StrResSql + temp + " ";
                    GetSqlConditionDetail(item.Nodes);
                }
                else
                {
                    StrResSql = StrResSql + temp + " ";
                }
                StrResSql = StrResSql + StrResSqlDetail;
                StrResSql =StrResSql+ ")"+Environment.NewLine;
                StrResSql = StrResSql + "\t";    
            }
        }

        private void GetSqlConditionDetail(TreeNodeCollection node)
        {
            string temp = string.Empty;
            foreach (TreeNode item in node)
            {
                temp = item.Tag.ToString().Trim().Substring(0, item.Tag.ToString().Trim().Length - 1);
                if (item.Nodes.Count > 0)
                {
                    StrResSqlDetail = StrResSqlDetail + temp + " ";
                    GetSqlConditionDetail(item.Nodes);
                }
                else
                {
                    StrResSqlDetail = StrResSqlDetail + temp + " ";
                }
                StrResSqlDetail += ") ";
            }
        }

        #endregion
        private void BtnRoot_Click(object sender, EventArgs e)
        {
            bool WithOperand = treeView1.Nodes.Count > 0 ? true : false;

            FrmAddCondition f = null;
            switch (NoeConstractor)
            {
                case 0 :
                    f = new FrmAddCondition(lst, WithOperand);
                    break;
                case 1:
                    f = new FrmAddCondition(DT, WithOperand);
                    break;
                case 2:
                    f = new FrmAddCondition(DT, WithOperand);
                    break;
                default:
                    return;
            }
            
            if (treeView1.Nodes.Count > 0)
            {
                int Counter = GetCountTreeViewNode();
                f.Top = (Counter * treeView1.ItemHeight) + treeView1.Top + Top + toolStrip1.Height + 10;
            }
            else
            {
                //f.Top = treeView1.Top + toolStrip1.Height + Top;
                f.Top = tblMain.Top + toolStrip1.Height + Top;
            }
            f.Left = treeView1.Left + Left + 8;
            f.Width = Width - 20;
            if (f.ShowDialog() == DialogResult.OK)
            {
                var temp = f.MyObject;
                if (temp.ID == 0)
                {
                    temp.ID = FindFreeCode();
                }
                lstTress.Add(temp);
                treeView1.Nodes.Add(new TreeNode() { Text = temp.strPersian, Name = temp.ID.ToString(), Tag = temp.StrSql });
            }
            RefreshTree();
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            FrmAddCondition f = null;
            switch (NoeConstractor)
            {
                case 0:
                    f = new FrmAddCondition(lst, true);
                    break;
                case 1:
                    f = new FrmAddCondition(DT, true);
                    break;
                case 2:
                    f = new FrmAddCondition(DT, true);
                    break;
                default:
                    return;
            }
            int Counter = GetCountTreeViewNode();
            //f.Top = (contextMenuStrip1.Top > 0 ? contextMenuStrip1.Top : Top + treeView1.Top + toolStrip1.Height + (Counter * treeView1.ItemHeight)) + 10;
            f.Top = (contextMenuStrip1.Top > 0 ? contextMenuStrip1.Top : Top + tblMain.Top + toolStrip1.Height + (Counter * treeView1.ItemHeight)) + 10;
            f.Left = treeView1.Left + Left + 8;
            f.Width = Width - 20;
            if (f.ShowDialog() == DialogResult.OK)
            {
                var temp = f.MyObject;
                if (temp.ID == 0)
                {
                    temp.ID = FindFreeCode();
                }
                lstTress.Add(temp);
                treeView1.SelectedNode.Nodes.Add(new TreeNode() { Text = temp.strPersian, Name = temp.ID.ToString(), Tag = temp.StrSql });

            }
            RefreshTree();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                return;
            }
            var temp = treeView1.SelectedNode;
            if (temp == null)
            {
                MessageBox.Show("لطفا شرط مورد نظر را انتخاب نمایئد.");
                return;
            }
            if (MessageBox.Show("آیا از حذف شرط انتخاب شده مطمئن هستید؟","تایید عملیات", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            treeView1.Nodes.Remove(temp);
            RefreshTree();
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(treeView1, e.Location);
            }
            if (treeView1.SelectedNode != null)
            {
                lblShowQuery.Text = treeView1.SelectedNode.Tag.ToString();
            }
        }

        private void mnuAddChild_Click(object sender, EventArgs e)
        {
            btnChild.PerformClick();
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            btnDel.PerformClick();
        }

        private void mnuEdit_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node == null)
            {
                MessageBox.Show("لطفا شرط مورد نظر را انتخاب نمائید.");
                return;
            }
            FrmAddCondition f = null;
            switch (NoeConstractor)
            {
                case 0:
                    f = new FrmAddCondition(lst, true);
                    break;
                case 1:
                    f = new FrmAddCondition(DT, true);
                    break;
                case 2:
                    f = new FrmAddCondition(DT, true);
                    break;
                default:
                    return;
            }
            int Counter = GetCountTreeViewNode();
            //f.Top = Top + treeView1.Top + toolStrip1.Height + (Counter * treeView1.ItemHeight) + 10;
            f.Top = Top + tblMain.Top + toolStrip1.Height + (Counter * treeView1.ItemHeight) + 10;
            f.Left = treeView1.Left + Left + 8;
            f.Width = Width - 20;
            f.MyObject = new SqlCondition() { StrSql = node.Tag.ToString(), ID = node.Name.ToInt() };
            if (f.ShowDialog() == DialogResult.OK)
            {
                var temp = f.MyObject;
                if (temp.ID == 0)
                {
                    temp.ID = FindFreeCode();
                }
                var Entity = lstTress.FirstOrDefault(a => a.ID == node.Name.ToInt() && a.strPersian == node.Text && a.StrSql == node.Tag.ToString());
                if (Entity != null)
                {
                    Entity.StrSql = temp.StrSql;
                    Entity.ID = temp.ID;
                    Entity.strPersian = temp.strPersian;
                }
                node.Tag = temp.StrSql;
                node.Text = temp.strPersian;
                node.Name = temp.ID.ToString();
            }
            RefreshTree();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (tblMain.RowStyles[1].Height == 0)
                {
                    lblShowQuery.Text = CurrentCondition;
                    tblMain.RowStyles[0].Height = tblMain.RowStyles[1].Height = tblMain.Height / 2;
                }
                else
                {
                    tblMain.RowStyles[0].Height = tblMain.Height; ;
                    tblMain.RowStyles[1].Height = 0;
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            tblMain.RowStyles[0].Height = tblMain.Height;
            tblMain.RowStyles[1].Height = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblShowQuery.Text = CurrentCondition;
        }
    }
}