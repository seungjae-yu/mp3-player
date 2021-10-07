using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mshtml;


namespace mp3Player_YuSeungJae
{
    public partial class Form_Youtube : Form
    {
        public Form_Youtube()
        {
            InitializeComponent();

            //webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://www.video2mp3.net/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            if (this.webBrowser1.ReadyState.Equals(WebBrowserReadyState.Complete))
            {
                int nStep = 0;
                switch (nStep)
                {
                    case 1:
                        Step_InsertURL();
                        break;

                    case 2:
                        Step_Download();
                        break;
                }

                nStep++;
            }
        }

        HtmlDocument doc = null;

        private void Step_InsertURL()
        {
            doc = webBrowser1.Document as HtmlDocument;

            try
            {
                doc.GetElementById("convert-input").SetAttribute("value", tb_Youtube.Text);

                mshtml.HTMLDocument hdoc = doc.DomDocument as mshtml.HTMLDocument;

                webBrowser1.Navigate("http://www.video2mp3.net/loading.php?url=" + tb_Youtube.Text);
            }

            catch { }
        }

        private void Step_Download()
        {          
            doc = webBrowser1.Document as HtmlDocument;

            mshtml.HTMLDocument hdoc = doc.DomDocument as mshtml.HTMLDocument;

            int nOrder = 0;

            foreach (mshtml.IHTMLElement hel in (mshtml.IHTMLElementCollection)hdoc.body.all)
            {
                try
                {
                    if (hel.getAttribute("id", 0).ToString().Trim() != "")
                    {
                        if (hel.getAttribute("id", 0).ToString().Trim().IndexOf("do-download-video") > -1)
                        {
                            if (nOrder == 0)
                                hel.click();

                            nOrder++;
                        }              
                    }                
                }
                catch { }
            }
        }

     //   private System.Windows.Forms.Timer timer1;
        private int counter = 30;
        private void bt_convert_Click(object sender, EventArgs e)
        {
            Step_InsertURL();
          /*  string show = "약 15초정도 기다린 후 '다운' 키를 눌러주세요 ";
            MessageBox.Show(show);    */
            int counter = 30;
            timer_countdown = new System.Windows.Forms.Timer();
            timer_countdown.Tick += new EventHandler(timer_countdown_Tick);
            timer_countdown.Interval = 1000;
            timer_countdown.Start();
            lb_counter.Text = counter.ToString();       
        }
        
        private void bt_convert2_Click(object sender, EventArgs e)
        {
            Step_Download();
        }

        private void timer_countdown_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                if (counter == 0)
                { timer_countdown.Stop(); }

                lb_counter.Text = counter.ToString();
            }            
            else counter = 0;
        
        }

    }
}
