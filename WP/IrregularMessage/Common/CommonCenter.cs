using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace IrregularMessage.Common
{
    public class CommonCenter
    {
        public const string PhoneCommonFolder = @"PhoneCommon";
        public const string DBName = @"db.sqlite3";
        public string DBPath
        {
            get { return Path.Combine(ApplicationData.Current.LocalFolder.Path, PhoneCommonFolder, DBName); }
        }
        

        public static bool FileExists(string filePath)
        {
            var result = false;
            try
            {
                if (IsolatedStorageFile.GetUserStoreForApplication().FileExists(filePath))
                    result = true;
            }
            catch
            {
            }
            return result;
        }

        public static IsolatedStorageFile CurrentStorageFile()
        {
            return IsolatedStorageFile.GetUserStoreForApplication();
        }
    }
}
