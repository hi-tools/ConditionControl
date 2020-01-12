namespace ConditionControl
{
    partial class FrmAddCondition
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblDetail = new System.Windows.Forms.TableLayoutPanel();
            this.CboSelect = new System.Windows.Forms.ComboBox();
            this.CboDecide = new System.Windows.Forms.ComboBox();
            this.cboOperand = new System.Windows.Forms.ComboBox();
            this.CboField = new System.Windows.Forms.ComboBox();
            this.btnExquitQuery = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtStringEla = new ConditionControl.F_TextBox();
            this.txtStringAz = new ConditionControl.F_TextBox();
            this.f_Label5 = new ConditionControl.F_Label();
            this.dtDateAz = new ConditionControl.F_TextBox();
            this.dtDate = new ConditionControl.F_TextBox();
            this.dtDateEla = new ConditionControl.F_TextBox();
            this.txtNumEla = new ConditionControl.F_TextBox();
            this.txtNumAz = new ConditionControl.F_TextBox();
            this.f_Label3 = new ConditionControl.F_Label();
            this.f_Label4 = new ConditionControl.F_Label();
            this.txtNum = new ConditionControl.F_TextBox();
            this.f_Label2 = new ConditionControl.F_Label();
            this.f_Label6 = new ConditionControl.F_Label();
            this.txtString = new ConditionControl.F_TextBox();
            this.f_Label1 = new ConditionControl.F_Label();
            this.tblMain.SuspendLayout();
            this.tblDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 5;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblMain.Controls.Add(this.tblDetail, 3, 0);
            this.tblMain.Controls.Add(this.btnOk, 4, 0);
            this.tblMain.Controls.Add(this.CboDecide, 2, 0);
            this.tblMain.Controls.Add(this.cboOperand, 0, 0);
            this.tblMain.Controls.Add(this.CboField, 1, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(727, 271);
            this.tblMain.TabIndex = 0;
            // 
            // tblDetail
            // 
            this.tblDetail.ColumnCount = 4;
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDetail.Controls.Add(this.txtStringEla, 3, 2);
            this.tblDetail.Controls.Add(this.txtStringAz, 1, 2);
            this.tblDetail.Controls.Add(this.f_Label5, 0, 2);
            this.tblDetail.Controls.Add(this.dtDateAz, 1, 1);
            this.tblDetail.Controls.Add(this.dtDate, 0, 4);
            this.tblDetail.Controls.Add(this.dtDateEla, 3, 1);
            this.tblDetail.Controls.Add(this.txtNumEla, 3, 0);
            this.tblDetail.Controls.Add(this.txtNumAz, 1, 0);
            this.tblDetail.Controls.Add(this.f_Label3, 0, 1);
            this.tblDetail.Controls.Add(this.f_Label4, 2, 1);
            this.tblDetail.Controls.Add(this.txtNum, 0, 3);
            this.tblDetail.Controls.Add(this.f_Label2, 2, 0);
            this.tblDetail.Controls.Add(this.f_Label6, 2, 2);
            this.tblDetail.Controls.Add(this.txtString, 0, 5);
            this.tblDetail.Controls.Add(this.f_Label1, 0, 0);
            this.tblDetail.Controls.Add(this.btnExquitQuery, 2, 6);
            this.tblDetail.Controls.Add(this.CboSelect, 0, 6);
            this.tblDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDetail.Location = new System.Drawing.Point(25, 0);
            this.tblDetail.Margin = new System.Windows.Forms.Padding(0);
            this.tblDetail.Name = "tblDetail";
            this.tblDetail.RowCount = 8;
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDetail.Size = new System.Drawing.Size(302, 200);
            this.tblDetail.TabIndex = 4;
            // 
            // CboSelect
            // 
            this.tblDetail.SetColumnSpan(this.CboSelect, 2);
            this.CboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSelect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CboSelect.FormattingEnabled = true;
            this.CboSelect.Location = new System.Drawing.Point(154, 153);
            this.CboSelect.Name = "CboSelect";
            this.CboSelect.Size = new System.Drawing.Size(145, 22);
            this.CboSelect.TabIndex = 9;
            // 
            // CboDecide
            // 
            this.CboDecide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CboDecide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDecide.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CboDecide.FormattingEnabled = true;
            this.CboDecide.Location = new System.Drawing.Point(330, 3);
            this.CboDecide.Name = "CboDecide";
            this.CboDecide.Size = new System.Drawing.Size(194, 24);
            this.CboDecide.TabIndex = 3;
            this.CboDecide.SelectedIndexChanged += new System.EventHandler(this.CboDecide_SelectedIndexChanged);
            // 
            // cboOperand
            // 
            this.cboOperand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperand.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cboOperand.FormattingEnabled = true;
            this.cboOperand.Location = new System.Drawing.Point(680, 3);
            this.cboOperand.Name = "cboOperand";
            this.cboOperand.Size = new System.Drawing.Size(44, 24);
            this.cboOperand.TabIndex = 1;
            // 
            // CboField
            // 
            this.CboField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboField.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CboField.FormattingEnabled = true;
            this.CboField.Location = new System.Drawing.Point(530, 3);
            this.CboField.Name = "CboField";
            this.CboField.Size = new System.Drawing.Size(144, 24);
            this.CboField.TabIndex = 2;
            this.CboField.SelectedIndexChanged += new System.EventHandler(this.CboField_SelectedIndexChanged);
            // 
            // btnExquitQuery
            // 
            this.btnExquitQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExquitQuery.Location = new System.Drawing.Point(121, 150);
            this.btnExquitQuery.Margin = new System.Windows.Forms.Padding(0);
            this.btnExquitQuery.Name = "btnExquitQuery";
            this.btnExquitQuery.Size = new System.Drawing.Size(30, 25);
            this.btnExquitQuery.TabIndex = 6;
            this.btnExquitQuery.UseVisualStyleBackColor = true;
            this.btnExquitQuery.Click += new System.EventHandler(this.btnExquitQuery_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::ConditionControl.Properties.Resources.Ok_20;
            this.btnOk.Location = new System.Drawing.Point(0, 0);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(25, 25);
            this.btnOk.TabIndex = 5;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtStringEla
            // 
            this.txtStringEla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStringEla.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtStringEla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStringEla.Location = new System.Drawing.Point(3, 53);
            this.txtStringEla.Multiline = true;
            this.txtStringEla.Name = "txtStringEla";
            this.txtStringEla.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtStringEla.Size = new System.Drawing.Size(115, 19);
            this.txtStringEla.TabIndex = 5;
            this.txtStringEla.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.txtStringEla.WaterMark = "رشته";
            this.txtStringEla.WordWrap = false;
            // 
            // txtStringAz
            // 
            this.txtStringAz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStringAz.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtStringAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStringAz.Location = new System.Drawing.Point(154, 53);
            this.txtStringAz.Multiline = true;
            this.txtStringAz.Name = "txtStringAz";
            this.txtStringAz.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtStringAz.Size = new System.Drawing.Size(115, 19);
            this.txtStringAz.TabIndex = 4;
            this.txtStringAz.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.txtStringAz.WaterMark = "رشته";
            this.txtStringAz.WordWrap = false;
            // 
            // f_Label5
            // 
            this.f_Label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label5.Location = new System.Drawing.Point(275, 50);
            this.f_Label5.Name = "f_Label5";
            this.f_Label5.Size = new System.Drawing.Size(24, 25);
            this.f_Label5.TabIndex = 2;
            this.f_Label5.Text = "از";
            this.f_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtDateAz
            // 
            this.dtDateAz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDateAz.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dtDateAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtDateAz.Location = new System.Drawing.Point(154, 28);
            this.dtDateAz.Multiline = true;
            this.dtDateAz.Name = "dtDateAz";
            this.dtDateAz.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.dtDateAz.Size = new System.Drawing.Size(115, 19);
            this.dtDateAz.TabIndex = 2;
            this.dtDateAz.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.dtDateAz.WaterMark = "تاریخ";
            this.dtDateAz.WordWrap = false;
            // 
            // dtDate
            // 
            this.tblDetail.SetColumnSpan(this.dtDate, 3);
            this.dtDate.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtDate.Location = new System.Drawing.Point(150, 103);
            this.dtDate.Multiline = true;
            this.dtDate.Name = "dtDate";
            this.dtDate.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.dtDate.Size = new System.Drawing.Size(149, 19);
            this.dtDate.TabIndex = 7;
            this.dtDate.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.dtDate.WaterMark = "تاریخ";
            this.dtDate.WordWrap = false;
            // 
            // dtDateEla
            // 
            this.dtDateEla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDateEla.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dtDateEla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtDateEla.Location = new System.Drawing.Point(3, 28);
            this.dtDateEla.Multiline = true;
            this.dtDateEla.Name = "dtDateEla";
            this.dtDateEla.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.dtDateEla.Size = new System.Drawing.Size(115, 19);
            this.dtDateEla.TabIndex = 3;
            this.dtDateEla.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.dtDateEla.WaterMark = "تاریخ";
            this.dtDateEla.WordWrap = false;
            // 
            // txtNumEla
            // 
            this.txtNumEla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumEla.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtNumEla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumEla.Location = new System.Drawing.Point(3, 3);
            this.txtNumEla.MaxLength = 19;
            this.txtNumEla.Multiline = true;
            this.txtNumEla.Name = "txtNumEla";
            this.txtNumEla.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumEla.Size = new System.Drawing.Size(115, 19);
            this.txtNumEla.TabIndex = 1;
            this.txtNumEla.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Number;
            this.txtNumEla.WaterMark = "عدد";
            this.txtNumEla.WordWrap = false;
            // 
            // txtNumAz
            // 
            this.txtNumAz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumAz.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtNumAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNumAz.Location = new System.Drawing.Point(154, 3);
            this.txtNumAz.MaxLength = 19;
            this.txtNumAz.Multiline = true;
            this.txtNumAz.Name = "txtNumAz";
            this.txtNumAz.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumAz.Size = new System.Drawing.Size(115, 19);
            this.txtNumAz.TabIndex = 0;
            this.txtNumAz.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Number;
            this.txtNumAz.WaterMark = "عدد";
            this.txtNumAz.WordWrap = false;
            // 
            // f_Label3
            // 
            this.f_Label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label3.Location = new System.Drawing.Point(275, 25);
            this.f_Label3.Name = "f_Label3";
            this.f_Label3.Size = new System.Drawing.Size(24, 25);
            this.f_Label3.TabIndex = 2;
            this.f_Label3.Text = "از";
            this.f_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_Label4
            // 
            this.f_Label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label4.Location = new System.Drawing.Point(124, 25);
            this.f_Label4.Name = "f_Label4";
            this.f_Label4.Size = new System.Drawing.Size(24, 25);
            this.f_Label4.TabIndex = 2;
            this.f_Label4.Text = "تا";
            this.f_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNum
            // 
            this.tblDetail.SetColumnSpan(this.txtNum, 3);
            this.txtNum.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNum.Location = new System.Drawing.Point(150, 78);
            this.txtNum.MaxLength = 19;
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtNum.Size = new System.Drawing.Size(149, 19);
            this.txtNum.TabIndex = 6;
            this.txtNum.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Number;
            this.txtNum.WaterMark = "عدد";
            this.txtNum.WordWrap = false;
            // 
            // f_Label2
            // 
            this.f_Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label2.Location = new System.Drawing.Point(124, 0);
            this.f_Label2.Name = "f_Label2";
            this.f_Label2.Size = new System.Drawing.Size(24, 25);
            this.f_Label2.TabIndex = 2;
            this.f_Label2.Text = "تا";
            this.f_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_Label6
            // 
            this.f_Label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label6.Location = new System.Drawing.Point(124, 50);
            this.f_Label6.Name = "f_Label6";
            this.f_Label6.Size = new System.Drawing.Size(24, 25);
            this.f_Label6.TabIndex = 2;
            this.f_Label6.Text = "تا";
            this.f_Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtString
            // 
            this.tblDetail.SetColumnSpan(this.txtString, 3);
            this.txtString.EnterColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.txtString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtString.Location = new System.Drawing.Point(150, 128);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.RTL = System.Windows.Forms.RightToLeft.Yes;
            this.txtString.Size = new System.Drawing.Size(149, 19);
            this.txtString.TabIndex = 8;
            this.txtString.ValidationChek = ConditionControl.F_TextBox.NoeValidation.Nullable;
            this.txtString.WaterMark = "رشته";
            this.txtString.WordWrap = false;
            // 
            // f_Label1
            // 
            this.f_Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_Label1.Location = new System.Drawing.Point(275, 0);
            this.f_Label1.Name = "f_Label1";
            this.f_Label1.Size = new System.Drawing.Size(24, 25);
            this.f_Label1.TabIndex = 2;
            this.f_Label1.Text = "از";
            this.f_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAddCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 301);
            this.Controls.Add(this.tblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(0, 28);
            this.Name = "FrmAddCondition";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "افزودن شرط";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddCondition_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddCondition_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAddCondition_KeyDown);
            this.tblMain.ResumeLayout(false);
            this.tblDetail.ResumeLayout(false);
            this.tblDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.ComboBox CboDecide;
        private System.Windows.Forms.ComboBox cboOperand;
        private System.Windows.Forms.ComboBox CboField;
        private F_Label f_Label1;
        private F_Label f_Label2;
        private F_Label f_Label3;
        private F_Label f_Label4;
        private F_TextBox txtNumAz;
        private F_TextBox txtNumEla;
        private F_TextBox dtDateEla;
        private F_TextBox dtDateAz;
        private F_TextBox txtNum;
        private F_TextBox dtDate;
        private F_TextBox txtString;
        private F_Label f_Label5;
        private F_TextBox txtStringAz;
        private F_TextBox txtStringEla;
        private F_Label f_Label6;
        private System.Windows.Forms.ComboBox CboSelect;
        private System.Windows.Forms.TableLayoutPanel tblDetail;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExquitQuery;
    }
}