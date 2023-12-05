using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WinApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr HWnd,string Text,string Caption,int Option);
        [DllImport("user32.dll")]
        public static extern bool SetWindowTextA(IntPtr Hwnd, string Caption);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowA(string className,string windowName);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr HWnd,uint Msg,int wParam,[MarshalAs(UnmanagedType.LPStr)] string lParam);
        public const uint settext = 0xBC;
        delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern string GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        private string ClassName;
        private void b_call_Click(object sender, EventArgs e)
        {
            MessageBox(IntPtr.Zero, "Сообщение в окне", "Окно для сообщений", 1);
            SetWindowTextA(this.Handle, "Заголовок какого то окна");
        }

        private void b_what_Click(object sender, EventArgs e)
        {
            IntPtr hmd = FindWindowA(null, tb_winname.Text);
            /*SetWindowTextA(FindWindowA("Form", tb_winname.Text), tb_textClass.Text);*/
            SendMessage(hmd, settext, 0, tb_textClass.Text);
        }
        string GetWindowText(IntPtr hWnd)
        {
            int len = GetWindowTextLength(hWnd) + 1;
            StringBuilder sb = new StringBuilder(len);
            len = GetWindowText(hWnd, sb, len);
            return sb.ToString(0, len);
        }
        private void b_search_Click(object sender, EventArgs e)
        {
            EnumWindows((hWnd, lParam) => {
                if (IsWindowVisible(hWnd) && GetWindowTextLength(hWnd) != 0)
                {
                    StringBuilder className = new StringBuilder(256);
                    string nRet = GetClassName(Handle, className, className.Capacity);
                    ClassName = className.ToString();
                    tb_windows.Text += GetWindowText(hWnd) +" "+ ClassName + nRet+"\r\n";
                }
                return true;
            }, IntPtr.Zero);
        }
    }
}
