using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RestSharp;
using IrregularMessage.Common;

namespace IrregularMessage
{
    public partial class LoginPage : PhoneApplicationPage
    {
        public LoginPage()
        {
            InitializeComponent();

            RestClient client = new RestClient(CommonCenter.BaseUrlUser);
            RestRequest request = new RestRequest(@"/user/getuserbycriteriakeybyuserpwd?criteriakey={criteriakey}&userpwd={userpwd}", Method.GET);
            request.AddUrlSegment("criteriakey", "18888888888");
            request.AddUrlSegment("userpwd", "123456");
            
            client.ExecuteAsync(request
                , (a) =>
                {
                    MessageBox.Show(a.Content);
                    MessageBox.Show("test");
                });
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //移除程序初始化的判断页 MainPage.xaml
            if (this.NavigationService.CanGoBack)
                this.NavigationService.RemoveBackEntry();
        }
    }
}