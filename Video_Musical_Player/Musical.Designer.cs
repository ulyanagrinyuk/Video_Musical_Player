namespace Video_Musical_Player
{
	partial class Musical
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musical));
			this.ListBoxSongs = new System.Windows.Forms.ListBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// ListBoxSongs
			// 
			this.ListBoxSongs.FormattingEnabled = true;
			this.ListBoxSongs.Location = new System.Drawing.Point(616, 0);
			this.ListBoxSongs.Name = "ListBoxSongs";
			this.ListBoxSongs.Size = new System.Drawing.Size(183, 355);
			this.ListBoxSongs.TabIndex = 1;
			this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(650, 372);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(116, 48);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "SelectSongs";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// MediaPlayer
			// 
			this.MediaPlayer.Enabled = true;
			this.MediaPlayer.Location = new System.Drawing.Point(0, 0);
			this.MediaPlayer.Name = "MediaPlayer";
			this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
			this.MediaPlayer.Size = new System.Drawing.Size(610, 404);
			this.MediaPlayer.TabIndex = 4;
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(308, 372);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(82, 32);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnPause
			// 
			this.btnPause.Location = new System.Drawing.Point(0, 372);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(108, 32);
			this.btnPause.TabIndex = 6;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(408, 372);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(87, 32);
			this.btnBack.TabIndex = 7;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(515, 372);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(85, 32);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(210, 372);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(79, 32);
			this.btnPlay.TabIndex = 9;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			// 
			// Musical
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.MediaPlayer);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.ListBoxSongs);
			this.Name = "Musical";
			this.Text = "Musical";
			((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ListBox ListBoxSongs;
		private System.Windows.Forms.Button btnSelect;
		private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPlay;
	}
}