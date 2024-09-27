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
    public partial class FormVigenere : Form
    {
        public FormVigenere()
        {
            InitializeComponent();
        }

        private void FormVigenere_Load(object sender, EventArgs e)
        {

        }
        //Ham ma hoa vigenere 
        private string VigenereEncrypt(string text, String key)
        {
            String result = "";
            key = key.ToUpper();
            int keyIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                //Neu char la chu cai tien hanh ma hoa

                if (char.IsLetter(c))
                {
                    bool isUpperCase = char.IsUpper(c);   // xác định thường với in hoa
                    char offset = isUpperCase ? 'A' : 'a';  // Xác định offset cho in hoa hay chữ thường
                    char keyChar = key[keyIndex % key.Length]; // lấy key tương ứng với số thứ tự của keyIndex như ko vượt qua key.Length 

                    // Mã hóa ký tự
                    // y = x + K 
                    // y = y mod 26 
                    // y = y + offset (để quyết định là thường hay in hoa)
                    result += (char)((((c - offset) + (keyChar - 'A')) % 26) + offset);
                    keyIndex++;
                }
                else
                {
                    result += c; // Giữ nguyên ký tự nếu không phải là chữ cái
                }
            }

            return result;
        }

        // Hàm giải mã Vigenère
        private string VigenereDecrypt(string text, string key)
        {
            string result = "";
            key = key.ToUpper();
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                // Nếu là chữ cái, tiến hành giải mã
                if (char.IsLetter(c))
                {
                    bool isUpperCase = char.IsUpper(c);    // xác định thường với in hoa
                    char offset = isUpperCase ? 'A' : 'a';  // Xác định offset cho in hoa hay chữ thường
                    char keyChar = key[keyIndex % key.Length]; // lấy key tương ứng với số thứ tự của keyIndex như ko vượt qua key.Length 

                    // Giải mã ký tự
                    // x = y - K 
                    // x = x mod 26
                    // x = x + offset (để quyết định là thường hay in hoa)
                    result += (char)((((c - offset) - (keyChar - 'A') + 26) % 26) + offset);
                    keyIndex++;
                }
                else
                {
                    result += c; // Giữ nguyên ký tự nếu không phải là chữ cái
                }
            }

            return result;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txtPlainText.Text;
            string key = txtKey.Text;

            if (!string.IsNullOrEmpty(plainText) && !string.IsNullOrEmpty(key))
            {
                txtResult.Text = VigenereEncrypt(plainText, key);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập văn bản và khóa để mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtPlainText.Text;
            string key = txtKey.Text;

            if (!string.IsNullOrEmpty(cipherText) && !string.IsNullOrEmpty(key))
            {
                txtResult.Text = VigenereDecrypt(cipherText, key);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập văn bản và khóa để giải mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openedFilePath = openFileDialog.FileName;
                txtPlainText.Text = File.ReadAllText(openedFilePath);
                MessageBox.Show("File đã được mở thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtResult.Text);
                    MessageBox.Show("File đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có nội dung để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlainText.Text = "";
            txtKey.Text = "";
            txtResult.Text = "";
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dl = new FontDialog();
            dl.ShowColor = true;
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txtPlainText.Font = dl.Font;
                txtResult.Font = dl.Font;
                txtKey.ForeColor = dl.Color;
               txtResult.ForeColor = dl.Color;
                txtKey.ForeColor = dl.Color;
                txtKey.Font = dl.Font;
            }
        }
    }
}

