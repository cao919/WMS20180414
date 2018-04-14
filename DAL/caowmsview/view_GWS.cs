using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility; 

namespace Cao.WMS.DAL.caowmsview
{
    /// <summary>
    /// 数据访问类:view_GWS
	/// </summary>
	public partial class view_GWS
    {
        public view_GWS()
		{}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT [SGID]
      ,[SWID]
      ,[SQuantity]
      ,[STopLine]
      ,[SbaseLine]
      ,[GID]
      ,[GName]
      ,[GPrice]
      ,[GProvider]
      ,[WID]
      ,[WName]
      ,[SneedQuantity]
      ,[SEmergency]
   ");
            strSql.Append(" FROM [dbo].[view_GWS] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
