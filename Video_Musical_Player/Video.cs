using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Video_Musical_Player
{
	public partial class Video : Form
	{
		string[] f;
		public Video()
		{
			InitializeComponent();
		}

		private void listBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
		{
			WMP.URL = f[listBoxFilm.SelectedIndex];
		}
		private void btnOpen_Click(object sender, EventArgs e)
		{

			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				f = ofd.SafeFileNames;
				f = ofd.FileNames;
				for (int i = 0; i < f.Length; i++)
				{
					listBoxFilm.Items.Add(f[i]);
				}
			{
				this.panel.Text = ofd.FileName;
			}
			string file = ofd.FileName;
			WMP.URL = file;
			}
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			WMP.Ctlcontrols.play();
		}

		private void btnStop_Click_1(object sender, EventArgs e)
		{

			WMP.Ctlcontrols.stop();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			WMP.Ctlcontrols.pause();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			(listBoxFilm.SelectedIndex)--;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			(listBoxFilm.SelectedIndex)++;
		}
	}
}
