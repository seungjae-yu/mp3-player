//made by YuSeungJae
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using mp3Player_YuSeungJae.Properties;
using Shell32;
using CodeFile_Class;
using JLyrics;

namespace mp3Player_YuSeungJae
{
    public partial class Form_MusicPlayer : Form
    {
       #region 노래 재생할수 있게 해주는 Dlllmport

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        #endregion

       #region volumecontroler Dlllmport 

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        #endregion

       #region 생성자(볼륨컨트롤 세팅 포함)

        public Form_MusicPlayer()
        {
            InitializeComponent();

            #region 볼륨컨트롤 세팅
            uint CurrVol = 0;
            // At this point, CurrVol gets assigned the volume
            waveOutGetVolume(IntPtr.Zero, out CurrVol);
            // Calculate the volume
            ushort CalcVol = (ushort)(CurrVol & 0x0000ffff);
            // Get the volume on a scale of 1 to 10 (to fit the trackbar)
            trb_Volume.Value = CalcVol / (ushort.MaxValue / 10);
            #endregion

            rb_normalplay.Checked = true;         
            
            

        }

       #endregion

       #region 노래 추가 (ID3 Tag set포함)

        string[] file, dir;
       
        private void bt_SongAdd_Click(object sender, EventArgs e)
        {           
           oFD_Music.Filter = "All files (*.*)|*.*" ;
           oFD_Music.Multiselect = true;
            
            if (oFD_Music.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               lb_SongName.Text = GetFileName(oFD_Music.FileName);
               
                file = oFD_Music.SafeFileNames;
                dir = oFD_Music.FileNames;
               for (int i = 0; i < file.Length; i++)
               {                 
                   FileClass f = new FileClass();
                   f.filename = file[i];
                   f.paths = dir[i];
                                    
                   string pathname = f.paths.Substring(0, (f.paths.Length - f.filename.Length));

                   f.number = i + 1;
                   f.title = getfileinfo(f.filename, pathname, 21);                  
                   f.album = getfileinfo(f.filename, pathname, 14);
                   f.artist = getfileinfo(f.filename, pathname, 1);
                   f.length = getfileinfo(f.filename, pathname, 27);                   

                   File.Add(f);
                   lv_1.Items.Clear();
               }

               for (int i = 0; i < File.Count; i++)
               {                  
                   lv_1.Items.Add(File[i].filename);                   
                   lv_1.Items[i].SubItems.Add(File[i].number.ToString());
                   lv_1.Items[i].SubItems.Add(File[i].title);                   
                   lv_1.Items[i].SubItems.Add(File[i].album);
                   lv_1.Items[i].SubItems.Add(File[i].artist);
                   lv_1.Items[i].SubItems.Add(File[i].length);                  
                   lv_1.Items[i].SubItems.Add(File[i].paths);
                   
                   }
           }       
       } 
       
       #endregion

       #region 폼 열기

       private void bt_ranking_Click(object sender, EventArgs e)
        {
            Form_ranking open = new Form_ranking();
            open.ShowDialog();
        } 

        private void bt_search_Click(object sender, EventArgs e)
        {
            Form_search open = new Form_search();
            open.ShowDialog();
        }
        
        private void bt_YoutubeDown_Click(object sender, EventArgs e)
        {
            MessageBox.Show("URL을 입력후 변환을 누르고 타이머가 0이되면 다운을 누르세요");
            Form_Youtube open = new Form_Youtube();
            open.ShowDialog();        
        }

       /* private void bt_YoutubeDown_Click(object sender, EventArgs e)
        {
            Form_Youtube open = new Form_Youtube();
            open.ShowDialog();
        }*/

       #endregion

       #region 경로, 확장자 빼고 파일명만 받아주는 함수

        public string GetFileName(string toSplit)
        {
            string[] splitted = toSplit.Split('\\');
            string fin = splitted[splitted.Length - 1]; //경로제거
            
            string[] title_ = fin.Split(Convert.ToChar("."));
            //MessageBox.Show("fin : " + fin);
            if (fin.Contains(".mp3"))
                return fin.Substring(0,fin.IndexOf(title_[title_.Length-1])-1);
            //확장자 제거
            
            return fin;
        } 

        #endregion

       #region 노래재생

        int playindex; //현재 재생중인 파일의 index 저장

        private void bt_SongPlay_Click(object sender, EventArgs e)
        {
            try
            {
                playindex = Convert.ToInt32(lv_1.FocusedItem.SubItems[1].Text.ToString()) - 1;
               
                mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                lb_SongName.Text = lv_1.FocusedItem.SubItems[2].Text.ToString();
                
                string SongName;
                SongName = lv_1.FocusedItem.SubItems[6].Text.ToString();
                
                mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);              
                
                timercal.Start();
              //  leftTime = audio.Mp3Length() / 1000;
                
                if (Lyric.GetLyricsFromFile(SongName, true))
                {   //가사출력부분
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    tb_Lyric.Text = fLyricLists[0];
                }           
            }

            catch { MessageBox.Show("선택된 노래가 없습니다."); }

        }
       #endregion 
       
       #region 노래 정지

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            mciSendString("close MediaFile", null, 0, IntPtr.Zero);    
           // bt_SongStop.Enabled = false;
           //  bt_SongPlay.Enabled = true;
        
            timercal.Stop();
            
        }

        #endregion

       #region 태그 정하는 부분

       private string getfileinfo(string file, string paths, int a)
        {
            string info;
            ShellClass shell = new ShellClass();
            Folder f = shell.NameSpace(@paths);
            FolderItem item = f.ParseName(file);
            info = f.GetDetailsOf(item, a);
            return info;
        }
        public List<FileClass> File = new List<FileClass>();
        
       #endregion        

       #region volume controler

        private void trb_Volume_Scroll(object sender, EventArgs e)
        {
            int NewVolume = ((ushort.MaxValue / 10) * trb_Volume.Value);

            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));

            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);

    
        }



        #endregion                     
       
       #region ListView 선택값 읽기
       
        private void lv_1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            string selectedItem;
                        
                selectedItem = lv_1.FocusedItem.SubItems[2].Text.ToString();           
        }
        #endregion
      
       #region ListView 클릭Event(정지,재생) 
        
        private void lv_1_DoubleClick(object sender, EventArgs e)
        {
            playindex = Convert.ToInt32(lv_1.FocusedItem.SubItems[1].Text.ToString()) -1 ;
            
            //leftTime = audio.GetLength() / 1000;

            lv_1_SelectedIndexChanged(sender,e);
            
            mciSendString("close MediaFile", null, 0, IntPtr.Zero); 
        
            lb_SongName.Text =lv_1.FocusedItem.SubItems[2].Text.ToString();
          
            string SongName;
           
            SongName = lv_1.FocusedItem.SubItems[6].Text.ToString();
            
            mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            
            timercal.Start();
            
            if (Lyric.GetLyricsFromFile(SongName, true))
            {
                fLyricLists = null;
                fLyricLists = Lyric.LyricLists;
                tb_Lyric.Text = fLyricLists[0];
            }                         
        }
       
       #endregion           
              
       #region 노래 Timer (for Timer, Play Option )

        PlayClass audio;
        public double leftTime = 0;
        
        private void timercal_Tick(object sender, EventArgs e)
        {
            try
            {
                audio = new PlayClass();
                int nCurTime = audio.Mp3Position() / 1000;
                int nTotalTime = audio.Mp3Length() / 1000;
                int nCurMinute = nCurTime / 60;
                int nCurSecond = nCurTime % 60;
                int nTotalMinute = nTotalTime / 60;
                int nTotalSecond = nTotalTime % 60;

                lb_SongTime.Text = nCurMinute.ToString() + " : " + nCurSecond.ToString()
                    + " | " + nTotalMinute.ToString() + " : " + nTotalSecond.ToString();                 

                leftTime = leftTime - 0.1;
            }
            catch { }
                //
            if (leftTime <= 0)
            {
                if (rb_onemusicplay.Checked == true) 
                {
                    int nCurTime = audio.Mp3Position(); int nTotalTime = audio.Mp3Length();

                    if (nCurTime == nTotalTime)
                    {
                        try
                        {
                            mciSendString("close MediaFile", null, 0, IntPtr.Zero);
                            lb_SongName.Text = lv_1.FocusedItem.SubItems[2].Text.ToString();

                            string SongName;
                            SongName = lv_1.FocusedItem.SubItems[6].Text.ToString();

                            mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                            mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                            playindex = Convert.ToInt32(lv_1.FocusedItem.SubItems[1].Text.ToString()) - 1;

                            timercal.Start();
                            leftTime = audio.Mp3Length() / 1000;

                            if (Lyric.GetLyricsFromFile(SongName, true))
                            {   //가사출력부분
                                fLyricLists = null;
                                fLyricLists = Lyric.LyricLists;
                                tb_Lyric.Text = fLyricLists[0];
                            }
                        }

                        catch { MessageBox.Show("선택된 노래가 없습니다."); }
                    }
                }
               
                if (rb_normalplay.Checked == true)// 일반재생(순차재생)이면
                {
                    try
                    {
                        int nCurTime = audio.Mp3Position(); int nTotalTime = audio.Mp3Length();

                        if (nCurTime == nTotalTime)
                        {
                            bt_nextsong_Click(null, null);
                        }
                    }
                    catch { }
                }
            } //
           
        }
        #endregion
                
       #region 가사
        private Lyrics Lyric = new Lyrics();
        private String[] fLyricLists;
        ArrayList aFilePathList = new ArrayList();
        
        #endregion

       #region index받아오는 배열

        private int return_index()
        {
            int listview_index;
            listview_index =Convert.ToInt32(lv_1.FocusedItem.SubItems[1].Text.ToString());
            
            return listview_index;
        }

        #endregion

       #region next , before song play

        private void bt_nextsong_Click(object sender, EventArgs e)
        {
            try
            {
                timercal.Start();
                playindex = playindex + 1;

                mciSendString("close MediaFile", null, 0, IntPtr.Zero);

                lv_1.Items[playindex].SubItems[6].Text.ToString();

                string SongName = lv_1.Items[playindex].SubItems[6].Text.ToString();

                lb_SongName.Text = lv_1.Items[playindex].SubItems[0].Text.ToString();

                mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);


                if (Lyric.GetLyricsFromFile(SongName, true))
                {   //가사출력부분
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    tb_Lyric.Text = fLyricLists[0];
                }
            
            }

            catch
            {
                playindex = 0; mciSendString("close MediaFile", null, 0, IntPtr.Zero);

                lv_1.Items[playindex].SubItems[6].Text.ToString();

                string SongName = lv_1.Items[playindex].SubItems[6].Text.ToString();

                lb_SongName.Text = lv_1.Items[playindex].SubItems[0].Text.ToString();

                mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);

                if (Lyric.GetLyricsFromFile(SongName, true))
                {   //가사출력부분
                    fLyricLists = null;
                    fLyricLists = Lyric.LyricLists;
                    tb_Lyric.Text = fLyricLists[0];
                }
            
            }
        
        }
        private void bt_beforesong_Click(object sender, EventArgs e)
        {
            try
            {
                timercal.Start();
                playindex--;

                mciSendString("close MediaFile", null, 0, IntPtr.Zero);

                lv_1.Items[playindex].SubItems[6].Text.ToString();

                string SongName = lv_1.Items[playindex].SubItems[6].Text.ToString();

                lb_SongName.Text = lv_1.Items[playindex].SubItems[0].Text.ToString();

                mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            }
            catch
            {
                MessageBox.Show("이전 노래가 없습니다.");
                playindex = 0;
                lv_1.Items[playindex].SubItems[6].Text.ToString();

                string SongName = lv_1.Items[playindex].SubItems[6].Text.ToString();

                lb_SongName.Text = lv_1.Items[playindex].SubItems[0].Text.ToString();

                mciSendString("open \"" + SongName + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
                mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            }        
        }
       
       #endregion

       #region 목록제거 (index #번호 재설정 기능 추가필요함)
        
        private void bt_songdelete_Click(object sender, EventArgs e)
        {
            lv_1.Update();
            if (lv_1.SelectedItems.Count > 0)
            {
                int count = lv_1.SelectedItems.Count;
                
                for (int i = 0; i < count; i++)
                {
                    lv_1.SelectedItems[0].Remove();
                }            
            }
        }

        #endregion
        
       #region 일시정지 이벤트

        private void bt_pause_Click(object sender, EventArgs e)
        {
            mciSendString("pause mediafile", null, 0, IntPtr.Zero);
            timercal.Stop();
        }

       #endregion

       #region repeat 이벤트

        private void bt_repeat_Click(object sender, EventArgs e)
        {
            mciSendString("play MediaFile REPEAT", null, 0, IntPtr.Zero);
            timercal.Start();
        }

        #endregion       

       #region 옵션
        
        private void rb_onemusicplay_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_onemusicplay.Checked == true)
            { 
                MessageBox.Show("한곡재생이 선택되었습니다.");
            }
        }

        private void rb_normalplay_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_normalplay.Checked == true)
            {
                MessageBox.Show("순차재생이 선택되었습니다.");
            }
        }

        #endregion
    }
}