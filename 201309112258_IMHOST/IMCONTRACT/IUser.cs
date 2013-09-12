using IMMODEL;
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
        [OperationContract]
        [WebGet(UriTemplate = "User/GetUser", BodyStyle = WebMessageBodyStyle.Bare
            , ResponseFormat = WebMessageFormat.Json)]
        List<UserModel> GetUser();

        //[OperationContract]
        //[WebInvoke(UriTemplate = "User/RegisterUser", Method = "POST"
        //   , BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //UserModel RegisterUser(UserModel user);
    }
}
