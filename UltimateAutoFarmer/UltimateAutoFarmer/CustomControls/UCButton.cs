using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateAutoFarmer.CustomControls
{
    public partial class UCButton : UserControl
    {
        [Description("Define default image of the Control"), Category("Appearance")]
        public Bitmap BackgroundImageDefault { get; set; }

        [Description("Define hover image of the Control"), Category("Appearance")]
        public Bitmap BackgroundImageHover { get; set; }

        public UCButton()
        {
            InitializeComponent();
        }

        public void Initialize(Bitmap backgroundImage, Bitmap backgroundImageHover)
        {
            BackgroundImage = BackgroundImageDefault = (Bitmap)backgroundImage;
            BackgroundImageHover = backgroundImageHover;
        }

        private void UCButton_MouseEnter(object sender, EventArgs e)
        {
            if(BackgroundImageHover != null)
                BackgroundImage = BackgroundImageHover;
        }

        private void UCButton_MouseLeave(object sender, EventArgs e)
        {
            if (BackgroundImageDefault != null)
                BackgroundImage = BackgroundImageDefault;
        }
    }
}
