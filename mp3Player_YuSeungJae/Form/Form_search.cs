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
    public partial class Form_search : Form
    {
        public Form_search()
        {
            InitializeComponent();
            webBrowser2.Navigate("http://www.youtube.com/music");
        }
        
        
    }
}
