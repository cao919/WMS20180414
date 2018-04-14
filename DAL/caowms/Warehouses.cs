using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Cao.WMS.DAL.caowms
{
	/// <summary>
	/// 数据访问类:Warehouses
	/// </summary>
	public partial class Warehouses
	{
		public Warehouses()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("WID", "Warehouses"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string WID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Warehouses");
			strSql.Append(" where WID=@WID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = WID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录[WName]
        /// </summary>
        public bool ExistsWName(string WName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Warehouses");
            strSql.Append(" where WName=@WName ");
            SqlParameter[] parameters = {
					new SqlParameter("@WName", SqlDbType.NVarChar,50)			};
            parameters[0].Value = WName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Cao.WMS.Model.caowms.Warehouses model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Warehouses(");
            strSql.Append("WID,WName,WArea,WAddress,WDescribe)");
			strSql.Append(" values (");
            strSql.Append("@WID,@WName,@WArea,@WAddress,@WDescribe)");
			SqlParameter[] parameters = {
					new SqlParameter("@WID", SqlDbType.NVarChar,50), 
					new SqlParameter("@WName", SqlDbType.NVarChar,50),
					new SqlParameter("@WArea", SqlDbType.Float,8),
					new SqlParameter("@WAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@WDescribe", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.WID; 
			parameters[1].Value = model.WName;
			parameters[2].Value = model.WArea;
			parameters[3].Value = model.WAddress;
			parameters[4].Value = model.WDescribe;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Cao.WMS.Model.caowms.Warehouses model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update Warehouses set ");
			strSql.Append("WName=@WName,");
			strSql.Append("WArea=@WArea,");
			strSql.Append("WAddress=@WAddress,");
			strSql.Append("WDescribe=@WDescribe");
			strSql.Append(" where WID=@WID ");
            SqlParameter[] parameters = { 
					new SqlParameter("@WName", SqlDbType.NVarChar,50),
					new SqlParameter("@WArea", SqlDbType.Float,8),
					new SqlParameter("@WAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@WDescribe", SqlDbType.NVarChar,500),
					new SqlParameter("@WID", SqlDbType.NVarChar,50)};
        
			parameters[0].Value = model.WName;
			parameters[1].Value = model.WArea;
			parameters[2].Value = model.WAddress;
			parameters[3].Value = model.WDescribe;
			parameters[4].Value = model.WID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string WID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Warehouses ");
			strSql.Append(" where WID=@WID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = WID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string WIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Warehouses ");
			strSql.Append(" where WID in ("+WIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
        /// 得到一个对象实体WCode
		/// </summary>
        public Cao.WMS.Model.caowms.Warehouses GetModel(string WID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 WID,WName,WArea,WAddress,WDescribe from Warehouses ");
            strSql.Append(" where WID=@WID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WID", SqlDbType.NVarChar,50)			};
            parameters[0].Value = WID;

			Cao.WMS.Model.caowms.Warehouses model=new Cao.WMS.Model.caowms.Warehouses();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Cao.WMS.Model.caowms.Warehouses DataRowToModel(DataRow row)
		{
			Cao.WMS.Model.caowms.Warehouses model=new Cao.WMS.Model.caowms.Warehouses();
			if (row != null)
			{
                if (row["WID"] != null && row["WID"].ToString() != "")
                {
                    model.WID = row["WID"].ToString();
                }
               
				if(row["WName"]!=null)
				{
					model.WName=row["WName"].ToString();
				}
				if(row["WArea"]!=null && row["WArea"].ToString()!="")
				{
					model.WArea=decimal.Parse(row["WArea"].ToString());
				}
				if(row["WAddress"]!=null)
				{
					model.WAddress=row["WAddress"].ToString();
				}
				if(row["WDescribe"]!=null)
				{
					model.WDescribe=row["WDescribe"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select WID,WName,WArea,WAddress,WDescribe ");
			strSql.Append(" FROM Warehouses ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
            strSql.Append(" WID,WName,WArea,WAddress,WDescribe ");
			strSql.Append(" FROM Warehouses ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Warehouses ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.WID desc");
			}
			strSql.Append(")AS Row, T.*  from Warehouses T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Warehouses";
			parameters[1].Value = "WID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

