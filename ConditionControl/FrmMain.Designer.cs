namespace ConditionControl
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRoot = new System.Windows.Forms.ToolStripButton();
            this.btnChild = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblShowQuery = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnOk = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(684, 194);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRoot,
            this.btnChild,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRoot
            // 
            this.BtnRoot.AutoSize = false;
            this.BtnRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRoot.Image = ((System.Drawing.Image)(resources.GetObject("BtnRoot.Image")));
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(50, 26);
            this.BtnRoot.Text = "Root";
            this.BtnRoot.Click += new System.EventHandler(this.BtnRoot_Click);
            // 
            // btnChild
            // 
            this.btnChild.AutoSize = false;
            this.btnChild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChild.Image = ((System.Drawing.Image)(resources.GetObject("btnChild.Image")));
            this.btnChild.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(50, 26);
            this.btnChild.Text = "Child";
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = false;
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 26);
            this.btnDel.Text = "Del";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddChild,
            this.mnuDel,
            this.mnuEdit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 70);
            // 
            // mnuAddChild
            // 
            this.mnuAddChild.Image = global::ConditionControl.Properties.Resources.add;
            this.mnuAddChild.Name = "mnuAddChild";
            this.mnuAddChild.Size = new System.Drawing.Size(130, 22);
            this.mnuAddChild.Text = "افزودن شرط";
            this.mnuAddChild.Click += new System.EventHandler(this.mnuAddChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.Image = global::ConditionControl.Properties.Resources.Cancel_20;
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Size = new System.Drawing.Size(130, 22);
            this.mnuDel.Text = "حذف شرط";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(130, 22);
            this.mnuEdit.Text = "ویرایش شرط";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // lblShowQuery
            // 
            this.lblShowQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowQuery.Location = new System.Drawing.Point(4, 202);
            this.lblShowQuery.Name = "lblShowQuery";
            this.lblShowQuery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShowQuery.Size = new System.Drawing.Size(684, 200);
            this.lblShowQuery.TabIndex = 2;
            this.lblShowQuery.Text = "label1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOk,
            this.btnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 397);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(692, 31);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = false;
            this.btnOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 26);
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = false;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 26);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.treeView1, 0, 0);
            this.tblMain.Controls.Add(this.lblShowQuery, 0, 1);
            this.tblMain.Location = new System.Drawing.Point(0, 27);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(692, 367);
            this.tblMain.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 428);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شرط ها";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRoot;
        private System.Windows.Forms.ToolStripButton btnChild;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAddChild;
        private System.Windows.Forms.ToolStripMenuItem mnuDel;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.Label lblShowQuery;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnOk;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblMain;
    }
}