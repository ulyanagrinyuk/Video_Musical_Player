using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Musical_Player
{
	public partial class Musical : Form
	{
		string[] files, paths;
		public Musical()
		{
			InitializeComponent();
		}

		private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
		{
			MediaPlayer.URL = paths[ListBoxSongs.SelectedIndex];
		}
		private void btnPlay_Click_1(object sender, EventArgs e)
		{
			MediaPlayer.Ctlcontrols.play();
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			MediaPlayer.Ctlcontrols.stop();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			MediaPlayer.Ctlcontrols.pause();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			(ListBoxSongs.SelectedIndex)++;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			(ListBoxSongs.SelectedIndex)--;
		}
				

		private void btnSelect_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				files = ofd.SafeFileNames;
				paths = ofd.FileNames;
				for (int i = 0; i < files.Length; i++)
				{
					ListBoxSongs.Items.Add(files[i]);
				}				
			}

		}
	}
}
