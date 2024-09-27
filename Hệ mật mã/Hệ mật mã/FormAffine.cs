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
    public partial class FormAffine : Form
    {
        public FormAffine()
        {
            InitializeComponent();
        }

        private void btn_Mahoa_Click(object sender, EventArgs e)
        {
            string input = rb_dauvao.Text;
            if (int.TryParse(txt_khoaA.Text, out int a) && int.TryParse(txt_khoaB.Text, out int b))
            {
                if (IsValidInput(input, a, b))
                {
                    string encrypted = Encrypt(input, a, b);
                    rb_daura.Text = encrypted;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng!");
                }
            }
        }

        private void btn_giaima_Click(object sender, EventArgs e)
        {
            string input = rb_dauvao.Text;
            int a, b;


            while (!int.TryParse(txt_khoaA.Text, out a) || !HasModInverse(a, 26)) //Check snd 
            {
                MessageBox.Show("Khóa a không có nghịch đảo. Vui lòng nhập lại.");
                txt_khoaA.Clear();
                txt_khoaA.Focus();
                return;
            }

            if (int.TryParse(txt_khoaB.Text, out b))
            {
                string encrypted = Encrypt(input, a, b);
                rb_daura.Text = encrypted;

                int aInverse = ModInverse(a, 26);
                txt_snd.Text = aInverse.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập khóa b hợp lệ!");
            }
        }

        private bool HasModInverse(int a, int m)
        {
            return ModInverse(a, m) != 0;
        }

        private bool IsValidInput(string input, int a, int b)
        {
            return a > 0 && a < 26 && b >= 0 && b < 26 && input.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private string Encrypt(string input, int a, int b)
        {
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int x = char.ToUpper(c) - 'A';
                    int encryptedChar = (a * x + b) % 26;
                    result += (char)(encryptedChar + 'A');
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        private string Decrypt(string input, int a, int b)
        {
            int aInverse = ModInverse(a, 26);
            string result = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int y = char.ToUpper(c) - 'A';
                    int decryptedChar = (aInverse * (y - b + 26)) % 26;
                    result += (char)(decryptedChar + 'A');
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        private int ModInverse(int a, int m)
        {
            a = a % m;
            for (int x = 1; x < m; x++)
                if ((a * x) % m == 1)
                    return x;
            return 0;
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

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_dauvao.Clear();
            rb_daura.Clear();
            txt_khoaA.Clear();
            txt_khoaA.Text = "";
            txt_khoaB.Clear();
            txt_khoaB.Text = "";
            rb_dauvao.Text = "";
            rb_daura.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dl = new FontDialog();
            dl.ShowColor = true;
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                rb_daura.Font = dl.Font;
                rb_dauvao.Font = dl.Font;
                rb_daura.ForeColor = dl.Color;
                rb_dauvao.ForeColor = dl.Color;
            }
        }
    }
}
    

