using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace IMCONTRACT
{
    [ServiceContract]
    public interface IUser
    {
        //[OperationContract]
        //[WebGet(UriTemplate = "User/GetUserDetail?userName={userName}&userPWD={userPWD}", BodyStyle = WebMessageBodyStyle.Bare
        //    , ResponseFormat = WebMessageFormat.Json)]
        //UserModel GetUserDetail(string userName, string userPWD);

        //[OperationContract]
        //[WebInvoke(UriTemplate = "User/RegisterUser", Method = "POST"
        //   , BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //UserModel RegisterUser(UserModel user);

        [OperationContract]
        [WebGet(UriTemplate = "User/Test?inputString={inputString}", BodyStyle = WebMessageBodyStyle.Bare
            , ResponseFormat = WebMessageFormat.Json)]
        string Test(string inputString);
    }
}
