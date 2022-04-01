using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class User
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int SecretQuestionId { get; set; }
        public string SecretQuestionAnswer { get; set; }

        public static string PasswordTosha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        public static bool CorrectPasswordFormat(string password)
        {
            if (password.Length < 8) return false;

            int Upper = 0, Lower = 0, Digit = 0, Special = 0;
            foreach(char p in password)
            {
                if (Char.IsUpper(p)) Upper += 1;
                if (Char.IsLower(p)) Lower += 1;
                if (Char.IsDigit(p)) Digit += 1;
                //special
                String regExp = "^[^<>{}\"/|;:.,~!?@#$%^=&*\\]\\\\()\\[¿§«»ω⊙¤°℃℉€¥£¢¡®©_+]*$";
                Regex rgx = new Regex(regExp);
                if (!rgx.IsMatch(p.ToString())) Special += 1;
            }
            if (Upper >= 1 && Lower >= 1 && Digit >= 1 && Special >= 1) return true;
            return false;
                
        }
    }
}
