using System.Collections;
using Focuser.Dto;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Focuser.Extern;

namespace Focuser
{
    public partial class FocuserMain : Form
    {
        private readonly List<ProcessInfo> CurrentDataSource = [];

        public FocuserMain()
        {
            InitializeComponent();
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

        public bool ReportWindow(IntPtr hwnd, int lParam)
        {
            if (!User32Ext.IsWindowVisible(hwnd)) return true;
            var get = User32Ext.GetWindowTitle(hwnd);
            if (get.Length == 0) return true;

            User32Ext.GetPidByHwnd(hwnd, out var processId);
            Process proc = Process.GetProcessById(processId);
            CurrentDataSource.Add(new ProcessInfo(get, proc.ProcessName, proc.Id));
            return true;
        }


        private void FocuserMain_Load(object sender, EventArgs e)
        {
            User32Ext.GetWindowInformation(ReportWindow, 0);
            listProc.DataSource = CurrentDataSource;
            listProc.DisplayMember = "DisplayName";
            listProc.ValueMember = "Pid";
            Console.WriteLine("Scan finished");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CurrentDataSource.Clear();
            User32Ext.GetWindowInformation(ReportWindow, 0);

            listProc.DataSource = null;
            listProc.DataSource = CurrentDataSource;

            listProc.DisplayMember = "DisplayName";
            listProc.ValueMember = "Pid";
            Console.WriteLine("Scan finished");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }
    }
}