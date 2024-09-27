using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hệ_mật_mã
{
    public partial class FormCaesar : Form
    {
        public FormCaesar()
        {
            InitializeComponent();


        }

        private string MaHoaCaesar(string input, int shift)
        {
            char[] buffer = input.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char d = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)(((letter + shift - d) % 26) + d);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        private string GiaiMaCaesar(string input, int shift)
        {
            return MaHoaCaesar(input, 26 - shift);
        }


        private void btn_Mahoa_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_khoa.Text, out int shift))
            {
                rb_daura.Text = MaHoaCaesar(rb_dauvao.Text, shift);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên cho khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void btn_giaima_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_khoa.Text, out int shift))
            {
                rb_daura.Text = GiaiMaCaesar(rb_dauvao.Text, shift);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên cho khóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "Text files (*.txt)|*.txt";
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                StreamReader f = new StreamReader(dl.FileName);
                rb_dauvao.Text = f.ReadToEnd();
                f.Close();
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dl = new SaveFileDialog();
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                StreamWriter f = new StreamWriter(dl.FileName);
                f.Write(rb_daura.Text);
                f.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_dauvao.Clear();
            rb_daura.Clear();
            txt_khoa.Clear();
            txt_khoa.Text = "";
            rb_dauvao.Text = "";
            rb_daura.Text = "";
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dl= new FontDialog();
            dl.ShowColor = true;
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                rb_daura .Font = dl.Font;
                rb_dauvao.Font = dl.Font;
                rb_daura.ForeColor = dl.Color;
                rb_dauvao .ForeColor = dl.Color;
            }
        }
    }
}
