using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLGV.UserControls
{
    public partial class NDThienDateTimePicker : DateTimePicker
    {
        private void Load()
        {
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CustomFormat = "dd/MM/yyyy";
        }

        public NDThienDateTimePicker()
        {
            InitializeComponent();

            Load();
        }

        public NDThienDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Load();
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
