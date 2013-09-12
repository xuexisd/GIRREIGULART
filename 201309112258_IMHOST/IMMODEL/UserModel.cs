using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMMODEL
{
    public class UserModel : BaseModel
    {
        public Guid USER_ID { get; set; }
        public string USER_PHONE { get; set; }
        public string USER_KEY { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_PWD { get; set; }
        public string USER_DEVICE { get; set; }
    }
}
