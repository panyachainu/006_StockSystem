using System.Collections.Generic;
using System;
using System.Text;
using System.Windows.Forms;

namespace StockSystem
{
    class password
    {

        public static string Encrypt(string inputText)
        {
            try
            {
                byte[] bytesToEncode = Encoding.UTF8.GetBytes(inputText);
                return Convert.ToBase64String(bytesToEncode);
            }
            catch
            {
                return "";
            }
        }

        public static string Decrypt(string encodedText)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(encodedText);
                return Encoding.UTF8.GetString(decodedBytes);
            }
            catch
            {
                return "";
            }
        }
    }
}
