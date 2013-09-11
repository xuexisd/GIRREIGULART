using IMCOMMON;
using IMCONTRACT;
using IMMODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDA
{
    public class UserDA : IUser
    {
        public string Test(string inputString)
        {
            UserModel model = new UserModel();
            try
            {
                model.TestValue = "Hello: " + inputString + "  --->[" + DateTime.Now.ToString() + "]";
            }
            catch (Exception ex)
            {
                CommonHelper.LogException(new List<string>() { "[Date]--->" + DateTime.Now, "[Message]--->" + ex.Message, "[StackTrace]--->" + ex.StackTrace, CommonHelper.LogLine });
            }
            return model.TestValue;
        }
    }
}
