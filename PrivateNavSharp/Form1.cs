using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace PrivateNavSharp
{
    public partial class Form1 : Form
    {
        CefSettings settings = new CefSettings();
        public ChromiumWebBrowser chrome = null;
        public Form1()
        {
            InitializeComponent();
            Cef.Initialize(settings);
            chrome = new ChromiumWebBrowser("https://google.com");
        }
        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                urlBar.Text = e.Address;
            }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WebView_Container.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            chrome.Load(urlBar.Text);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
        }
        private void btnForward_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoForward)
                chrome.Forward();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoBack)
                chrome.Back();
        }
    }
}
