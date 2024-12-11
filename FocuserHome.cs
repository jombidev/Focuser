using Focuser.Dto;
using System.Diagnostics;
using System.Text;
using Focuser.Extern;

namespace Focuser
{
    public partial class FocuserMain : Form
    {
        private readonly ProcessInfo passedInfo;
        private readonly DateTime endTime;
        private DateTime activeTime;

        public FocuserMain(ProcessInfo info, DateTime endTime)
        {
            this.endTime = endTime;
            passedInfo = info;

            InitializeComponent();
            proc.Text = passedInfo.Title;

            new FocuserAlert("시작함니다", 2000).Show();
        }

        private Point _startPoint = new(0, 0);

        private void FocuserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FocuserMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
            }
        }

        private void FocuserMain_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = new Point(e.X, e.Y);
        }


        private void FocuserMain_Load(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var focused = User32Ext.GetFocusedHwnd();
            var title = User32Ext.GetWindowTitle(focused);
            activeProc.Text = title;

            User32Ext.GetPidByHwnd(focused, out var focusedProcessId);

            try
            {
                Process.GetProcessById(passedInfo.Pid);
            }
            catch (ArgumentException)
            {
                // TEXT
            }

            if (passedInfo.Pid == focusedProcessId || focusedProcessId == Process.GetCurrentProcess().Id)
            {
                activeTime = DateTime.Now;
            }

            if (DateTime.Now - activeTime > TimeSpan.FromMilliseconds(10000))
            {
                activeTime = DateTime.Now;
                new FocuserAlert("작업하세요!!!!!!!!!!!!!!!!!!!!!!!!!!! 딴짓하지말고", 2000).Show();
            }
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            var timeSpan = endTime - DateTime.Now;
            if (timeSpan < TimeSpan.Zero)
            {
                Application.Exit();
                Environment.Exit(0);
            }
            timeRemaining.Text = ToReadableString(timeSpan);

            if (enableAlert.Checked && int.TryParse(endTimeBox.Text, out var result))
            {
                if (timeSpan.Subtract(TimeSpan.FromMinutes(result)) < TimeSpan.Zero)
                {
                    enableAlert.Checked = false;
                    new FocuserAlert($"마감까지 {result}분 남았습니다!! 화이팅", 2000).Show();
                }
            }
        }
        public static string ToReadableString(TimeSpan span)
        {
            var duration = span.Duration();
            string formatted = string.Format("{0}{1}{2}{3}",
                duration.Days > 0 ? $"{span.Days:0} 일 " : string.Empty,
                duration.Hours > 0 ? $"{span.Hours:0} 시간 " : string.Empty,
                duration.Minutes > 0 ? $"{span.Minutes:0} 분 " : string.Empty,
                duration.Seconds > 0 ? $"{span.Seconds:0} 초" : string.Empty).TrimEnd();

            if (string.IsNullOrEmpty(formatted)) formatted = "0 초";

            return formatted;
        }

        private void endTimeBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(endTimeBox.Text, out var num) || num < 0)
            {
                enableAlert.Checked = false;
                endTimeBox.Text = string.Empty;
                new FocuserAlert("숫자만좀 넣어요..", 2000).Show();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "어디저장할래";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != string.Empty)
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                fs.Write(Encoding.UTF8.GetBytes(memoTextBox.Text));
                fs.Close();
            }
        }
    }
}