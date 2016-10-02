using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GetSHA1
    {
        public static string Codify(string str)
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
