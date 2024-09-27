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
    public partial class FormHang : Form
    {
        public FormHang()
        {
            InitializeComponent();
        }

        private void rb_dauvao_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_daura_TextChanged(object sender, EventArgs e)
        {

        }

        private string ColumnarTranspositionCipher(string plainText, string key)
        {
            int[] keySequence = GetKeySequence(key);
            int numColumns = keySequence.Length;
            int numRows = (int)Math.Ceiling((double)plainText.Length / numColumns);

            // Tạo bảng chữ cái
            char[,] table = new char[numRows, numColumns];
            int index = 0;

            // Điền dữ liệu vào bảng
            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numColumns; col++)
                {
                    if (index < plainText.Length)
                    {
                        table[row, col] = plainText[index++];
                    }
                    else
                    {
                        table[row, col] = ' '; // Padding nếu cần thiết
                    }
                }
            }

            // Đọc dữ liệu theo thứ tự cột đã sắp xếp
            StringBuilder result = new StringBuilder();
            foreach (int col in keySequence)
            {
                for (int row = 0; row < numRows; row++)
                {
                    result.Append(table[row, col]);
                }
            }

            return result.ToString();
        }

        private string ColumnarTranspositionDecipher(string cipherText, string key)
        {
            int[] keySequence = GetKeySequence(key);
            int numColumns = keySequence.Length;
            int numRows = (int)Math.Ceiling((double)cipherText.Length / numColumns);

            // Xác định số ký tự trong mỗi cột
            int[] columnLengths = new int[numColumns];
            int remainder = cipherText.Length % numColumns;
            int baseLength = cipherText.Length / numColumns;

            for (int i = 0; i < numColumns; i++)
            {
                columnLengths[i] = baseLength + (i < remainder ? 1 : 0);
            }

            // Tạo bảng chữ cái để giải mã
            char[,] table = new char[numRows, numColumns];
            int index = 0;

            // Điền dữ liệu vào bảng theo số ký tự trong mỗi cột
            foreach (int col in keySequence)
            {
                for (int row = 0; row < columnLengths[col]; row++)
                {
                    if (index < cipherText.Length)
                    {
                        table[row, col] = cipherText[index++];
                    }
                }
            }

            // Khôi phục dữ liệu theo thứ tự hàng
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < numRows; row++)
            {
                foreach (int col in keySequence)
                {
                    result.Append(table[row, col]);
                }
            }

            // Loại bỏ khoảng trắng thừa
            return result.ToString().Trim();
        }

        private int[] GetKeySequence(string key)
        {
            // Phân tách các số trong khóa
            var keyNumbers = key.Split(',').Select(x => int.Parse(x.Trim())).ToArray();

            // Tạo thứ tự các cột dựa trên các số trong khóa
            return keyNumbers
                .Select((num, i) => new { Num = num, Index = i })
                .OrderBy(x => x.Num)
                .Select(x => x.Index)
                .ToArray();
        }

        private bool IsValidKey(string key)
        {
            // Kiểm tra tính hợp lệ của khóa
            return !string.IsNullOrWhiteSpace(key) &&
                   key.Split(',').All(part =>
                   {
                       int result;
                       return int.TryParse(part.Trim(), out result);
                   });
        }
    

    private void btn_Mahoa_Click(object sender, EventArgs e)
        {
            string key = txt_khoa.Text;
            string plainText = rb_dauvao.Text;

            // Kiểm tra tính hợp lệ của khóa
            if (!IsValidKey(key))
            {
                MessageBox.Show("Khóa không hợp lệ. Vui lòng nhập khóa dạng số nguyên phân cách bởi dấu ',' (ví dụ: 3,6,2,1,5,4).");
                return;
            }

            // Mã hóa
            string cipherText = ColumnarTranspositionCipher(plainText, key);
            rb_daura.Text = cipherText;
        }

        private void btn_giaima_Click(object sender, EventArgs e)
        {
            string key = txt_khoa.Text;
            string cipherText = rb_dauvao.Text;

            // Kiểm tra tính hợp lệ của khóa
            if (!IsValidKey(key))
            {
                MessageBox.Show("Khóa không hợp lệ. Vui lòng nhập khóa dạng số nguyên phân cách bởi dấu ',' (ví dụ: 3,6,2,1,5,4).");
                return;
            }

            // Giải mã và chỉ hiển thị kết quả ra txt4
            string plainText = ColumnarTranspositionDecipher(cipherText, key);
            rb_daura.Text = plainText;
        }
    }
}
