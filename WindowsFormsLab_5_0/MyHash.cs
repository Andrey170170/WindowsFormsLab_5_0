using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsLab_5_0
{
    public static class MyHash
    {
        public static string GetHashString(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            var CSP = new MD5CryptoServiceProvider();
            var byteHash = CSP.ComputeHash(bytes);
            return byteHash.Aggregate("", (current, b) => current + $"{b:x2}");
        }
    }
}