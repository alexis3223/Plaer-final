namespace Plaer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPrevious = new Button();
            btnPlay = new Button();
            btnPause = new Button();
            btnNext = new Button();
            lstSongs = new ListBox();
            btnSelectFolder = new Button();
            Timer1 = new System.Windows.Forms.Timer(components);
            lblElapsedTime = new Label();
            trackBar = new TrackBar();
            lstFolder = new ListBox();
            label1 = new Label();
            label2 = new Label();
            trackBarVolume = new TrackBar();
            lstPlaylist = new ListBox();
            label3 = new Label();
            btnAdd = new Button();
            btnDel = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            SuspendLayout();
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.Location = new Point(16, 251);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(41, 37);
            btnPrevious.TabIndex = 0;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += button1_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Image = (Image)resources.GetObject("btnPlay.Image");
            btnPlay.ImageAlign = ContentAlignment.BottomCenter;
            btnPlay.Location = new Point(66, 251);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(33, 37);
            btnPlay.TabIndex = 1;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.White;
            btnPause.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Image = (Image)resources.GetObject("btnPause.Image");
            btnPause.Location = new Point(105, 251);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(33, 37);
            btnPause.TabIndex = 2;
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.Location = new Point(144, 251);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(41, 37);
            btnNext.TabIndex = 3;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lstSongs
            // 
            lstSongs.FormattingEnabled = true;
            lstSongs.ItemHeight = 15;
            lstSongs.Location = new Point(12, 25);
            lstSongs.Name = "lstSongs";
            lstSongs.Size = new Size(350, 214);
            lstSongs.TabIndex = 4;
            lstSongs.SelectedIndexChanged += lstSongs_SelectedIndexChanged;
            lstSongs.DoubleClick += lstSongs_DoubleClick;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.BackColor = Color.White;
            btnSelectFolder.FlatStyle = FlatStyle.Flat;
            btnSelectFolder.Image = (Image)resources.GetObject("btnSelectFolder.Image");
            btnSelectFolder.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectFolder.Location = new Point(191, 251);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(124, 37);
            btnSelectFolder.TabIndex = 5;
            btnSelectFolder.Text = "Выбор папки";
            btnSelectFolder.TextAlign = ContentAlignment.MiddleRight;
            btnSelectFolder.UseVisualStyleBackColor = false;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // Timer1
            // 
            Timer1.Tick += timer1_Tick;
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Location = new Point(3, 307);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(38, 15);
            lblElapsedTime.TabIndex = 6;
            lblElapsedTime.Text = "label1";
            // 
            // trackBar
            // 
            trackBar.BackColor = SystemColors.ControlLightLight;
            trackBar.Location = new Point(48, 307);
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(266, 45);
            trackBar.TabIndex = 7;
            trackBar.TickStyle = TickStyle.None;
            trackBar.Scroll += trackBar1_Scroll;
            // 
            // lstFolder
            // 
            lstFolder.FormattingEnabled = true;
            lstFolder.ItemHeight = 15;
            lstFolder.Location = new Point(369, 25);
            lstFolder.Name = "lstFolder";
            lstFolder.Size = new Size(203, 109);
            lstFolder.TabIndex = 8;
            lstFolder.SelectedIndexChanged += lstFolder_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 9;
            label1.Text = "Список песен:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(369, 7);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 10;
            label2.Text = "Список папок:";
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(318, 251);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Orientation = Orientation.Vertical;
            trackBarVolume.Size = new Size(45, 101);
            trackBarVolume.TabIndex = 11;
            trackBarVolume.TickStyle = TickStyle.Both;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // lstPlaylist
            // 
            lstPlaylist.FormattingEnabled = true;
            lstPlaylist.ItemHeight = 15;
            lstPlaylist.Location = new Point(369, 251);
            lstPlaylist.Name = "lstPlaylist";
            lstPlaylist.Size = new Size(203, 229);
            lstPlaylist.TabIndex = 12;
            lstPlaylist.DoubleClick += lstPlaylist_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(369, 146);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 13;
            label3.Text = "Плейлист:";
            // 
            // btnAdd
            // 
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(368, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Добавить в плейлист";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(368, 193);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(146, 23);
            btnDel.TabIndex = 15;
            btnDel.Text = "Удалить из плейлиста";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(368, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(146, 23);
            btnClear.TabIndex = 16;
            btnClear.Text = "Очистить плейлист";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(577, 538);
            Controls.Add(btnClear);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lstPlaylist);
            Controls.Add(trackBarVolume);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstFolder);
            Controls.Add(trackBar);
            Controls.Add(lblElapsedTime);
            Controls.Add(btnSelectFolder);
            Controls.Add(lstSongs);
            Controls.Add(btnNext);
            Controls.Add(btnPause);
            Controls.Add(btnPlay);
            Controls.Add(btnPrevious);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Plaer";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrevious;
        private Button btnPlay;
        private Button btnPause;
        private Button btnNext;
        private ListBox lstSongs;
        private Button btnSelectFolder;
        private System.Windows.Forms.Timer Timer1;
        private Label lblElapsedTime;
        private TrackBar trackBar;
        private ListBox lstFolder;
        private Label label1;
        private Label label2;
        private TrackBar trackBarVolume;
        private ListBox lstPlaylist;
        private Label label3;
        private Button btnAdd;
        private Button btnDel;
        private Button btnClear;
    }
}