using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder retstring, int Returnlenth, IntPtr callback);

        public Form1()
        {
            InitializeComponent();
            mciSendString("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        SoundPlayer ExamplePlayer = new System.Media.SoundPlayer();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File|*.wav";
            if (open.ShowDialog() != DialogResult.OK) return;
            
            waveViewer1.SamplesPerPixel = 400;
            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(open.FileName);

            label1.Text = open.FileName;
            ExamplePlayer.SoundLocation = label1.Text;
			
        }

		private void button1_Click(object sender, EventArgs e)
		{
            
            {
                
                ExamplePlayer.SoundLocation = label1.Text;
                ExamplePlayer.PlayLooping();
            }

        }

		private void button2_Click(object sender, EventArgs e)
		{
            mciSendString("save recsound C:\\Users\\User\\Downloads\\Demo\\WinFormsApp1\\WinFormsApp1\\recordedsounds\\sound1.wav", null, 0, IntPtr.Zero);
            mciSendString("close recsound ", null, 0, IntPtr.Zero);

            ExamplePlayer.SoundLocation = label1.Text;
            ExamplePlayer.Stop();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            mciSendString("record recsound", null, 0, IntPtr.Zero);
            button2.Click += new EventHandler(this.button2_Click);

		}

		
	}
}
