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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnVideo_Click(object sender, EventArgs e)
		{
			Video video = new Video();
			video.Show();
		}

		private void btnMusical_Click(object sender, EventArgs e)
		{
			Musical musical = new Musical();
			musical.Show();
		}
	}
}
