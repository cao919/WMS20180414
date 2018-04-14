using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Cao.WMS.DAL.caowms
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string UID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where UID=@UID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = UID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Cao.WMS.Model.caowms.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("UID,UPassword,UPower,USex,UName,UAddress,UTel,UEmail,UDep)");
			strSql.Append(" values (");
			strSql.Append("@UID,@UPassword,@UPower,@USex,@UName,@UAddress,@UTel,@UEmail,@UDep)");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.NVarChar,50),
					new SqlParameter("@UPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@UPower", SqlDbType.NVarChar,50),
					new SqlParameter("@USex", SqlDbType.Char,2),
					new SqlParameter("@UName", SqlDbType.NVarChar,50),
					new SqlParameter("@UAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@UTel", SqlDbType.NVarChar,50),
					new SqlParameter("@UEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@UDep", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UID;
			parameters[1].Value = model.UPassword;
			parameters[2].Value = model.UPower;
			parameters[3].Value = model.USex;
			parameters[4].Value = model.UName;
			parameters[5].Value = model.UAddress;
			parameters[6].Value = model.UTel;
			parameters[7].Value = model.UEmail;
			parameters[8].Value = model.UDep;

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
		public bool Update(Cao.WMS.Model.caowms.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("UPassword=@UPassword,");
			strSql.Append("UPower=@UPower,");
			strSql.Append("USex=@USex,");
			strSql.Append("UName=@UName,");
			strSql.Append("UAddress=@UAddress,");
			strSql.Append("UTel=@UTel,");
			strSql.Append("UEmail=@UEmail,");
			strSql.Append("UDep=@UDep");
			strSql.Append(" where UID=@UID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UPassword", SqlDbType.NVarChar,50),
					new SqlParameter("@UPower", SqlDbType.NVarChar,50),
					new SqlParameter("@USex", SqlDbType.Char,2),
					new SqlParameter("@UName", SqlDbType.NVarChar,50),
					new SqlParameter("@UAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@UTel", SqlDbType.NVarChar,50),
					new SqlParameter("@UEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@UDep", SqlDbType.NVarChar,50),
					new SqlParameter("@UID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UPassword;
			parameters[1].Value = model.UPower;
			parameters[2].Value = model.USex;
			parameters[3].Value = model.UName;
			parameters[4].Value = model.UAddress;
			parameters[5].Value = model.UTel;
			parameters[6].Value = model.UEmail;
			parameters[7].Value = model.UDep;
			parameters[8].Value = model.UID;

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
		public bool Delete(string UID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UID=@UID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = UID;

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
		public bool DeleteList(string UIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UID in ("+UIDlist + ")  ");
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
		/// 得到一个对象实体
		/// </summary>
		public Cao.WMS.Model.caowms.Users GetModel(string UID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UID,UPassword,UPower,USex,UName,UAddress,UTel,UEmail,UDep from Users ");
			strSql.Append(" where UID=@UID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = UID;

			Cao.WMS.Model.caowms.Users model=new Cao.WMS.Model.caowms.Users();
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
		public Cao.WMS.Model.caowms.Users DataRowToModel(DataRow row)
		{
			Cao.WMS.Model.caowms.Users model=new Cao.WMS.Model.caowms.Users();
			if (row != null)
			{
				if(row["UID"]!=null)
				{
					model.UID=row["UID"].ToString();
				}
				if(row["UPassword"]!=null)
				{
					model.UPassword=row["UPassword"].ToString();
				}
				if(row["UPower"]!=null)
				{
					model.UPower=row["UPower"].ToString();
				}
				if(row["USex"]!=null)
				{
					model.USex=row["USex"].ToString();
				}
				if(row["UName"]!=null)
				{
					model.UName=row["UName"].ToString();
				}
				if(row["UAddress"]!=null)
				{
					model.UAddress=row["UAddress"].ToString();
				}
				if(row["UTel"]!=null)
				{
					model.UTel=row["UTel"].ToString();
				}
				if(row["UEmail"]!=null)
				{
					model.UEmail=row["UEmail"].ToString();
				}
				if(row["UDep"]!=null)
				{
					model.UDep=row["UDep"].ToString();
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
			strSql.Append("select UID,UPassword,UPower,USex,UName,UAddress,UTel,UEmail,UDep ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" UID,UPassword,UPower,USex,UName,UAddress,UTel,UEmail,UDep ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
				strSql.Append("order by T.UID desc");
			}
			strSql.Append(")AS Row, T.*  from Users T ");
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
			parameters[0].Value = "Users";
			parameters[1].Value = "UID";
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

