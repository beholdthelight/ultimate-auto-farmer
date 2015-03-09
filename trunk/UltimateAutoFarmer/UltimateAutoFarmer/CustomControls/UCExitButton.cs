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
    public partial class UCExitButton : UserControl
    {
        private Bitmap BGImage = Properties.Resources.exit;
        private Bitmap BGImageHover = Properties.Resources.exit_h;

        public UCExitButton()
        {
            InitializeComponent();
        }

        private void UCExitButton_MouseEnter(object sender, EventArgs e)
        {
            BackgroundImage = BGImageHover;
        }

        private void UCExitButton_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = BGImage;
        }

        private void UCExitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
