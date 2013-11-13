using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.Common.Security;

namespace IMCOMMON
{
    public class CommonHelper
    {
        public const string LogLine = @"========================================================================";
        public static void LogException(List<string> exceptionContent)
        {
            string filePath = ConfigurationManager.AppSettings["IMHostPath"].ToString();
            string fileName = "Log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string fullFilePath = filePath + fileName;
            if (!File.Exists(fullFilePath))
            {
                File.Create(fullFilePath).Close();
            }
            File.AppendAllLines(fullFilePath, exceptionContent, UTF8Encoding.UTF8);
        }

        public static string EncryptString_Aes(string plainText)
        {
            return SymmetricMethod.EncryptString_Aes(plainText, ConfigurationManager.AppSettings["SunnySecurityA1"].ToString(), ConfigurationManager.AppSettings["SunnySecurityA2"].ToString());
        }

        public static string DecryptString_Aes(string cipherText)
        {
            return SymmetricMethod.DecryptString_Aes(cipherText, ConfigurationManager.AppSettings["SunnySecurityA1"].ToString(), ConfigurationManager.AppSettings["SunnySecurityA2"].ToString());
        }
    }
}
