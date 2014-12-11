using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLGV.UserControls
{
    public partial class NDThienTextBox : TextBox
    {
        public NDThienTextBox()
        {
            InitializeComponent();
        }

        public NDThienTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = System.Drawing.Color.Yellow;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = System.Drawing.Color.White;
        }
    }
}
