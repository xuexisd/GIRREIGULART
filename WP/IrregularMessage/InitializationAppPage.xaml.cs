using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SQLite;
using IrregularMessage.Common;
using IrregularMessage.Model;
using RestSharp;

namespace IrregularMessage
{
    public partial class InitializationAppPage : PhoneApplicationPage
    {
        public InitializationAppPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            using (var db = new SQLiteConnection(CommonCenter.DBPath))
            {
                LoginUserInfoModel userModel = db.Query<LoginUserInfoModel>(string.Format("SELECT * FROM {0}", CommonCenter.Table_T_USER_LOGIN)).FirstOrDefault();

                //string temp = "";
                //RestClient client = new RestClient(CommonCenter.BaseUrlUser);
                //RestRequest request = new RestRequest(@"user/getuserbycriteriakeybyuserpwd?criteriakey=18888888888&userpwd=123456", Method.GET);
                //request.AddUrlSegment("criteriakey", "18888888888");
                //request.AddUrlSegment("userpwd", "123456");

                //client.ExecuteAsync(request
                //    , (a) =>
                //    {
                //        temp = a.Content;
                //    });

                if (userModel != null)
                {
                    CommonCenter.LoginUserInformationModel = userModel;
                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }
                else
                {
                    //db.RunInTransaction(() =>
                    //    {
                    //        db.Insert(new LoginUserInfoModel()
                    //        {
                    //            USER_ID = Guid.NewGuid().ToString(),
                    //            USER_PHONE_NUMBER = "",
                    //            USER_KEY = "xsd",
                    //            USER_EMAIL = "",
                    //            USER_PWD = "123456",
                    //            USER_DEVICE_ID = DeviceStatus.DeviceName,
                    //            USER_DEVICE_NAME = "",
                    //            USER_LOGIN_DATE = DateTime.Now.ToString(CommonCenter.GlobalDateTimeFormat)
                    //        });
                    //    });
                    //txtTest.Text = "insert success!";
                    NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
                }
            }
        }
    }
}