// Fenix Hash Checker 0.4
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Media;

namespace fenixhashchecker
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        public string get_md5(string ruta)
        {
            string md5 = "";
            var md5test = MD5.Create();
            var valtest = File.OpenRead(ruta);
            md5 = BitConverter.ToString(md5test.ComputeHash(valtest)).Replace("-", "").ToLower();
            return md5;
        }

        private void btnLoadFile1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.click);
            sound1.Play();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult archivo = openFileDialog1.ShowDialog();
            if (archivo == DialogResult.OK)
            {
                txtFilename1.Text = openFileDialog1.FileName;
            }
        }

        private void btnLoadFile2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.click);
            sound1.Play();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            DialogResult archivo = openFileDialog1.ShowDialog();
            if (archivo == DialogResult.OK)
            {
                txtFilename2.Text = openFileDialog1.FileName;
            }
        }

        private void btnCopyHash1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.click);
            sound1.Play();

            if (File.Exists(txtFilename1.Text))
            {
                Clipboard.Clear();
                Clipboard.SetText(get_md5(txtFilename1.Text));
            }
            else
            {
                if (txtFilename1.Text != "")
                {
                    Clipboard.Clear();
                    Clipboard.SetText(txtFilename1.Text);
                }
            }
        }

        private void btnCopyHash2_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.click);
            sound1.Play();

            if (File.Exists(txtFilename2.Text))
            {
                Clipboard.Clear();
                Clipboard.SetText(get_md5(txtFilename2.Text));
            }
            else
            {
                if (txtFilename2.Text != "")
                {
                    Clipboard.Clear();
                    Clipboard.SetText(txtFilename2.Text);
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.scanfin);
            sound1.Play();

            string md5_1 = "";
            string md5_2 = "";

            if (cmbType1.Text == "Hash")
            {
                md5_1 = txtFilename1.Text;
            }
            else
            {
                if (File.Exists(txtFilename1.Text))
                {
                    md5_1 = get_md5(txtFilename1.Text);
                }
                else
                {
                    MessageBox.Show("Select first file");
                    md5_1 = "";
                }
            }

            if (cmbType2.Text == "Hash")
            {
                md5_2 = txtFilename2.Text;
            }
            else
            {
                if (File.Exists(txtFilename2.Text))
                {
                    md5_2 = get_md5(txtFilename2.Text);
                }
                else
                {
                    MessageBox.Show("Select second file");
                    md5_2 = "";
                }
            }

            if (md5_1 != "" || md5_2 != "")
            {
                if (md5_1 == md5_2)
                {
                    MessageBox.Show("Are the same");
                    toolStripStatusLabel1.Text = "[+] Are the same";
                    this.Refresh();
                }
                else
                {
                    MessageBox.Show("They are not equal");
                    toolStripStatusLabel1.Text = "[-] They are not equal";
                    this.Refresh();
                }

                txtFilename1.Text = md5_1;
                txtFilename2.Text = md5_2;
            }
        }

        private void txtFilename1_DragDrop(object sender, DragEventArgs e)
        {
            if (cmbType1.Text == "File")
            {
                List<string> archivos = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                txtFilename1.Lines = archivos.ToArray();
            }
        }

        private void txtFilename1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtFilename2_DragDrop(object sender, DragEventArgs e)
        {
            if (cmbType2.Text == "File")
            {
                List<string> archivos = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
                txtFilename2.Lines = archivos.ToArray();
            }
        }

        private void txtFilename2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void cmbType1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbType1.Text != "Hash")
            {
                txtFilename1.Text = "";
                txtFilename1.ReadOnly = true;
            }
            else
            {
                txtFilename1.Text = "";
                txtFilename1.ReadOnly = false;
            }
        }

        private void cmbType2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbType2.Text != "Hash")
            {
                txtFilename2.Text = "";
                txtFilename2.ReadOnly = true;
            }
            else
            {
                txtFilename2.Text = "";
                txtFilename2.ReadOnly = false;
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(fenixhashchecker.Properties.Resources.formcreate);
            sound1.Play();
        }

    }
}
