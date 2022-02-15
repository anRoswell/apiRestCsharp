using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Core.Tools
{
    public class Funciones
    {
        public static string GetCodigoUnico(string CodigoID)
        {
            string CodigoUnico = DateTime.Now.ToString("yyyyMMddHHmmss_fff") + "_" + CodigoID + "_" + Path.GetRandomFileName().PadLeft(11).Replace('.', '_');
            return CodigoUnico;
        }

        public static string GetSHA256(string cadena)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(cadena));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
