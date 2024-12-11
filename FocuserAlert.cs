using Focuser.Extern;

namespace Focuser
{
    public partial class FocuserAlert : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

        public FocuserAlert(string message, int time)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();

            TransparencyKey = BackColor = Color.White;
            TopMost = true;

            var am = Screen.PrimaryScreen!.Bounds;
            Size = am.Size;

            label1.Text = message;
            timer1.Enabled = true;
            timer1.Interval = time;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}