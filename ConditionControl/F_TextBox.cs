using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ConditionControl
{
    public class F_TextBox : TextBox
    {
        public enum NoeValidation
        {
            Nullable = 0,
            Number = 1
        }

        public long LongValue { get { return Text.ToLong(); } }
        Form frm;
        public NoeValidation ValidationChek { get; set; }

        Label lblWaterMark = new Label();
        public Color EnterColor { get; set; }

        public string WaterMark
        {
            get { return lblWaterMark.Text; }
            set
            {
                lblWaterMark.Text = value;
                lblWaterMark.ForeColor = value.Equals("*") ? Color.Red : Color.Gray;
            }
        }

        RightToLeft _rtl;
        public RightToLeft RTL
        {
            get { return _rtl; }
            set
            {
                _rtl = value;
                if (value == RightToLeft.Yes)
                {
                    lblWaterMark.TextAlign = System.Drawing.ContentAlignment.TopRight;
                }
                else
                {
                    lblWaterMark.TextAlign = System.Drawing.ContentAlignment.TopLeft;
                }
            }
        }

        public F_TextBox()
        {
            lblWaterMark.Text = string.Empty;
            RTL = RightToLeft.Yes;
            WaterMark = string.Empty;
            Height = 23;
            Multiline = true;


            lblWaterMark.AutoSize = true;
            lblWaterMark.Font = new Font("Tahoma", 8.0F);
            lblWaterMark.ForeColor = Color.Red;
            lblWaterMark.BackColor = Color.Transparent;
            lblWaterMark.AutoSize = false;
            lblWaterMark.Width = Width - 15;
            lblWaterMark.Height = Height;

            lblWaterMark.Left = 5;
            lblWaterMark.Top = (this.Height - lblWaterMark.Height) / 2;

            EnterColor = Color.FromArgb(235, 245, 255);

            lblWaterMark.Click += (s, e) => { Focus(); };
            this.Controls.Add(lblWaterMark);
        }

        protected override void OnCreateControl()
        {
            frm = this.FindForm();
            if (frm != null)
            { Font = frm.Font; }
            else
            {
                Font = new Font("Tahoma", 10.0F);
            }
            if (frm != null)
            {
                RTL = frm.RightToLeft;
            }
            else
            {
                RTL = System.Windows.Forms.RightToLeft.Yes;
            }

            if (ValidationChek == NoeValidation.Number)
            {
                MaxLength = 19;
            }
            else
            {
                MaxLength = 32767;
            }

            Multiline = true;
            AcceptsReturn = false;
            WordWrap = false;

            EnterColor = Color.FromArgb(235, 245, 255);
            base.OnCreateControl();
        }

        protected override void OnEnter(EventArgs e)
        {
            if (ReadOnly == false)
            {
                BackColor = EnterColor;
            }
            SelectAll();
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            BackColor = Color.White;
            base.OnLeave(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (ValidationChek)
            {
                case NoeValidation.Number:
                    if (Char.IsDigit(e.KeyChar))
                    {

                    }
                    else if (e.KeyChar.Equals((char)Keys.Back))
                    {

                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case NoeValidation.Nullable:
                    if (e.KeyChar.Equals((char)Keys.Enter))
                    {
                        e.Handled = true;
                    }
                    break;
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyCode == Keys.Down || (e.KeyCode == Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Add)
            {
                if (ValidationChek == NoeValidation.Number && ReadOnly == false)
                {
                    Text = Text + "000";
                }
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                if (ValidationChek == NoeValidation.Number && Text.EndsWith("000") && ReadOnly == false)
                {
                    Text = Text.Substring(0, Text.Length - 3);
                }
            }
            base.OnKeyDown(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text.Length > 0)
            {
                lblWaterMark.Hide();
            }
            else
            {
                lblWaterMark.Show();
            }
            switch (ValidationChek)
            {
                case NoeValidation.Nullable:
                    break;
                case NoeValidation.Number:
                    Text = Text.ToLong().ToString("#,##.####");
                    if (Text.Length > 0)
                    {
                        SelectionStart = Text.Length;
                    }
                    break;
            }
            base.OnTextChanged(e);
        }
    }
}