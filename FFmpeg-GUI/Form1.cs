using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

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
            sfd.Filter =
                "----------動画----------|*.*|" +
                "MP4|*.mp4|" +
                "MKV|*.mkv|" +
                "WebM|*.webm|" +
                "AVI|*.avi|" +
                "MOV|*.mov|" +
                "WMV|*.wmv|" +
                "FLV|*.flv|" +

                "----------音声----------|*.*|" +

                "MP3|*.mp3|" +
                "AAC|*.aac|" +
                "M4A|*.m4a|" +
                "WAV|*.wav|" +
                "FLAC|*.flac|" +
                "AIFF|*.aiff|" +
                "OGG Vorbis|*.ogg|" +
                "Opus|*.opus|" +

                "----------画像----------|*.*|" +

                "PNG|*.png|" +
                "JPEG|*.jpg|" +
                "JPEG XL|*.jxl|" +
                "GIF|*.gif|" +
                "BMP|*.bmp|" +
                "ICO|*.ico|" +
                "WebP|*.webp|" +
                "TIFF|*.tif;*.tiff|" +
                "AVIF|*.avif|" +
                "HEIF|*.heic;*.heif|" +

                "その他|*.*";

            sfd.FilterIndex = 2;
            sfd.AddExtension = true;

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
            string ex_option = textBoxopt.Text;

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("未選択事項があります。");
                return;
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "ffmpeg"; // PATH通ってる前提
                psi.Arguments = $"-y -i \"{input}\" {ex_option} \"{output}\"";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                psi.RedirectStandardError = true;
                psi.RedirectStandardOutput = true;

                psi.StandardErrorEncoding = System.Text.Encoding.UTF8;
                psi.StandardOutputEncoding = System.Text.Encoding.UTF8;

                Process proc = new Process();
                proc.StartInfo = psi;
                proc.Start();

                string error = proc.StandardError.ReadToEnd();
                proc.WaitForExit();

                // ダイアログ表示
                if (proc.ExitCode != 0)
                {
                    MessageBox.Show(
                        "FFmpegでエラーが発生しました。\n\n" + error,
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    MessageBox.Show(
                        "ファイル変換が完了しました。",
                        "完了",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            link.LinkVisited = true;  // リンクを押された色にする
            ProcessStartInfo pi = new ProcessStartInfo()
            {
                FileName = "https://github.com/yanagi-lpc",
                UseShellExecute = true, // 重要
            };
            Process.Start(pi);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}