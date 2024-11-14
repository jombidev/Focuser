using System.Collections;
using Focuser.Dto;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace Focuser
{
    public partial class FocuserMain : Form
    {
        public FocuserMain()
        {
            InitializeComponent();
        }

        private Point startPoint = new Point(0, 0);

        private void FocuserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FocuserMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void FocuserMain_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(e.X, e.Y);
        }
        
        public bool ReportWindow(IntPtr hwnd, int lParam)
        {
            if (!IsWindowVisible(hwnd)) return true;
            var get = GetWindowTitle(hwnd);
            if (get.Length == 0) return true;
            var threadId = GetWindowThreadProcessId(hwnd, out var processId);
            var proc = Process.GetProcessById(processId);
            listProc.Items.Add(new ProcessInfo(get, proc.ProcessName, proc.Id));
            return true;
        }


        private void FocuserMain_Load(object sender, EventArgs e)
        {
            listProc.DisplayMember = "DisplayName";
            listProc.ValueMember = "Pid";
            EnumWindows(ReportWindow, 0);
            Console.WriteLine("Scan finished");
        }

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass,
            string lpszWindow);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        // Callback Declaration
        public delegate bool EnumWindowsCallback(IntPtr hwnd, int lParam);
        [DllImport("user32.dll")]
        private static extern int EnumWindows(EnumWindowsCallback callPtr, int lParam);


        public static string GetWindowTitle(IntPtr hWnd)
        {
            var length = GetWindowTextLength(hWnd) + 1;
            var title = new StringBuilder(length);
            GetWindowText(hWnd, title, length);
            return title.ToString();
        }

        static List<IntPtr> GetAllChildrenWindowHandles(IntPtr hParent, int maxCount)
        {
            List<IntPtr> result = new List<IntPtr>();
            int ct = 0;
            IntPtr prevChild = IntPtr.Zero;
            while (true && ct < maxCount)
            {
                var currChild = FindWindowEx(hParent, prevChild, null, null);
                if (currChild == IntPtr.Zero) break;
                result.Add(currChild);
                prevChild = currChild;
                ++ct;
            }

            return result;
        }
    }
}