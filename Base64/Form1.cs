using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64
{
    public partial class Form1 : Form
    {
        string RealPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            encResTextBox.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(encTextBox.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                decResTextBox.Text = Encoding.UTF8.GetString(Convert.FromBase64String(decTextBox.Text));
            }
            catch
            {
                decResTextBox.Text = "Invalid base64 string";
            }
        }

        private void encFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the file to encode to Base64 format";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                encode(ofd.FileName);
            }
        }

        private void decFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the file to decode from Base64 format";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                decode(ofd.FileName);
            }
        }

        private void encFileBtn_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                encode(file);
            }
        }

        private void encFileBtn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void decFileBtn_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                decode(file);
            }
        }

        private void decFileBtn_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void decode(string path)
        {
            try
            {
                byte[] b = Convert.FromBase64String(File.ReadAllText(path));
                File.WriteAllBytes(Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + " decoded" + Path.GetExtension(path), b);
                MessageBox.Show("Decode successful!", "Base64", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Base64", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void encode(string path)
        {
            try
            {
                File.WriteAllText(Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + " encoded.txt", Convert.ToBase64String(File.ReadAllBytes(path)));
                MessageBox.Show("Encode successful!", "Base64", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Base64", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
