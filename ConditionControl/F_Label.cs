using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConditionControl
{
    public class F_Label : Label
    {
        public F_Label()
        {
        }
        protected override void OnCreateControl()
        {
            AutoSize = false;
            Height = 23;
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            base.OnCreateControl();
        }
    }
}
