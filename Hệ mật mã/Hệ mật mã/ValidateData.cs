using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hệ_mật_mã
{
    static class ValidateData
    {
        public static bool KiemTraKhoa(string vanBan)
        {
            if (string.IsNullOrEmpty(vanBan))
            {
                MessageBox.Show("Khóa không được rỗng");
                return false;
            }
            if (vanBan.Distinct().Count() != vanBan.Length)
            {
                MessageBox.Show("Khóa không được chứa ký tự giống nhau");
                return false;
            }
            if (vanBan.Length != 26)
            {
                MessageBox.Show("Khóa phải đầy đủ 26 chữ cái");
                return false;
            }
            if (Regex.IsMatch(vanBan, @"\d"))
            {
                MessageBox.Show("Khóa rõ không được chứa số");
                return false;
            }
            return true;
        }
        public static bool KiemTraBanRo(string vanBan)
        {
            if (string.IsNullOrEmpty(vanBan))
            {
                MessageBox.Show("Khóa không được rỗng");
                return false;
            }
            if (Regex.IsMatch(vanBan, @"\d"))
            {
                MessageBox.Show("Khóa rõ không được chứa số");
                return false;
            }
            return true;
        }

        public static bool KiemTraPlainText(string vanBan)
        {
            if (string.IsNullOrEmpty(vanBan))
            {
                MessageBox.Show("Không được rỗng");
                return false;
            }
            if (Regex.IsMatch(vanBan, @"\d"))
            {
                MessageBox.Show("Không được chứa số");
                return false;
            }
            return true;
        }
        public static bool KiemTraKeyWord(string vanBan)
        {
            if (string.IsNullOrEmpty(vanBan))
            {
                MessageBox.Show("KeyWord không được rỗng");
                return false;
            }
            if (Regex.IsMatch(vanBan, @"\d"))
            {
                MessageBox.Show("KeyWord không được chứa số");
                return false;
            }
            if (vanBan.Distinct().Count() != vanBan.Length)
            {
                MessageBox.Show("Khóa không được chứa ký tự giống nhau");
                return false;
            }
            return true;
        }
    }
}
