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

namespace Windows_GiuaKy_Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listDanhSach.ValueMember = "Path";
            listDanhSach.DisplayMember = "FileName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFille file = listDanhSach.SelectedItem as MediaFille;
            if(file != null)
            {
                axWindowsMediaPlayer1.URL = file.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String filter = "All|*.*|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv";
            using(OpenFileDialog ofd = new OpenFileDialog { Multiselect = true,ValidateNames = true,Filter=filter})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFille> files = new List<MediaFille>();
                    foreach (String filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(filename);
                        files.Add(new MediaFille() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName});
                    }
                    listDanhSach.DataSource = files;
                    listDanhSach.ValueMember = "Path";
                    listDanhSach.DisplayMember = "FileName";
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (e.newState)
            {
                case 1:
                    MessageBox.Show("Stoped");
                    break;
                default:
                    break;
            }

        }
    }
}
