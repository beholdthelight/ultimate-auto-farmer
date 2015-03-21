using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Reflection;

namespace UltimateAutoFarmer.CustomControls
{
    public partial class UCLabel : UserControl
    {

        #region Members

        private OwnFonts m_customFont = OwnFonts.Joystick;
        private int m_fontSize = 10;
        private string m_text = "";
        private YesNo m_bold = YesNo.No;

        #endregion Members

        #region Properties, Enums

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Bindable(true)]
        [Description("The text of the label"), Category("CustomAttributes")]
        public override String Text
        {
            get
            {
                this.m_text = label.Text;
                return this.m_text;
            }
            set
            {
                this.m_text = label.Text = value;
            }
        }

        [DefaultValue(10)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("The size of the font"), Category("CustomAttributes")]
        public int FontSize
        {
            get
            {
                return this.m_fontSize;
            }
            set
            {
                this.m_fontSize = value;
                SetFont(this.m_customFont, value, m_bold);
            }
        }

        [DefaultValue(OwnFonts.Joystick)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("The font of the label"), Category("CustomAttributes")]
        public OwnFonts CustomFont
        {
            get
            {
                return this.m_customFont;
            }
            set
            {
                this.m_customFont = value;
                SetFont(value, this.m_fontSize, this.m_bold);
            }
        }

        public override Font Font
        {
            get { return label.Font; }
            set { label.Font = value; }
        }

        [DefaultValue(YesNo.No)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Description("The bold property of the font"), Category("CustomAttributes")]
        public YesNo Bold
        {
            get
            {
                return this.m_bold;
            }
            set
            {
                this.m_bold = value;
                SetFont(m_customFont, this.m_fontSize, value);
            }
        }


        public enum OwnFonts
        {
            Comfortaa,
            Joystick,
            Checkout
        }

        public enum YesNo
        {
            Yes,
            No
        }

        #endregion Properties, Enums

        public UCLabel()
        {
            InitializeComponent();
            AutoScaleMode = AutoScaleMode.None;
            SetFont(CustomFont, m_fontSize, m_bold);
        }

        #region Public Functions

        public void SetFont(OwnFonts font, int fontSize, YesNo bold)
        {
            string fontName = "";

            switch (font)
            {
                case OwnFonts.Comfortaa:
                    fontName = "Comfortaa_Regular.ttf";
                    break;
                case OwnFonts.Joystick:
                    fontName = "Joystick.ttf";
                    break;
                case OwnFonts.Checkout:
                    fontName = "Checkout.ttf";
                    break;
                default:
                    fontName = "Comfortaa_Regular.ttf";
                    break;
            }

            string nameSpc = Assembly.GetExecutingAssembly().GetName().Name;
            Assembly aa = Assembly.GetExecutingAssembly();
            Stream stmFont = aa.GetManifestResourceStream(nameSpc + ".Fonts." + fontName);
            if (null != stmFont)
            {
                byte[] reft = new Byte[stmFont.Length];
                stmFont.Read(reft, 0, (int)stmFont.Length);


                IntPtr mfont = Marshal.AllocCoTaskMem(reft.Length);
                if (null != mfont)
                {
                    Marshal.Copy(reft, 0, mfont, reft.Length);
                    PrivateFontCollection fontcollect = new PrivateFontCollection();
                    fontcollect.AddMemoryFont(mfont, reft.Length);
                    this.Font = new Font(fontcollect.Families[0].Name, fontSize, (bold == YesNo.Yes)?FontStyle.Bold:FontStyle.Regular);
                    Marshal.FreeCoTaskMem(mfont);
                }
            }
        }
        #endregion

    }
}
