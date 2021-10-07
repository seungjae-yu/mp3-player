using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mp3Player_YuSeungJae
{
    public partial class Form_ranking : Form
    {
        public Form_ranking()
        {
            InitializeComponent();
            wb_ranking.Navigate("http://music.naver.com/listen/top100.nhn?domain=TOTAL");
        }
    }
}
