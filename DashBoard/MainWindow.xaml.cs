
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DashBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true,
             CharSet = CharSet.Unicode, ExactSpelling = true,
             CallingConvention = CallingConvention.StdCall)]
        private static extern long GetWindowThreadProcessId(long hWnd, long lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", EntryPoint = "GetWindowLongA", SetLastError = true)]
        private static extern long GetWindowLong(IntPtr hwnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLongA", SetLastError = true)]
        public static extern int SetWindowLongA([System.Runtime.InteropServices.InAttribute()] System.IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern long SetWindowPos(IntPtr hwnd, long hWndInsertAfter, long x, long y, long cx, long cy, long wFlags);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool MoveWindow(IntPtr hwnd, int x, int y, int cx, int cy, bool repaint);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref Rect Rect);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SendMessage(IntPtr hWnd, int msg,int wparam,int lparam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
        private const int SWP_NOOWNERZORDER = 0x200;
        private const int SWP_NOREDRAW = 0x8;
        private const int SWP_NOZORDER = 0x4;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int WS_EX_MDICHILD = 0x40;
        private const int SWP_FRAMECHANGED = 0x20;
        private const int SWP_NOACTIVATE = 0x10;
        private const int SWP_ASYNCWINDOWPOS = 0x4000;
        private const int SWP_NOMOVE = 0x2;
        private const int SWP_NOSIZE = 0x1;
        private const int GWL_STYLE = (-16);
        private const int WS_VISIBLE = 0x10000000;
        private const int WS_CHILD = 0x40000000;
        const int WS_CAPTION = 0x00C00000;
        const int SW_MAXIMIZE = 0x3;
        const int WM_SIZE = 0x0005;


        IntPtr _appWin;

        private Process _childp;
        private Process _childp1;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;  
        }
        public List<missingPieceInfo> missing;
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
         
            //Results.Content = new DbQuerys();
            //Results1.Content = new cpr();
            //     AssemblyConnectionString = connections["AssemblyEntities"].ConnectionString;

            //OTSAccess dal = new OTSAccess(StoreConnectionString);
            //missing = dal.FindMissingOrders("test");
            //data.ItemsSource = missing;
            //string error = string.Empty;
            //System.Collections.ObjectModel.ObservableCollection<Category> cats = dal.GetCats(out error);

            //     string basedir = System.AppDomain.CurrentDomain.BaseDirectory;

            NewAppFrame(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\", "BCS.exe", bcs);
            NewAppFrame(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\", "qcs.exe", qcs);
            NewAppFrame(@"C:\Users\jmcfe\OneDrive\Documents\Visual Studio 2017\Projects\scheduler\scheduler\bin\Debug\", "scheduler.exe", sch);
            WebBrowserHelper.ClearCache();
            //wbSample.Navigate("http://192.168.1.3");
            //HideScriptErrors(wbSample, true);
      //      NewAppFrame(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\", "qcs.exe", test3);
            //       ToDay.Text = DateTime.Now.ToLongDateString();
        }

        void NewAppFrame(string basedir,string exe, DockPanel panel)
        {
            
            string exeName = basedir + exe;
            var procInfo = new System.Diagnostics.ProcessStartInfo(exeName);
            procInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(exeName);
            procInfo.WindowStyle = ProcessWindowStyle.Minimized;
            // Start the process
            try
            {
                _childp = Process.Start(procInfo);
            }
            catch (Exception e1)
            {

            }
            System.Windows.Forms.Panel _pnlSched = new System.Windows.Forms.Panel();
            WindowsFormsHost windowsFormsHost1 = new WindowsFormsHost();

            windowsFormsHost1.Child = _pnlSched;

            panel.Children.Add(windowsFormsHost1);

            // Wait for process to be created and enter idle condition
            //    _childp.WaitForInputIdle();
            // The main window handle may be unavailable for a while, just wait for it
            while (_childp.MainWindowHandle == IntPtr.Zero)
            {
                Thread.Yield();
            }

            // Get the main handle
            _appWin = _childp.MainWindowHandle;
            //      PR.WaitForInputIdle(); // true if the associated process has reached an idle state.
            SetParent(_appWin, _pnlSched.Handle); // loading exe to the wpf window.
           
            SetWindowPos(_pnlSched.Handle,IntPtr.Zero, 0, 0, 100, 100, SWP_SHOWWINDOW);
            // if (GetWindowRect(_pnlSched.Handle, ref Rect))
            ////     MoveWindow(_appWin, (int)Rect.Left, (int)Rect.Right, (int)Rect.Right - (int)Rect.Left, (int)Rect.Bottom - (int)Rect.Top + 50, true);
            //     MoveWindow(_appWin, 0, 0, 800, 800, true);
            int oldStyle = (int)GetWindowLong(_appWin, GWL_STYLE);
        }
        //this will hide the ugly script errors that are thrown by the WPF browser.
        public void HideScriptErrors(WebBrowser wb, bool Hide)
        {
            FieldInfo fiComWebBrowser = typeof(WebBrowser)
                .GetField("_axIWebBrowser2",
                          BindingFlags.Instance | BindingFlags.NonPublic);
            if (fiComWebBrowser == null) return;
            object objComWebBrowser = fiComWebBrowser.GetValue(wb);
            if (objComWebBrowser == null) return;
            objComWebBrowser.GetType().InvokeMember(
                "Silent", BindingFlags.SetProperty, null, objComWebBrowser,
                new object[] { Hide });
        }
       

        private void wbSample_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
 //           txtUrl.Text = e.Uri.OriginalString;
        }
        private void bcs_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\OnTheSpot.exe");
        }

        private void qcs_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\Repos\OnSpot17\OnTheSpot\bin\Debug\qcs.exe");
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            //base.OnClosing(e);
            //this.WindowState = System.Windows.WindowState.Minimized;
            //e.Cancel = true;
        }
    }
}
