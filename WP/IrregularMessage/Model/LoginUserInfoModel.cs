using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrregularMessage.Model
{
    [SQLite.Table("T_USER_LOGIN")]
    public class LoginUserInfoModel
    {
        [SQLite.PrimaryKey, SQLite.MaxLength(50)]
        public string USER_ID { get; set; }

        [SQLite.MaxLength(20)]
        public string USER_PHONE { get; set; }

        [SQLite.MaxLength(50)]
        public string USER_KEY { get; set; }

        [SQLite.MaxLength(50)]
        public string USER_EMAIL { get; set; }

        [SQLite.MaxLength(500)]
        public string USER_PWD { get; set; }

        [SQLite.MaxLength(100)]
        public string USER_DEVICE_ID { get; set; }

        [SQLite.MaxLength(100)]
        public string USER_DEVICE_NAME { get; set; }

        [SQLite.MaxLength(50)]
        public string USER_LOGIN_DATE { get; set; }
    }
}
