namespace Video_Musical_Player
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnVideo = new System.Windows.Forms.Button();
			this.btnMusical = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnVideo
			// 
			this.btnVideo.BackColor = System.Drawing.Color.SlateBlue;
			this.btnVideo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnVideo.Location = new System.Drawing.Point(0, 391);
			this.btnVideo.Name = "btnVideo";
			this.btnVideo.Size = new System.Drawing.Size(800, 59);
			this.btnVideo.TabIndex = 0;
			this.btnVideo.Text = "Watch Video";
			this.btnVideo.UseVisualStyleBackColor = false;
			this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
			// 
			// btnMusical
			// 
			this.btnMusical.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnMusical.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnMusical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMusical.ForeColor = System.Drawing.SystemColors.Control;
			this.btnMusical.Location = new System.Drawing.Point(0, 337);
			this.btnMusical.Name = "btnMusical";
			this.btnMusical.Size = new System.Drawing.Size(800, 54);
			this.btnMusical.TabIndex = 1;
			this.btnMusical.Text = "Listen Musical";
			this.btnMusical.UseVisualStyleBackColor = false;
			this.btnMusical.Click += new System.EventHandler(this.btnMusical_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 337);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnMusical);
			this.Controls.Add(this.btnVideo);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnVideo;
		private System.Windows.Forms.Button btnMusical;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

