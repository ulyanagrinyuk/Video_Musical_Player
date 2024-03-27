namespace Video_Musical_Player
{
	partial class Video
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.listBoxFilm = new System.Windows.Forms.ListBox();
			this.panel = new System.Windows.Forms.Panel();
			this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.BackColor = System.Drawing.Color.Yellow;
			this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOpen.Location = new System.Drawing.Point(633, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(126, 54);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "FileOpen";
			this.btnOpen.UseVisualStyleBackColor = false;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.Chartreuse;
			this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlay.Location = new System.Drawing.Point(240, 322);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(85, 33);
			this.btnPlay.TabIndex = 4;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Crimson;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnStop.Location = new System.Drawing.Point(380, 322);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(87, 33);
			this.btnStop.TabIndex = 6;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.PaleVioletRed;
			this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPause.Location = new System.Drawing.Point(2, 322);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(105, 33);
			this.btnPause.TabIndex = 7;
			this.btnPause.Text = "Pause";
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBack.Location = new System.Drawing.Point(519, 322);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(95, 33);
			this.btnBack.TabIndex = 8;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.DarkMagenta;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNext.Location = new System.Drawing.Point(670, 322);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(91, 33);
			this.btnNext.TabIndex = 9;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// listBoxFilm
			// 
			this.listBoxFilm.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.listBoxFilm.FormattingEnabled = true;
			this.listBoxFilm.Location = new System.Drawing.Point(0, 3);
			this.listBoxFilm.Name = "listBoxFilm";
			this.listBoxFilm.Size = new System.Drawing.Size(772, 82);
			this.listBoxFilm.TabIndex = 10;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.btnOpen);
			this.panel.Controls.Add(this.listBoxFilm);
			this.panel.Location = new System.Drawing.Point(2, 361);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(775, 85);
			this.panel.TabIndex = 2;
			// 
			// WMP
			// 
			this.WMP.Enabled = true;
			this.WMP.Location = new System.Drawing.Point(2, 2);
			this.WMP.Name = "WMP";
			this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
			this.WMP.Size = new System.Drawing.Size(772, 353);
			this.WMP.TabIndex = 0;
			// 
			// Video
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(777, 450);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.WMP);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Video";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Video";
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer WMP;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.ListBox listBoxFilm;
		private System.Windows.Forms.Panel panel;
	}
}