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
    }
}
