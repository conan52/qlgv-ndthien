using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLGV.UserControls
{
    public partial class NDThienPictureBox : PictureBox
    {
        private string _firstImage;
        private string _newImage;
        private bool _isChangeImage;
        private bool _isFirst = true;

        public bool IsChangeImage
        {
            get { return _isChangeImage; }
        }
        
        public NDThienPictureBox()
        {
            InitializeComponent();
        }

        public NDThienPictureBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
            if (_isFirst)
            {
                _firstImage = this.ImageLocation;
                _isFirst = false;
            }
            else
            {
                _newImage = this.ImageLocation;
                _isChangeImage = _firstImage != _newImage;
            }
        }
    }
}
