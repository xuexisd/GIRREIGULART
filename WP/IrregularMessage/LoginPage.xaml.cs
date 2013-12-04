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
using Microsoft.Phone.Info;
using System.Text.RegularExpressions;

namespace IrregularMessage
{
    public partial class LoginPage : PhoneApplicationPage
    {
        public LoginPage()
        {
            InitializeComponent();

            //RestClient client = new RestClient(CommonCenter.BaseUrlUser);
            //RestRequest request = new RestRequest(@"/user/getuserbycriteriakeybyuserpwd?criteriakey={criteriakey}&userpwd={userpwd}", Method.GET);
            //request.AddUrlSegment("criteriakey", "18888888888");
            //request.AddUrlSegment("userpwd", "123456");
            
            //client.ExecuteAsync(request
            //    , (a) =>
            //    {
            //        MessageBox.Show(a.Content);
            //        MessageBox.Show("test");
            //    });
            txtRegisterUserDeviceId.Text = DeviceStatus.DeviceManufacturer + "|" + DeviceStatus.DeviceName;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //移除程序初始化的判断页 MainPage.xaml
            if (this.NavigationService.CanGoBack)
                this.NavigationService.RemoveBackEntry();
        }

        private void btnLoginOrRegister_Click(object sender, EventArgs e)
        {
            //0: 登陆
            //1: 注册
            switch (pivotLoginOrRegister.SelectedIndex.ToString())
            {
                case "0":
                    if (string.IsNullOrEmpty(txtLoginCriteria.Text.Trim())
                        || string.IsNullOrEmpty(txtLoginPWD.Password.Trim()))
                        return;
                    MessageBox.Show("登陆");
                    break;
                case "1":




                    //Regex rPhoneNumber = new Regex(@"d{15}");
                    //Regex rEmail = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    //if (!rPhoneNumber.IsMatch(txtRegisterPhoneNumOrEmail.Text.Trim()))
                    //{
                    //    MessageBox.Show("请输入正确的手机号");
                    //    return;
                    //}
                    //if (!rEmail.IsMatch(txtRegisterPhoneNumOrEmail.Text.Trim()))
                    //{
                    //    MessageBox.Show("请输入正确的Email");
                    //    return;
                    //}







                    if (string.IsNullOrEmpty(txtRegisterEmail.Text.Trim())
                        || string.IsNullOrEmpty(txtRegisterPWD.Password.Trim())
                        || string.IsNullOrEmpty(txtRegisterConfirmPWD.Password.Trim())
                        //|| string.IsNullOrEmpty(txtRegisterUserEmail.Text.Trim())
                        || string.IsNullOrEmpty(txtRegisterUserDeviceId.Text.Trim()))
                        return;
                    if (txtRegisterPWD.Password.Equals(txtRegisterConfirmPWD.Password))
                    {
                        MessageBox.Show(txtRegisterEmail.Text);
                    }
                    else
                    {
                        MessageBox.Show(@"密码两次输入不相同，请重新输入");
                    }
                    break;
                default:
                    MessageBox.Show(@"亲，出现未知错误了哦");
                    break;
            }
        }

        private void pivotLoginOrRegister_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplicationBarIconButton btnLOR = (ApplicationBarIconButton)ApplicationBar.Buttons[0];
            if (pivotLoginOrRegister.SelectedIndex == 0)
                btnLOR.Text = @"登陆";
            else
                btnLOR.Text = @"注册";
        }
    }
}