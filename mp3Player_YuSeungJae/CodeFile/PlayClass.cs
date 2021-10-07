using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace mp3Player_YuSeungJae
{
    class PlayClass
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn,
            int iReturnLength, IntPtr hwndCallback);      

        public int Mp3Position()
        {
            StringBuilder sb = new StringBuilder(128);
            mciSendString("status mediafile position", sb, 128, IntPtr.Zero);
            int songlength = Convert.ToInt32(sb.ToString());
            return songlength;
        }

        public int Mp3Length()
        {
            StringBuilder sb = new StringBuilder(128);
            mciSendString("status mediafile length", sb, 128, IntPtr.Zero);
            int songlength = Convert.ToInt32(sb.ToString());
            return songlength;
        }
    }
}
