using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltimateAutoFarmer.CustomControls
{
    public partial class UCLabel : UserControl
    {

        public UCLabel()
        {
            InitializeComponent();
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("The text of the label"), Category("CustomAttributes")]
        public override String Text
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("The font of the text"), Category("CustomAttributes")]
        public override Font Font
        {
            get { return label.Font; }
            set { label.Font = value; }
        }
    }
}
