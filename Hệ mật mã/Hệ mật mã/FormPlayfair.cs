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
    public partial class FormPlayfair : Form
    {

        string ketqua = null;
        Dictionary<char, int> maTran = new Dictionary<char, int>();
        Dictionary<int, char> anhXaMaTran = new Dictionary<int, char>();
        List<char> list = new List<char>();
        public void CungHangDoc(int value1, int value2)
        {
            int chenhlech1 = 10;
            int chenhlech2 = 10;

            if (value1 >= 50)
                chenhlech1 = -40;
            if (value2 >= 50)
                chenhlech2 = -40;
            ketqua += anhXaMaTran[value1 + chenhlech1].ToString() + anhXaMaTran[value2 + chenhlech2].ToString();
        }

        public void CungHangNgang(int value1, int value2)
        {
            int chenhlech1 = 1;
            int chenhlech2 = 1;
            if (value1 % 5 == 0)
                chenhlech1 = -4;
            if (value2 % 5 == 0)
                chenhlech2 = -4;
            ketqua += anhXaMaTran[value1 + chenhlech1].ToString() + anhXaMaTran[value2 + chenhlech2].ToString();
        }

        public void THConLai(int value1, int value2)
        {
            int maxValue = Math.Max(value1, value2);
            int cot1 = (value1 - 1) % 5 - 1;
            int cot2 = (value2 - 1) % 5 - 1;
            int dochenhlech = Math.Abs(cot1 - cot2);

            if (value1 % 10 < value2 % 10)
                ketqua += anhXaMaTran[value1 + dochenhlech].ToString()
                       + anhXaMaTran[value2 - dochenhlech].ToString();
            else
                ketqua += anhXaMaTran[value1 - dochenhlech].ToString()
                       + anhXaMaTran[value2 + dochenhlech].ToString();
        }

        public FormPlayfair()
        {
            InitializeComponent();
        }
        public void xulychuoi(char x, char y)
        {
            int value1 = maTran[x];
            int value2 = maTran[y];
            int dochenhlech = Math.Abs(value1 - value2);
            int a, b;

            // cung hang doc
            if (dochenhlech % 10 == 0)
                CungHangDoc(value1, value2);

            //cung hang ngang
            else if ((value1 / 10) - (value2 / 10) == 0)
                CungHangNgang(value1, value2);

            //th con lai
            else
                THConLai(value1, value2);
        }
        public void KhoiDongLaiDuLieu()
        {
            txtPlainText.Text = txtPlainText.Text.ToUpper();
            txtPlainText.Text = txtPlainText.Text.Replace(" ", "");

            txtKeyWord.Text = txtKeyWord.Text.ToUpper();
            txtKeyWord.Text = txtKeyWord.Text.Replace(" ", "");

            ketqua = string.Empty;
            tblpBangChuCai.Controls.Clear();
            rtbPlayFair.Text = string.Empty;
            maTran.Clear();
            anhXaMaTran.Clear();
        }
        public void MaHoa()
        {
            KhoiDongLaiDuLieu();
            if (txtPlainText.Text.Length % 2 != 0)
            {
                txtPlainText.Text += 'X';
            }
            //Lưu bảng chữ cái theo keyword vào mảng 1 chiều
            foreach (char c in txtKeyWord.Text.ToUpper().ToCharArray())
            {
                list.Add(c);
            }

            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (!list.Any(x => x == i) && i != 'J')
                {
                    list.Add(i);
                }
            }

            // Lưu vào mảng ma trận 5x5
            int vitri = 0;

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6; j++)
                {
                    maTran.Add(list[vitri], int.Parse(i + "" + j));
                    anhXaMaTran.Add(int.Parse(i + "" + j), list[vitri]);
                    HienThiMaTran(list[vitri].ToString(), j - 1, i - 1);
                    vitri++;
                }
            }


            string chuoi = txtPlainText.Text;
            // xu ly ky tu
            for (int i = 0; i < chuoi.Length - 1; i += 2)
            {
                xulychuoi(chuoi[i], chuoi[i + 1]);
            }
            rtbPlayFair.Text = ketqua;

        }
        private void FormPlayfair_Load(object sender, EventArgs e)
        {

        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            if (ValidateData.KiemTraPlainText(txtPlainText.Text) && ValidateData.KiemTraKeyWord(txtKeyWord.Text))
                MaHoa();
        }
        public void HienThiMaTran(string content, int cot, int hang)
        {
            Label label = new Label();
            label.Text = content;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BorderStyle = BorderStyle.FixedSingle;

            tblpBangChuCai.Controls.Add(label, cot, hang);
        }
    }
}
