using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace CefFormStartPosition
{
    public partial class BrowserDialog : Form
    {
        public BrowserDialog()
        {
            InitializeComponent();

            // Removing this line will cause the dialog to consistently render correctly
            StartPosition = FormStartPosition.CenterParent;

            InitializeCefSharp();

            Task.Run(() =>
            {
                Thread.Sleep(1000);
                Action closeAction = Close;
                Invoke(closeAction);
            });
        }

        private void InitializeCefSharp()
        {
            Uri indexUri = new Uri(Path.Combine(new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName, "index.html"));
            ChromiumWebBrowser chromiumWebBrowser = new ChromiumWebBrowser(indexUri.AbsoluteUri);
            Controls.Add(chromiumWebBrowser);
        }
    }
}
