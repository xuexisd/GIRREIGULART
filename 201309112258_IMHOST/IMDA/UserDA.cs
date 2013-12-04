using IMCOMMON;
using IMCONTRACT;
using IMMODEL;
using Sunny.DataManipulation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDA
{
    public class UserDA : IUser
    {
        public List<UserModel> GetUser()
        {
            #region only to test
            //string errorMsg = "";
            //List<UserModel> listModel = new List<UserModel>();
            //try
            //{
            //    SqlHelper helper = new SqlHelper();
            //    DataSet ds = new DataSet();
            //    ds.Tables.Add("GetUser");
            //    helper.FillDataset("P_USER_S", ds.Tables["GetUser"]);
            //    for (int i = 0; i < ds.Tables["GetUser"].Rows.Count; i++)
            //    {
            //        listModel.Add(new UserModel()
            //        {
            //            USER_ID = Guid.Parse(ds.Tables["GetUser"].Rows[i]["USER_ID"].ToString()),
            //            USER_PHONE = ds.Tables["GetUser"].Rows[i]["USER_PHONE"].ToString(),
            //            USER_KEY = ds.Tables["GetUser"].Rows[i]["USER_KEY"].ToString(),
            //            USER_EMAIL = ds.Tables["GetUser"].Rows[i]["USER_EMAIL"].ToString(),
            //            USER_PWD = ds.Tables["GetUser"].Rows[i]["USER_PWD"].ToString(),
            //            USER_DEVICE_ID = ds.Tables["GetUser"].Rows[i]["USER_DEVICE_ID"].ToString(),
            //            USER_DEVICE_NAME = ds.Tables["GetUser"].Rows[i]["USER_DEVICE_NAME"].ToString(),
            //            UPDATE_VERSION = int.Parse(ds.Tables["GetUser"].Rows[i]["UPDATE_VERSION"].ToString()),
            //            CREATED_BY = ds.Tables["GetUser"].Rows[i]["CREATED_BY"].ToString(),
            //            CREATED_TIME = ds.Tables["GetUser"].Rows[i]["CREATED_TIME"].ToString(),
            //            LAST_UPDATED_BY = ds.Tables["GetUser"].Rows[i]["LAST_UPDATED_BY"].ToString(),
            //            LAST_UPDATED_TIME = ds.Tables["GetUser"].Rows[i]["LAST_UPDATED_TIME"].ToString()
            //        });
            //    }
            //}
            //catch (Exception ex)
            //{
            //    CommonHelper.LogException(new List<string>() { "[Date]--->" + DateTime.Now, "[Message]--->" + ex.Message, "[StackTrace]--->" + ex.StackTrace, CommonHelper.LogLine });
            //    listModel.Add(new UserModel() { ERROR_MSG = ex.Message });
            //}
            //return listModel;
            #endregion
            return null;
        }

        public UserModel GetUserByCriteriaKeyByUserPWD(string CriteriaKey, string UserPWD)
        {
            UserModel model = new UserModel();
            try
            {
                SqlHelper helper = new SqlHelper();
                DataSet ds = new DataSet();
                ds.Tables.Add("GetUserByCriteriaKeyByUserPWD");
                helper.FillDataset("P_USER_S_LOGIN", ds.Tables["GetUserByCriteriaKeyByUserPWD"], CriteriaKey, UserPWD);
                if (ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows.Count == 1 && ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_ID"] != null)
                {
                    model.USER_ID = int.Parse(ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_ID"].ToString());
                    model.USER_PWD = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_PWD"].ToString();
                    model.USER_PHONE_NUMBER = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_PHONE_NUMBER"].ToString();
                    model.USER_NAME = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_NAME"].ToString();
                    model.USER_EMAIL = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_EMAIL"].ToString();
                    model.USER_GENDER = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_GENDER"].ToString();
                    model.USER_HEADER_IMG = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_HEADER_IMG"].ToString();
                    model.USER_AREA = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_AREA"].ToString();
                    model.USER_SIGNATURE = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_SIGNATURE"].ToString();
                    model.USER_DEVICE_ID = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_DEVICE_ID"].ToString();
                    model.USER_DEVICE_NAME = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["USER_DEVICE_NAME"].ToString();
                    model.UPDATE_VERSION = int.Parse(ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["UPDATE_VERSION"].ToString());
                    model.CREATED_BY = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["CREATED_BY"].ToString();
                    model.CREATED_TIME = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["CREATED_TIME"].ToString();
                    model.LAST_UPDATED_BY = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["LAST_UPDATED_BY"].ToString();
                    model.LAST_UPDATED_TIME = ds.Tables["GetUserByCriteriaKeyByUserPWD"].Rows[0]["LAST_UPDATED_TIME"].ToString();
                }
                else
                    model = null;
            }
            catch (Exception ex)
            {
                CommonHelper.LogException(new List<string>() { "[Date]--->" + DateTime.Now, "[Message]--->" + ex.Message, "[StackTrace]--->" + ex.StackTrace, CommonHelper.LogLine });
                model.ERROR_MSG = ex.Message;
            }
            return model;
        }

        public UserModel GetServerDateTime()
        {
            return (new UserModel() { CREATED_TIME = DateTime.Now.ToString() });
        }

        public UserModel RegisterUser(UserModel user)
        {
            UserModel model = new UserModel();
            try
            {
                SqlHelper helper = new SqlHelper();
                helper.ExecuteNonQuery("P_USER_I", user.USER_PWD, user.USER_PHONE_NUMBER.Trim(), user.USER_NAME.Trim(), user.USER_EMAIL.Trim(), user.USER_GENDER.Trim(), user.USER_DEVICE_ID.Trim(), user.USER_DEVICE_NAME.Trim());
                DataSet ds = new DataSet();
                ds.Tables.Add("RegisterUser");
                string CriteriaKey = string.IsNullOrEmpty(user.USER_PHONE_NUMBER.Trim()) ? user.USER_EMAIL.Trim() : user.USER_PHONE_NUMBER;
                helper.FillDataset("P_USER_S_LOGIN", ds.Tables["RegisterUser"], CriteriaKey, user.USER_PWD);
                if (ds.Tables["RegisterUser"].Rows.Count == 1 && ds.Tables["RegisterUser"].Rows[0]["USER_ID"] != null)
                {
                    model.USER_ID = int.Parse(ds.Tables["RegisterUser"].Rows[0]["USER_ID"].ToString());
                    model.USER_PWD = ds.Tables["RegisterUser"].Rows[0]["USER_PWD"].ToString();
                    model.USER_PHONE_NUMBER = ds.Tables["RegisterUser"].Rows[0]["USER_PHONE_NUMBER"].ToString();
                    model.USER_NAME = ds.Tables["RegisterUser"].Rows[0]["USER_NAME"].ToString();
                    model.USER_EMAIL = ds.Tables["RegisterUser"].Rows[0]["USER_EMAIL"].ToString();
                    model.USER_GENDER = ds.Tables["RegisterUser"].Rows[0]["USER_GENDER"].ToString();
                    model.USER_HEADER_IMG = ds.Tables["RegisterUser"].Rows[0]["USER_HEADER_IMG"].ToString();
                    model.USER_AREA = ds.Tables["RegisterUser"].Rows[0]["USER_AREA"].ToString();
                    model.USER_SIGNATURE = ds.Tables["RegisterUser"].Rows[0]["USER_SIGNATURE"].ToString();
                    model.USER_DEVICE_ID = ds.Tables["RegisterUser"].Rows[0]["USER_DEVICE_ID"].ToString();
                    model.USER_DEVICE_NAME = ds.Tables["RegisterUser"].Rows[0]["USER_DEVICE_NAME"].ToString();
                    model.UPDATE_VERSION = int.Parse(ds.Tables["RegisterUser"].Rows[0]["UPDATE_VERSION"].ToString());
                    model.CREATED_BY = ds.Tables["RegisterUser"].Rows[0]["CREATED_BY"].ToString();
                    model.CREATED_TIME = ds.Tables["RegisterUser"].Rows[0]["CREATED_TIME"].ToString();
                    model.LAST_UPDATED_BY = ds.Tables["RegisterUser"].Rows[0]["LAST_UPDATED_BY"].ToString();
                    model.LAST_UPDATED_TIME = ds.Tables["RegisterUser"].Rows[0]["LAST_UPDATED_TIME"].ToString();
                }
                else
                    model = null;
            }
            catch (Exception ex)
            {
                CommonHelper.LogException(new List<string>() { "[Date]--->" + DateTime.Now, "[Message]--->" + ex.Message, "[StackTrace]--->" + ex.StackTrace, CommonHelper.LogLine });
                model.ERROR_MSG = ex.Message;
            }
            return model;
        }

        public string CheckUserExist(string CriteriaKey, string CheckFiled)
        {
            string retString = string.Empty;
            try
            {
                SqlHelper helper = new SqlHelper();
                retString = helper.ExecuteReader("P_USER_S_CHECK_EXIST", CriteriaKey, CheckFiled).GetString(0);
            }
            catch (Exception ex)
            {
                retString = ex.Message;
            }
            return retString;
        }
    }
}
