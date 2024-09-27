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
    public partial class FormThaythe : Form
    {
        Dictionary<int, char> bangChuCai = new Dictionary<int, char>();
        string khoa = null;
        string banRo = null;
        public FormThaythe()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void LuuKhoaVaoBangChuCai()
        {
            //Lưu khóa vào 1 cấu trúc dữ liệu theo số thự tự mã ACSII
            bangChuCai.Clear();
            int vitri = 0;
            for (int i = 65; i < txtKhoa.Text.Length + 65; i++)
            {
                bangChuCai.Add(i, txtKhoa.Text[vitri]);
                vitri++;
            }
        }

        public string DocFile()
        {
            //Đọc File
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            string selectedFilePath = openFileDialog.FileName;
            if (String.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Vui lòng chọn file để mã hóa hoặc giả mã");
            }
            else
            {
                string fileContent = File.ReadAllText(selectedFilePath);
                return fileContent;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mã hóa
            banRo = txt_BanRo.Text.ToUpper();
            khoa = txtKhoa.Text.ToUpper();
            LuuKhoaVaoBangChuCai();
            if (ValidateData.KiemTraBanRo(banRo) && ValidateData.KiemTraKhoa(khoa))
            {
                char[] ketQuaMaHoa = banRo.ToCharArray();
                for (int i = 0; i < banRo.Length; i++)
                {
                    int value = (int)ketQuaMaHoa[i];
                    ketQuaMaHoa[i] = bangChuCai[value];
                }
                rtbKetQua.Text = new string(ketQuaMaHoa);
            }
        }

        private void btDocFileKhoa_Click(object sender, EventArgs e)
        {
            txtKhoa.Text = DocFile();
        }

        private void btDocFileBanRo_Click(object sender, EventArgs e)
        {
            txt_BanRo.Text = DocFile();
        }


    }
}
