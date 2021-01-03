using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;
using System.Management;

namespace StockSystem
{
    public static class UtilitySecurity
    {
        static readonly string PasswordHash = "P@l0y&L@y";//"P@@Sw0rd";
        static readonly string SaltKey = "L0v&F0r&VER";//"S@LT&KEY";
        static readonly string VIKey = "@p2A4n9Y9a0C3h5a";//"@1B2c3D4e5F6g7H8";

        public static string _NameSerialNumber { get { return "_SerailNumber"; } }
        public static string _NameActivateCode { get { return "_ActivateCode"; } }

        ///-------------- Encrypt&Decrypt&MD5
        public static bool VerifyRegister(string ActivateCode, string SerailRegis)
        {
            string tempSerailRegis = Encrypt(SerailRegis);
            string tempMD5SerailRegis = GetMd5Sum(tempSerailRegis);
            if (string.Equals(tempMD5SerailRegis, ActivateCode))
                return true;
            else
                return false;
        }

        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }

        public static string GetMd5Sum(string str)
        {
            // First we need to convert the string into bytes, which
            // means using a text encoder.
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

            // Create a buffer large enough to hold the string
            byte[] unicodeText = new byte[str.Length * 2];
            enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);

            // Now that we have a byte array we can ask the CSP to hash it
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            // Build the final string by converting each byte
            // into hex and appending it to a StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }

            // And return it
            return sb.ToString();
        }
        ///-------------------------------------------------------

        ///------------ GenSerial
        public static string SerailMachineAndVersion()
        {
            string drive = "C";
            //if (drive == string.Empty)
            //{
            //    //Find first drive
            //    foreach (DriveInfo compDrive in DriveInfo.GetDrives())
            //    {
            //        if (compDrive.IsReady)
            //        {
            //            drive = compDrive.RootDirectory.ToString();
            //            break;
            //        }
            //    }
            //}

            //if (drive.EndsWith(":\\"))
            //{
            //    //C:\ -> C
            //    drive = drive.Substring(0, drive.Length - 2);
            //}

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();


            //Mix them up and remove some useless 0's
            string Key1 = cpuID.Substring(13);
            string Key2 = volumeSerial;
            string Key3 = cpuID.Substring(4, 4);
            string key4 = cpuID.Substring(1, 4);
            string Key5 = Utility.lps_id.Trim();

            string Mixs = string.Format("{0}{1}{2}{3}{4}", Key1, Key2, Key3, key4, Key5);// cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);

            return Mixs;
        }

        public static string SerailMachine(string drive)
        {
            //if (drive == string.Empty)
            //{
            //    //Find first drive
            //    foreach (DriveInfo compDrive in DriveInfo.GetDrives())
            //    {
            //        if (compDrive.IsReady)
            //        {
            //            drive = compDrive.RootDirectory.ToString();
            //            break;
            //        }
            //    }
            //}

            //if (drive.EndsWith(":\\"))
            //{
            //    //C:\ -> C
            //    drive = drive.Substring(0, drive.Length - 2);
            //}

            string volumeSerial = getVolumeSerial(drive);
            string cpuID = getCPUID();


            //Mix them up and remove some useless 0's
            string Key1 = cpuID.Substring(13);
            string Key2 = volumeSerial;
            string Key3 = cpuID.Substring(4, 4);
            string key4 = cpuID.Substring(1, 4);

            string Mixs = string.Format("{0}{1}{2}{3}", Key1, Key2, Key3, key4);// cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);

            return Mixs;
        }

        private static string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }

        private static string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }
        ///-----------------------------------
    }

}


