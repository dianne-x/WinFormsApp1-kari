using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "music.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("Christmas_Christmas_tree_Balls_Snow_599743_600x400.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("christmas-images.jpg");
        }
    }
}