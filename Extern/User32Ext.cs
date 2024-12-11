using System.Runtime.InteropServices;
using System.Text;

namespace Focuser.Extern;

public static class User32Ext
{
    [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
    private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    private static extern int GetWindowTextLength(IntPtr hWnd);
        
    [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetWindowThreadProcessId")]
    public static extern int GetPidByHwnd(IntPtr hWnd, out int lpdwProcessId);
        
    [DllImport("user32.dll", SetLastError = true)]
    public static extern bool IsWindowVisible(IntPtr hWnd);

    public delegate bool EnumWindowsCallback(IntPtr hwnd, int lParam);
    
    [DllImport("user32.dll", SetLastError = true, EntryPoint = "EnumWindows")]
    public static extern int GetWindowInformation(EnumWindowsCallback callPtr, int lParam);

    [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
    public static extern IntPtr GetFocusedHwnd();
    
    [DllImport("user32.dll", SetLastError = true)]
    public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
    
    [DllImport("user32.dll")]
    public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);


    public static string GetWindowTitle(IntPtr hWnd)
    {
        var length = GetWindowTextLength(hWnd) + 1;
        var title = new StringBuilder(length);
        GetWindowText(hWnd, title, length);
        return title.ToString();
    }
}