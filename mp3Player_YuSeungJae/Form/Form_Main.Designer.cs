namespace mp3Player_YuSeungJae
{
    partial class Form_MusicPlayer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_SongAdd = new System.Windows.Forms.Button();
            this.bt_ranking = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.oFD_Music = new System.Windows.Forms.OpenFileDialog();
            this.bt_SongPlay = new System.Windows.Forms.Button();
            this.bt_SongStop = new System.Windows.Forms.Button();
            this.lb_SongName = new System.Windows.Forms.Label();
            this.trb_Volume = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.파일추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폴더추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_YoutubeDown = new System.Windows.Forms.Button();
            this.lb_SongTime = new System.Windows.Forms.Label();
            this.lv_1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timercal = new System.Windows.Forms.Timer(this.components);
            this.tb_Lyric = new System.Windows.Forms.TextBox();
            this.bt_beforesong = new System.Windows.Forms.Button();
            this.bt_nextsong = new System.Windows.Forms.Button();
            this.bt_songdelete = new System.Windows.Forms.Button();
            this.bt_pause = new System.Windows.Forms.Button();
            this.bt_repeat = new System.Windows.Forms.Button();
            this.rb_onemusicplay = new System.Windows.Forms.RadioButton();
            this.rb_normalplay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Volume)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_SongAdd
            // 
            this.bt_SongAdd.BackColor = System.Drawing.Color.Transparent;
            this.bt_SongAdd.BackgroundImage = global::mp3Player_YuSeungJae.Properties.Resources._119_oksk333;
            this.bt_SongAdd.FlatAppearance.BorderSize = 0;
            this.bt_SongAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SongAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_SongAdd.Location = new System.Drawing.Point(28, 12);
            this.bt_SongAdd.Name = "bt_SongAdd";
            this.bt_SongAdd.Size = new System.Drawing.Size(76, 52);
            this.bt_SongAdd.TabIndex = 0;
            this.bt_SongAdd.Text = "노래 추가";
            this.bt_SongAdd.UseVisualStyleBackColor = false;
            this.bt_SongAdd.Click += new System.EventHandler(this.bt_SongAdd_Click);
            // 
            // bt_ranking
            // 
            this.bt_ranking.FlatAppearance.BorderSize = 0;
            this.bt_ranking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ranking.Image = global::mp3Player_YuSeungJae.Properties.Resources._119_oksk333;
            this.bt_ranking.Location = new System.Drawing.Point(107, 12);
            this.bt_ranking.Name = "bt_ranking";
            this.bt_ranking.Size = new System.Drawing.Size(78, 52);
            this.bt_ranking.TabIndex = 1;
            this.bt_ranking.Text = "실시간 순위";
            this.bt_ranking.UseVisualStyleBackColor = true;
            this.bt_ranking.Click += new System.EventHandler(this.bt_ranking_Click);
            // 
            // bt_search
            // 
            this.bt_search.FlatAppearance.BorderSize = 0;
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Image = global::mp3Player_YuSeungJae.Properties.Resources._119_oksk333;
            this.bt_search.Location = new System.Drawing.Point(191, 12);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 52);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "노래찾기";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // oFD_Music
            // 
            this.oFD_Music.FileName = "oFd_MusicOpen";
            // 
            // bt_SongPlay
            // 
            this.bt_SongPlay.FlatAppearance.BorderSize = 0;
            this.bt_SongPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SongPlay.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_play;
            this.bt_SongPlay.Location = new System.Drawing.Point(72, 127);
            this.bt_SongPlay.Name = "bt_SongPlay";
            this.bt_SongPlay.Size = new System.Drawing.Size(54, 52);
            this.bt_SongPlay.TabIndex = 5;
            this.bt_SongPlay.UseVisualStyleBackColor = true;
            this.bt_SongPlay.Click += new System.EventHandler(this.bt_SongPlay_Click);
            // 
            // bt_SongStop
            // 
            this.bt_SongStop.FlatAppearance.BorderSize = 0;
            this.bt_SongStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_SongStop.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_stop;
            this.bt_SongStop.Location = new System.Drawing.Point(132, 127);
            this.bt_SongStop.Name = "bt_SongStop";
            this.bt_SongStop.Size = new System.Drawing.Size(54, 52);
            this.bt_SongStop.TabIndex = 6;
            this.bt_SongStop.UseVisualStyleBackColor = true;
            this.bt_SongStop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // lb_SongName
            // 
            this.lb_SongName.AutoSize = true;
            this.lb_SongName.BackColor = System.Drawing.Color.Transparent;
            this.lb_SongName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_SongName.Location = new System.Drawing.Point(162, 81);
            this.lb_SongName.Name = "lb_SongName";
            this.lb_SongName.Size = new System.Drawing.Size(0, 12);
            this.lb_SongName.TabIndex = 7;
            // 
            // trb_Volume
            // 
            this.trb_Volume.BackColor = System.Drawing.Color.Chocolate;
            this.trb_Volume.Location = new System.Drawing.Point(315, 100);
            this.trb_Volume.Maximum = 20;
            this.trb_Volume.Name = "trb_Volume";
            this.trb_Volume.Size = new System.Drawing.Size(106, 45);
            this.trb_Volume.TabIndex = 8;
            this.trb_Volume.Scroll += new System.EventHandler(this.trb_Volume_Scroll);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일추가ToolStripMenuItem,
            this.폴더추가ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 48);
            // 
            // 파일추가ToolStripMenuItem
            // 
            this.파일추가ToolStripMenuItem.Name = "파일추가ToolStripMenuItem";
            this.파일추가ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.파일추가ToolStripMenuItem.Text = "파일추가";
            // 
            // 폴더추가ToolStripMenuItem
            // 
            this.폴더추가ToolStripMenuItem.Name = "폴더추가ToolStripMenuItem";
            this.폴더추가ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.폴더추가ToolStripMenuItem.Text = "폴더추가";
            // 
            // bt_YoutubeDown
            // 
            this.bt_YoutubeDown.FlatAppearance.BorderSize = 0;
            this.bt_YoutubeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_YoutubeDown.Image = global::mp3Player_YuSeungJae.Properties.Resources._119_oksk333;
            this.bt_YoutubeDown.Location = new System.Drawing.Point(272, 12);
            this.bt_YoutubeDown.Name = "bt_YoutubeDown";
            this.bt_YoutubeDown.Size = new System.Drawing.Size(149, 52);
            this.bt_YoutubeDown.TabIndex = 12;
            this.bt_YoutubeDown.Text = "유튜브 동영상 음원 다운";
            this.bt_YoutubeDown.UseVisualStyleBackColor = true;
            this.bt_YoutubeDown.Click += new System.EventHandler(this.bt_YoutubeDown_Click);
            // 
            // lb_SongTime
            // 
            this.lb_SongTime.AutoSize = true;
            this.lb_SongTime.BackColor = System.Drawing.Color.Transparent;
            this.lb_SongTime.Location = new System.Drawing.Point(44, 81);
            this.lb_SongTime.Name = "lb_SongTime";
            this.lb_SongTime.Size = new System.Drawing.Size(75, 12);
            this.lb_SongTime.TabIndex = 15;
            this.lb_SongTime.Text = "00:00 | 00:00";
            // 
            // lv_1
            // 
            this.lv_1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.filename,
            this.title,
            this.artist,
            this.album,
            this.length,
            this.path});
            this.lv_1.Location = new System.Drawing.Point(432, 10);
            this.lv_1.Name = "lv_1";
            this.lv_1.Size = new System.Drawing.Size(458, 319);
            this.lv_1.TabIndex = 16;
            this.lv_1.UseCompatibleStateImageBehavior = false;
            this.lv_1.View = System.Windows.Forms.View.Details;
            this.lv_1.SelectedIndexChanged += new System.EventHandler(this.lv_1_SelectedIndexChanged);
            this.lv_1.DoubleClick += new System.EventHandler(this.lv_1_DoubleClick);
            // 
            // number
            // 
            this.number.DisplayIndex = 1;
            this.number.Text = "파일 이름";
            this.number.Width = 157;
            // 
            // filename
            // 
            this.filename.DisplayIndex = 0;
            this.filename.Text = "#";
            this.filename.Width = 0;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.Width = 113;
            // 
            // artist
            // 
            this.artist.Text = "앨범";
            this.artist.Width = 64;
            // 
            // album
            // 
            this.album.Text = "파일크기";
            // 
            // length
            // 
            this.length.Text = "길이";
            // 
            // path
            // 
            this.path.Text = "경로";
            this.path.Width = 0;
            // 
            // timercal
            // 
            this.timercal.Tick += new System.EventHandler(this.timercal_Tick);
            // 
            // tb_Lyric
            // 
            this.tb_Lyric.Location = new System.Drawing.Point(12, 185);
            this.tb_Lyric.Multiline = true;
            this.tb_Lyric.Name = "tb_Lyric";
            this.tb_Lyric.ReadOnly = true;
            this.tb_Lyric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Lyric.Size = new System.Drawing.Size(414, 145);
            this.tb_Lyric.TabIndex = 1;
            // 
            // bt_beforesong
            // 
            this.bt_beforesong.FlatAppearance.BorderSize = 0;
            this.bt_beforesong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_beforesong.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_beforemusic1;
            this.bt_beforesong.Location = new System.Drawing.Point(12, 127);
            this.bt_beforesong.Name = "bt_beforesong";
            this.bt_beforesong.Size = new System.Drawing.Size(54, 52);
            this.bt_beforesong.TabIndex = 17;
            this.bt_beforesong.UseVisualStyleBackColor = true;
            this.bt_beforesong.Click += new System.EventHandler(this.bt_beforesong_Click);
            // 
            // bt_nextsong
            // 
            this.bt_nextsong.FlatAppearance.BorderSize = 0;
            this.bt_nextsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nextsong.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_nextmusic;
            this.bt_nextsong.Location = new System.Drawing.Point(315, 127);
            this.bt_nextsong.Name = "bt_nextsong";
            this.bt_nextsong.Size = new System.Drawing.Size(54, 52);
            this.bt_nextsong.TabIndex = 18;
            this.bt_nextsong.UseVisualStyleBackColor = true;
            this.bt_nextsong.Click += new System.EventHandler(this.bt_nextsong_Click);
            // 
            // bt_songdelete
            // 
            this.bt_songdelete.FlatAppearance.BorderSize = 0;
            this.bt_songdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_songdelete.Image = global::mp3Player_YuSeungJae.Properties.Resources._119_oksk333;
            this.bt_songdelete.Location = new System.Drawing.Point(372, 127);
            this.bt_songdelete.Name = "bt_songdelete";
            this.bt_songdelete.Size = new System.Drawing.Size(54, 52);
            this.bt_songdelete.TabIndex = 19;
            this.bt_songdelete.Text = "목록\r\n제거\r\n";
            this.bt_songdelete.UseVisualStyleBackColor = true;
            this.bt_songdelete.Click += new System.EventHandler(this.bt_songdelete_Click);
            // 
            // bt_pause
            // 
            this.bt_pause.FlatAppearance.BorderSize = 0;
            this.bt_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pause.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_pause;
            this.bt_pause.Location = new System.Drawing.Point(252, 127);
            this.bt_pause.Name = "bt_pause";
            this.bt_pause.Size = new System.Drawing.Size(54, 52);
            this.bt_pause.TabIndex = 20;
            this.bt_pause.UseVisualStyleBackColor = true;
            this.bt_pause.Click += new System.EventHandler(this.bt_pause_Click);
            // 
            // bt_repeat
            // 
            this.bt_repeat.FlatAppearance.BorderSize = 0;
            this.bt_repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_repeat.Image = global::mp3Player_YuSeungJae.Properties.Resources.크기변환_replay;
            this.bt_repeat.Location = new System.Drawing.Point(192, 127);
            this.bt_repeat.Name = "bt_repeat";
            this.bt_repeat.Size = new System.Drawing.Size(54, 52);
            this.bt_repeat.TabIndex = 21;
            this.bt_repeat.UseVisualStyleBackColor = true;
            this.bt_repeat.Click += new System.EventHandler(this.bt_repeat_Click);
            // 
            // rb_onemusicplay
            // 
            this.rb_onemusicplay.AutoSize = true;
            this.rb_onemusicplay.BackColor = System.Drawing.Color.Transparent;
            this.rb_onemusicplay.Location = new System.Drawing.Point(107, 105);
            this.rb_onemusicplay.Name = "rb_onemusicplay";
            this.rb_onemusicplay.Size = new System.Drawing.Size(71, 16);
            this.rb_onemusicplay.TabIndex = 23;
            this.rb_onemusicplay.TabStop = true;
            this.rb_onemusicplay.Text = "한곡반복";
            this.rb_onemusicplay.UseVisualStyleBackColor = false;
            this.rb_onemusicplay.CheckedChanged += new System.EventHandler(this.rb_onemusicplay_CheckedChanged);
            // 
            // rb_normalplay
            // 
            this.rb_normalplay.AutoSize = true;
            this.rb_normalplay.BackColor = System.Drawing.Color.Transparent;
            this.rb_normalplay.Location = new System.Drawing.Point(28, 105);
            this.rb_normalplay.Name = "rb_normalplay";
            this.rb_normalplay.Size = new System.Drawing.Size(71, 16);
            this.rb_normalplay.TabIndex = 24;
            this.rb_normalplay.TabStop = true;
            this.rb_normalplay.Text = "순차재생";
            this.rb_normalplay.UseVisualStyleBackColor = false;
            this.rb_normalplay.CheckedChanged += new System.EventHandler(this.rb_normalplay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "이어듣기   일시정지";
            // 
            // Form_MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mp3Player_YuSeungJae.Properties.Resources.imagesCA1YOLY5;
            this.ClientSize = new System.Drawing.Size(898, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_normalplay);
            this.Controls.Add(this.rb_onemusicplay);
            this.Controls.Add(this.bt_repeat);
            this.Controls.Add(this.bt_pause);
            this.Controls.Add(this.bt_songdelete);
            this.Controls.Add(this.bt_nextsong);
            this.Controls.Add(this.bt_beforesong);
            this.Controls.Add(this.tb_Lyric);
            this.Controls.Add(this.lv_1);
            this.Controls.Add(this.lb_SongTime);
            this.Controls.Add(this.bt_YoutubeDown);
            this.Controls.Add(this.trb_Volume);
            this.Controls.Add(this.lb_SongName);
            this.Controls.Add(this.bt_SongStop);
            this.Controls.Add(this.bt_SongPlay);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_ranking);
            this.Controls.Add(this.bt_SongAdd);
            this.MaximumSize = new System.Drawing.Size(914, 376);
            this.MinimumSize = new System.Drawing.Size(914, 376);
            this.Name = "Form_MusicPlayer";
            this.Text = "Music Player .neTers";
            ((System.ComponentModel.ISupportInitialize)(this.trb_Volume)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SongAdd;
        private System.Windows.Forms.Button bt_ranking;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.OpenFileDialog oFD_Music;
        private System.Windows.Forms.Button bt_SongPlay;
        private System.Windows.Forms.Button bt_SongStop;
        private System.Windows.Forms.Label lb_SongName;
        private System.Windows.Forms.TrackBar trb_Volume;
        private System.Windows.Forms.Button bt_YoutubeDown;
        private System.Windows.Forms.Label lb_SongTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폴더추가ToolStripMenuItem;
        private System.Windows.Forms.ListView lv_1;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader artist;
        private System.Windows.Forms.ColumnHeader album;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.Timer timercal;
        private System.Windows.Forms.ColumnHeader number;
        public System.Windows.Forms.TextBox tb_Lyric;
        private System.Windows.Forms.Button bt_beforesong;
        private System.Windows.Forms.Button bt_nextsong;
        private System.Windows.Forms.Button bt_songdelete;
        private System.Windows.Forms.Button bt_pause;
        private System.Windows.Forms.Button bt_repeat;
        private System.Windows.Forms.RadioButton rb_onemusicplay;
        private System.Windows.Forms.RadioButton rb_normalplay;
        private System.Windows.Forms.Label label1;
    }
}

