namespace mp3Player_YuSeungJae
{
    partial class Form_Youtube
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_Youtube = new System.Windows.Forms.TextBox();
            this.bt_convert = new System.Windows.Forms.Button();
            this.bt_download = new System.Windows.Forms.Button();
            this.timer_countdown = new System.Windows.Forms.Timer(this.components);
            this.lb_counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 95);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(600, 20);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tb_Youtube
            // 
            this.tb_Youtube.Location = new System.Drawing.Point(9, 12);
            this.tb_Youtube.Name = "tb_Youtube";
            this.tb_Youtube.Size = new System.Drawing.Size(510, 21);
            this.tb_Youtube.TabIndex = 1;
            // 
            // bt_convert
            // 
            this.bt_convert.Location = new System.Drawing.Point(548, 10);
            this.bt_convert.Name = "bt_convert";
            this.bt_convert.Size = new System.Drawing.Size(41, 23);
            this.bt_convert.TabIndex = 2;
            this.bt_convert.Text = "변환";
            this.bt_convert.UseVisualStyleBackColor = true;
            this.bt_convert.Click += new System.EventHandler(this.bt_convert_Click);
            // 
            // bt_download
            // 
            this.bt_download.Location = new System.Drawing.Point(595, 10);
            this.bt_download.Name = "bt_download";
            this.bt_download.Size = new System.Drawing.Size(37, 23);
            this.bt_download.TabIndex = 3;
            this.bt_download.Text = "다운";
            this.bt_download.UseVisualStyleBackColor = true;
            this.bt_download.Click += new System.EventHandler(this.bt_convert2_Click);
            // 
            // timer_countdown
            // 
            this.timer_countdown.Tick += new System.EventHandler(this.timer_countdown_Tick);
            // 
            // lb_counter
            // 
            this.lb_counter.AutoSize = true;
            this.lb_counter.BackColor = System.Drawing.Color.Transparent;
            this.lb_counter.Location = new System.Drawing.Point(525, 21);
            this.lb_counter.Name = "lb_counter";
            this.lb_counter.Size = new System.Drawing.Size(0, 12);
            this.lb_counter.TabIndex = 4;
            // 
            // Form_Youtube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mp3Player_YuSeungJae.Properties.Resources.ED959CECA7802;
            this.ClientSize = new System.Drawing.Size(644, 40);
            this.Controls.Add(this.lb_counter);
            this.Controls.Add(this.bt_download);
            this.Controls.Add(this.bt_convert);
            this.Controls.Add(this.tb_Youtube);
            this.Controls.Add(this.webBrowser1);
            this.MaximumSize = new System.Drawing.Size(660, 79);
            this.MinimumSize = new System.Drawing.Size(660, 79);
            this.Name = "Form_Youtube";
            this.Text = "유튜브 다운로더";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_Youtube;
        private System.Windows.Forms.Button bt_convert;
        private System.Windows.Forms.Button bt_download;
        private System.Windows.Forms.Timer timer_countdown;
        private System.Windows.Forms.Label lb_counter;

    }
}