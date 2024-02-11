using System.Text;

namespace XGame.Domain.Extensions
{
    public static class StringExtensions
    {
        public static string ConvertToMD5 (this string passWord)
        {
            if (string.IsNullOrEmpty(passWord)) return "";

            var password = (passWord += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create ();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            
            foreach ( var c in data ) 
            { 
                sbString.Append(c.ToString("x2"));
            }

            return sbString.ToString();
        }
    }
}
