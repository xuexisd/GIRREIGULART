using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMMODEL
{
    public class UserModel : BaseModel
    {
        public int USER_ID { get; set; }
        public string USER_PWD { get; set; }
        public string USER_PHONE_NUMBER { get; set; }
        public string USER_NAME { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_GENDER { get; set; }
        public string USER_HEADER_IMG { get; set; }
        public string USER_AREA { get; set; }
        public string USER_SIGNATURE { get; set; }
        public string USER_DEVICE_ID { get; set; }
        public string USER_DEVICE_NAME { get; set; }
    }
}
