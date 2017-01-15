using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary
{
    public class GetSHA1
    {
        // change method name before: Codify
        public static string Encrypt(string str)
        {

            SHA1 sha1 = SHA1Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1.ComputeHash(encoding.GetBytes(str));
            for (int x = 0; x < stream.Length; x++)
                sb.AppendFormat("{0:x2}", stream[x]);
            return sb.ToString();
        }
    }
}
