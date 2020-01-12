using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ConditionControl
{
    public partial class FrmAddCondition : Form
    {
        bool FormShown = false;
        List<Operand> lstOperand = new List<Operand>();
        List<Fields> lstFields = new List<Fields>();
        List<Decide> lstDecide = new List<Decide>();
        int HeightRowDetail = 31;
        bool _WithOperand;
        DataTable DT;
        Thread t;

        public bool WithOperand
        {
            get { return _WithOperand; }
            set
            {
                _WithOperand = value;
                cboOperand.Enabled = value;
            }
        }
        public FrmAddCondition(List<Fields> _lstField, bool withOperand)
        {
            InitializeComponent();
            WithOperand = withOperand;
            if (_lstField != null)
            {
                lstFields = _lstField.ToList();
            }
            FillOperand();
            FillLstDecide();
            FillFields();

            FormShown = true;
            CboField_SelectedIndexChanged(null, null);
        }

        public FrmAddCondition(DataTable dt, bool withOperand)
        {
            InitializeComponent();
            WithOperand = withOperand;

            DT = dt.Copy();
            if (DT == null)
            {
                DT = new DataTable();
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0].Copy();
                Fields a;
                Type type;
                foreach (DataColumn item in dt.Columns)
                {
                    a = new Fields();
                    a.Name = item.ColumnName;
                    a.Title = item.Caption;
                    type = item.DataType;
                    if (type.Equals(typeof(string)))
                    {
                        a.Noe = NoeType.NoeString;
                    }
                    else if (type.Equals(typeof(bool)))
                    {
                        a.Noe = NoeType.NoeString;
                    }
                    else if (type.Equals(typeof(int)) || type.Equals(typeof(long)) || type.Equals(typeof(double)))
                    {
                        a.Noe = NoeType.Number;
                    }
                    a.Script = "";
                    lstFields.Add(a);
                }
            }

            FillOperand();
            FillLstDecide();
            FillFields();

            FormShown = true;
            CboField_SelectedIndexChanged(null, null);
        }

        SqlCondition _myObject;
        public SqlCondition MyObject
        {
            get { return _myObject; }
            set
            {
                _myObject = value;
                if (value != null)
                {
                    string[] str = value.StrSql.Split('(');
                    if (str.Length > 1)
                    {
                        Operand EntityOperand = null;
                        Fields EntityField = null;
                        Decide EntityDecide = null;
                        //******************************************************************************* برای عملگر
                        if (str[0].Trim().ToLower() == "and")
                        {
                            EntityOperand = lstOperand.FirstOrDefault(a => a.Name == "And");
                            if (EntityOperand != null)
                            {
                                cboOperand.SelectedValue = EntityOperand.ID;
                            }
                        }
                        else if (str[0].Trim().ToLower() == "or")
                        {
                            EntityOperand = lstOperand.FirstOrDefault(a => a.Name == "Or");
                            if (EntityOperand != null)
                            {
                                cboOperand.SelectedValue = EntityOperand.ID;
                            }
                        }
                        else
                        {
                            cboOperand.Enabled = false;
                        }
                        //******************************************************************************* شکستن کلمه به کلمه
                        str = str[1].Split(' ');
                        if (str.Length > 1)
                        {
                            EntityField = lstFields.FirstOrDefault(a => a.Name == str[0].Trim().ToString());
                            if (EntityField != null)
                            {
                                CboField.SelectedValue = EntityField.ID;

                                /*EntityDecide = lstDecide.FirstOrDefault(a => a.Name == str[1].Trim() && a.Noe == EntityField.Noe);
                                if (EntityDecide != null)
                                {
                                    CboDecide.SelectedValue = EntityDecide.ID;
                                }*/
                            }

                        }
                        //******************************************************************************* برای فیلد

                    }

                }
            }
        }

        #region Methods
        void FillOperand()
        {
            lstOperand.Add(new Operand()
            {
                Name = "And",
                Title = "و"
            });
            lstOperand.Add(new Operand()
            {
                Name = "Or",
                Title = "یا"
            });

            int aa = 0;
            lstOperand.ForEach(b => b.ID = aa++);
            cboOperand.DataSource = lstOperand.ToList();
            cboOperand.DisplayMember = "Title";
            cboOperand.ValueMember = "ID";
        }


        void FillFields()
        {
            int aa = 0;
            lstFields.ForEach(b => b.ID = aa++);

            CboField.DataSource = lstFields.ToList();
            CboField.DisplayMember = "Title";
            CboField.ValueMember = "ID";
        }
        void FillLstDecide()
        {
            lstDecide.Add(new Decide() { ID = 1, Name = " >= and <= ", Title = " در محدوده انتخاب شده باشد ", Noe = NoeType.Number, noeControl = NoeControl.txtNumberTwoCol });
            lstDecide.Add(new Decide() { ID = 2, Name = " >= and <= ", Title = " در محدوده انتخاب شده نباشد ", Noe = NoeType.Number, noeControl = NoeControl.txtNumberTwoCol });
            lstDecide.Add(new Decide() { ID = 3, Name = ">", Title = " بزرگتر ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 4, Name = ">=", Title = " بزرگتر مساوی ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 5, Name = "<", Title = " کوچکتر ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 6, Name = "<=", Title = " کوچکتر مساوی ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 7, Name = "=", Title = " برابر باشد ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 8, Name = "!=", Title = " برابر نباشد ", Noe = NoeType.Number, noeControl = NoeControl.txtNumber });
            lstDecide.Add(new Decide() { ID = 9, Name = "is null", Title = "تهی باشد ", Noe = NoeType.Number, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 10, Name = "is not null", Title = " تهی نباشد ", Noe = NoeType.Number, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 11, Name = "in", Title = " در مجموعه انتخاب شده باشد ", Noe = NoeType.Number, noeControl = NoeControl.Combo });
            lstDecide.Add(new Decide() { ID = 12, Name = "not in", Title = " در مجموعه انتخاب شده نباشد ", Noe = NoeType.Number, noeControl = NoeControl.Combo });


            lstDecide.Add(new Decide() { ID = 20, Name = "=", Title = " برابر ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 21, Name = "!=", Title = " برابر نباشد ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 22, Name = "like", Title = " شامل عبارت باشد ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 23, Name = "not like", Title = " شامل عبارت نباشد ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 24, Name = "like '% '", Title = " با عبارت وارد شده شروع گردد ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 25, Name = "like ' %'", Title = " با عبارت وارد شده ختم گردد ", Noe = NoeType.NoeString, noeControl = NoeControl.txtString });
            lstDecide.Add(new Decide() { ID = 26, Name = "is null", Title = " تهی باشد ", Noe = NoeType.NoeString, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 27, Name = "is not null", Title = " تهی نباشد ", Noe = NoeType.NoeString, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 28, Name = "= ''", Title = " خالی باشد ", Noe = NoeType.NoeString, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 29, Name = "!= ''", Title = " خالی نباشد ", Noe = NoeType.NoeString, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 30, Name = "in", Title = " در مجموعه انتخاب شده باشد ", Noe = NoeType.NoeString, noeControl = NoeControl.Combo });
            lstDecide.Add(new Decide() { ID = 31, Name = "in", Title = " در مجموعه انتخاب شده نباشد ", Noe = NoeType.NoeString, noeControl = NoeControl.Combo });


            lstDecide.Add(new Decide() { ID = 40, Name = "=", Title = " برابر با ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 41, Name = "!=", Title = " برابر نباشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 42, Name = "Is Null", Title = " بزرگتر ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 43, Name = "like", Title = " بزرگتر مساوی ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 44, Name = "StartWith", Title = " کوچکتر ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 45, Name = "EndWith", Title = " کوچکتر مساوی ", Noe = NoeType.NoeDate, noeControl = NoeControl.Date });
            lstDecide.Add(new Decide() { ID = 46, Name = " >= and <= ", Title = " در محدوده انتخاب شده باشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.DateTwoCol });
            lstDecide.Add(new Decide() { ID = 47, Name = " >= and <= ", Title = " در محدوده انتخاب شده نباشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.DateTwoCol });
            lstDecide.Add(new Decide() { ID = 48, Name = "IsNull", Title = " تهی باشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 49, Name = "IsNotNull", Title = " تهی نباشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.None });
            lstDecide.Add(new Decide() { ID = 50, Name = "in", Title = " در مجموعه انتخاب شده باشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.Combo });
            lstDecide.Add(new Decide() { ID = 51, Name = "in", Title = " در مجموعه انتخاب شده نباشد ", Noe = NoeType.NoeDate, noeControl = NoeControl.Combo });

        }

        void FillDecide()
        {
            if (CboField.SelectedIndex < 0)
            {
                CboDecide.DataSource = null;
                return;
            }

            Fields temp = lstFields.FirstOrDefault(a => a.ID == CboField.SelectedValue.ToString().ToInt());
            if (temp == null)
            {
                return;
            }
            var lsttemp = lstDecide.Where(a => a.Noe == temp.Noe).ToList();
            CboDecide.DataSource = lsttemp.ToList();
            CboDecide.ValueMember = "ID";
            CboDecide.DisplayMember = "Title";
        }

        void SetTblDetailRows(int ActiveRowIndex)
        {
            for (int i = 0; i <= 6; i++)
            {
                if (i == ActiveRowIndex)
                {
                    tblDetail.RowStyles[i].Height = HeightRowDetail;
                }
                else
                {
                    tblDetail.RowStyles[i].Height = 0;
                }
            }
            foreach (Control item in tblDetail.Controls)
            {
                item.Enabled = item.Visible = true;
            }
            foreach (Control item in tblDetail.Controls)
            {
                if (tblDetail.GetRow(item) != ActiveRowIndex)
                {
                    item.Enabled = item.Visible = false;
                }
            }
            if (CboSelect.Visible || CboSelect.Enabled)
            {
                Fields f = lstFields.FirstOrDefault(s => s.ID == CboField.SelectedValue.ToString().ToInt());
                if (f != null)
                {
                    List<string> lst = new List<string>();
                    foreach (DataRow item in DT.Rows)
                    {
                        lst.Add(item[f.Name].ToString());
                    }
                    CboSelect.DataSource = lst.ToList();
                }
            }
        }


        #endregion
        private void FrmAddCondition_Load(object sender, EventArgs e)
        {
            CboDecide_SelectedIndexChanged(null, null);
        }

        private void CboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormShown == false)
            {
                return;
            }
            FillDecide();
        }

        private void CboDecide_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormShown == false)
            {
                return;
            }
            var temp = lstDecide.FirstOrDefault(a => a.ID == CboDecide.SelectedValue.ToString().ToInt());
            if (temp == null)
            {
                return;
            }
            switch ((NoeControl)temp.noeControl)
            {
                case NoeControl.txtString:
                    SetTblDetailRows(5);
                    break;
                case NoeControl.txtStringTwoCol:
                    SetTblDetailRows(2);
                    break;
                case NoeControl.txtNumber:
                    SetTblDetailRows(3);
                    break;
                case NoeControl.txtNumberTwoCol:
                    SetTblDetailRows(0);
                    break;
                case NoeControl.Combo:
                    SetTblDetailRows(6);
                    break;
                case NoeControl.Date:
                    SetTblDetailRows(4);
                    break;
                case NoeControl.DateTwoCol:
                    SetTblDetailRows(1);
                    break;
                case NoeControl.None:
                    SetTblDetailRows(1000);
                    break;
            }
            SendKeys.Send("{TAB}");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tblDetail.RowStyles[6].Height = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tblDetail.RowStyles[6].Height = 25;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string resSql = string.Empty, ResPersian = string.Empty;

            var operand = lstOperand.FirstOrDefault(a => a.ID == cboOperand.SelectedValue.ToString().ToInt());
            var tempField = lstFields.FirstOrDefault(a => a.ID == CboField.SelectedValue.ToString().ToInt());
            var Decide = lstDecide.FirstOrDefault(a => a.ID == CboDecide.SelectedValue.ToString().ToInt());

            string tempSelectValues = string.Empty;

            switch (Decide.ID)
            {
                case 1://**************************************************** Number
                    ResPersian = tempField.Title + " بزرگتر مساوی " + txtNumAz.LongValue.ToString("#,##.####") + " و کوچکتر مساوی " + txtNumEla.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = /*"(" +*/ (tempField.Name + " " + " >= " + txtNumAz.LongValue + " And " + tempField.Name + " <= " + txtNumEla.LongValue)/* + ")"*/;
                    break;
                case 2:
                    ResPersian = tempField.Title + " بزرگتر مساوی " + txtNumAz.LongValue.ToString("#,##.####") + " و کوچکتر مساوی " + txtNumEla.LongValue.ToString("#,##.####") + " نباشد.";
                    resSql = "( not (" + (tempField.Name + " " + " >= " + txtNumAz.LongValue + " And " + tempField.Name + " <= " + txtNumEla.LongValue) + "))";
                    break;
                case 3:
                    ResPersian = tempField.Title + " بزرگتر از " + txtNum.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = tempField.Name + " > " + txtNum.LongValue;
                    break;
                case 4:
                    ResPersian = tempField.Title + " بزرگتر مساوی " + txtNum.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = tempField.Name + " >= " + txtNum.LongValue;
                    break;
                case 5:
                    ResPersian = tempField.Title + " کوچکتر از " + txtNum.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = tempField.Name + " < " + txtNum.LongValue;
                    break;
                case 6:
                    ResPersian = tempField.Title + " کوچکتر مساوی " + txtNum.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = tempField.Name + " <= " + txtNum.LongValue;
                    break;
                case 7:
                    ResPersian = tempField.Title + " مساوی " + txtNum.LongValue.ToString("#,##.####") + " باشد.";
                    resSql = tempField.Name + " = " + txtNum.LongValue;
                    break;
                case 8:
                    ResPersian = tempField.Title + " مساوی " + txtNum.LongValue.ToString("#,##.####") + " نباشد.";
                    resSql = tempField.Name + " != " + txtNum.LongValue;
                    break;
                case 9:
                    ResPersian = tempField.Title + " تهی باشد.";
                    resSql = tempField.Name + " Is Null ";
                    break;
                case 10:
                    resSql = tempField.Name + " Is Not Null ";
                    ResPersian = tempField.Title + " تهی نباشد.";
                    break;
                case 11:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + CboSelect.Text.ToString().ToLong();
                    }
                    ResPersian = tempField.Title + " در مجموعه " + tempSelectValues + " باشد.";
                    resSql = tempField.Name + " in (" + tempSelectValues + ")";
                    break;
                case 12:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + CboSelect.Text.ToString().ToLong();
                    }
                    ResPersian = tempField.Title + " در مجموعه " + tempSelectValues + " نباشد.";
                    resSql = tempField.Name + " Not in (" + tempSelectValues + ")";
                    break;

                case 20: // String
                    ResPersian = tempField.Title + " برابر '" + txtString.Text + "' باشد.";
                    resSql = tempField.Name + " = '" + txtString.Text + "'";
                    break;
                case 21:
                    ResPersian = tempField.Title + " برابر '" + txtString.Text + "' نباشد.";
                    resSql = tempField.Name + " != '" + txtString.Text + "'";
                    break;
                case 22:
                    ResPersian = tempField.Title + " شامل '" + txtString.Text + "' باشد.";
                    resSql = tempField.Name + " Like '%" + txtString.Text + "%'";
                    break;
                case 23:
                    ResPersian = tempField.Title + " شامل '" + txtString.Text + "' نباشد.";
                    resSql = tempField.Name + " Not Like '%" + txtString.Text + "%'";
                    break;
                case 24:
                    ResPersian = tempField.Title + " با عبارت '" + txtString.Text + "' شروع شود.";
                    resSql = tempField.Name + " Like '" + txtString.Text + "%'";
                    break;
                case 25:
                    ResPersian = tempField.Title + " با عبارت '" + txtString.Text + "' پایان پذیرد.";
                    resSql = tempField.Name + " Like '%" + txtString.Text + "'";
                    break;
                case 26:
                    ResPersian = tempField.Title + " تهی باشد.";
                    resSql = tempField.Name + " Is Null";
                    break;
                case 27:
                    ResPersian = tempField.Title + " تهی نباشد.";
                    resSql = tempField.Name + " Is Not Null";
                    break;
                case 28:
                    ResPersian = tempField.Title + " خالی باشد.";
                    resSql = tempField.Name + " = '' ";
                    break;
                case 29:
                    ResPersian = tempField.Title + " خالی نباشد.";
                    resSql = tempField.Name + " != ''";
                    break;
                case 30:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + "'" + CboSelect.Text.ToString() + "'";
                    }
                    ResPersian = tempField.Title + " در مجموعه (" + tempSelectValues + ") باشد.";
                    resSql = tempField.Name + " in (" + tempSelectValues + ")";
                    break;
                case 31:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + "'" + CboSelect.Text.ToString() + "'";
                    }
                    ResPersian = tempField.Title + " در مجموعه (" + tempSelectValues + ") نباشد.";
                    resSql = tempField.Name + " Not in (" + tempSelectValues + ")";
                    break;

                case 40: // Date
                    ResPersian = tempField.Title + " مساوی '" + dtDate.Text + "' باشد.";
                    resSql = tempField.Name + " = '" + dtDate.Text + "'";
                    break;
                case 41:
                    ResPersian = tempField.Title + " مساوی '" + dtDate.Text + "' نباشد.";
                    resSql = tempField.Name + " != '" + dtDate.Text + "'";
                    break;
                case 42:
                    ResPersian = tempField.Title + " بزرگتر از '" + dtDate.Text + "' باشد.";
                    resSql = tempField.Name + " > '" + dtDate.Text + "'";
                    break;
                case 43:
                    ResPersian = tempField.Title + " بزرگتر مساوی '" + dtDate.Text + "' باشد.";
                    resSql = tempField.Name + " >= '" + dtDate.Text + "'";
                    break;
                case 44:
                    ResPersian = tempField.Title + " کوچکتر از '" + dtDate.Text + "' باشد.";
                    resSql = tempField.Name + " < '" + dtDate.Text + "'";
                    break;
                case 45:
                    ResPersian = tempField.Title + " کوچکتر مساوی '" + dtDate.Text + "' باشد.";
                    resSql = tempField.Name + " <= '" + dtDate.Text + "'";
                    break;
                case 46:
                    ResPersian = tempField.Title + " بزرگتر از '" + dtDate.Text + "' و کوچکتر از '" + dtDateEla.Text + "' باشد.";
                    resSql = "(" + tempField.Name + " >= '" + dtDateAz.Text + "' And " + tempField.Name + " <= '" + dtDateEla.Text + "')";
                    break;
                case 47:
                    ResPersian = tempField.Title + " بزرگتر از '" + dtDate.Text + "' و کوچکتر از '" + dtDateEla.Text + "' نباشد.";
                    resSql = " Not (" + tempField.Name + " >= '" + dtDateAz.Text + "' And " + tempField.Name + " <= '" + dtDateEla.Text + "')";
                    break;
                case 48:
                    ResPersian = tempField.Title + " تهی باشد. ";
                    resSql = tempField.Name + " Is Null ";
                    break;
                case 49:
                    ResPersian = tempField.Title + " تهی نباشد. ";
                    resSql = tempField.Name + " Is Not Null ";
                    break;
                case 50:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + "'" + CboSelect.Text.ToString() + "'";
                    }
                    ResPersian = tempField.Title + " در مجموعه (" + tempSelectValues + ") باشد.";
                    resSql = tempField.Name + " In ( " + tempSelectValues + " )";
                    break;
                case 51:
                    tempSelectValues = string.Empty;
                    foreach (var item in CboSelect.SelectedValue.ToString().ToList())
                    {
                        tempSelectValues = (tempSelectValues == string.Empty ? "" : ",") + "'" + CboSelect.Text.ToString() + "'";
                    }
                    ResPersian = tempField.Title + " در مجموعه (" + tempSelectValues + ") نباشد.";
                    resSql = tempField.Name + " Not In ( " + tempSelectValues + " )";
                    break;
            }
            _myObject = new SqlCondition() { ID = _myObject != null && _myObject.ID > 0 ? _myObject.ID : 0 };
            _myObject.StrSql = (WithOperand ? (operand.ID == 0 ? " And " : " Or ") : string.Empty) + "(" + resSql + ")";
            _myObject.strPersian = (WithOperand ? (operand.ID == 0 ? " و " : " یا ") : string.Empty) + "(" + ResPersian + ")";
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void FrmAddCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
            }
        }

        private void btnExquitQuery_Click(object sender, EventArgs e)
        {
            Fields temp = lstFields.FirstOrDefault(a => a.ID == CboField.SelectedValue.ToString().ToInt());
            if (temp != null)
            {
                if (temp.Script.Length < 1)
                {
                    MessageBox.Show("اسکریپتی برای این فیلد تعریف نشده است");
                    //return;
                }
                DataTable dttemp = new DataTable();// Exec Query

                CboSelect.DataSource = null;
                btnExquitQuery.Image = Properties.Resources.Loading_16;

                t = new Thread(ExecQuery);
                t.IsBackground = true;
                t.Start();

                
                //CboSelect.DataSource = dttemp;
            }
        }

        void ExecQuery()
        {
            string q = "sasa";
            List<string> lst = new List<string>();
            DelSetDataToCombo del = new DelSetDataToCombo(SetDataToCombo);
            for (int i = 0; i < 10000; i++)
            {
                CboSelect.Invoke(del, "Amin" + i.ToString());
            }
            
            btnOk.Invoke(new DelSetBtnImg(SetBtnImg));
            MessageBox.Show("Done");
        }

        delegate void DelSetDataToCombo(string str);
        void SetDataToCombo(string str)
        {
            CboSelect.Items.Add(str);
        }

        delegate void DelSetBtnImg();
        void SetBtnImg()
        {
            btnExquitQuery.Image = null;
        }

        private void FrmAddCondition_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
            {
                try
                {
                    t.Abort();
                }
                catch 
                {
                }
            }
        }
    }
}
