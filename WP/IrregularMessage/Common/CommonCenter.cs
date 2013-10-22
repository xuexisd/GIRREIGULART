using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using IrregularMessage.Model;

namespace IrregularMessage.Common
{
    public class CommonCenter
    {
        public const string PhoneCommonFolder = @"PhoneCommon";
        public const string DBName = @"db.sqlite3";
        public const string GlobalDateTimeFormat = @"yyyy-MM-dd HH:mm:ss";

        public const string Table_T_USER_LOGIN = @"T_USER_LOGIN";

        public static string DBPath
        {
            get { return Path.Combine(ApplicationData.Current.LocalFolder.Path, PhoneCommonFolder, DBName); }
        }
        public static List<string> CurrentRootFolders;
        public static List<string> PhoneCommonFiles;
        public static LoginUserInfoModel LoginUserInformationModel;

        public static void GetCurrentRootFolders(bool needRefresh)
        {
            if (CurrentRootFolders == null || needRefresh)
            {
                CurrentRootFolders = new List<string>();
                IReadOnlyList<StorageFolder> list = ApplicationData.Current.LocalFolder.GetFoldersAsync().AsTask().GetAwaiter().GetResult();
                foreach (StorageFolder item in list)
                {
                    CurrentRootFolders.Add(item.Name);
                }
            }
        }

        public static void GetPhoneCommonFiles(bool needRefresh)
        {
            if (PhoneCommonFiles == null || needRefresh)
            {
                PhoneCommonFiles = new List<string>();
                IReadOnlyList<StorageFile> list = ApplicationData.Current.LocalFolder.GetFolderAsync(PhoneCommonFolder).AsTask().GetAwaiter().GetResult().GetFilesAsync().AsTask().GetAwaiter().GetResult();
                foreach (StorageFile item in list)
                {
                    PhoneCommonFiles.Add(item.Name);
                }
            }
        }
    }
}
