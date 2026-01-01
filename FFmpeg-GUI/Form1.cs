using System.Diagnostics;
using System.ComponentModel;
using System.Drawing.Text;

namespace FFmpeg_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonin_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxin.Text = ofd.FileName;
            }
        }

        private void buttonout_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MP4ファイル (*.mp4)|*.mp4|すべてのファイル (*.*)|*.*";
            sfd.DefaultExt = "mp4";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                textBoxout.Text = sfd.FileName;
            }

        }

        private void textBoxout_TextChanged(object sender, EventArgs e)
        {

        }

        private void convbtn_Click(object sender, EventArgs e)
        {
            string input = textBoxin.Text;
            string output = textBoxout.Text;

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("未選択事項があります。");
                return;
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "ffmpeg"; // PATH通ってる前提
                psi.Arguments = $"-y -i \"{input}\" \"{output}\"";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = false;

                Process.Start(psi);
            }
            catch (Win32Exception)
            {
                MessageBox.Show(
                    "FFmpegがインストールされていないか、PATHが通っていないため\n" +
                    "ファイル変換を実行できませんでした。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}