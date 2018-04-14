using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Cao.WMS.DAL.caowms
{
	/// <summary>
	/// 数据访问类:Goods
	/// </summary>
	public partial class Goods
	{
		public Goods()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string GID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Goods");
			strSql.Append(" where GID=@GID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = GID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Cao.WMS.Model.caowms.Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Goods(");
			strSql.Append("GID,GName,GPrice,GProvider,n_bak)");
			strSql.Append(" values (");
			strSql.Append("@GID,@GName,@GPrice,@GProvider,@n_bak)");
			SqlParameter[] parameters = {
					new SqlParameter("@GID", SqlDbType.NVarChar,50),
					new SqlParameter("@GName", SqlDbType.NVarChar,50),
					new SqlParameter("@GPrice", SqlDbType.Money,8),
					new SqlParameter("@GProvider", SqlDbType.NVarChar,50),
					new SqlParameter("@n_bak", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.GID;
			parameters[1].Value = model.GName;
			parameters[2].Value = model.GPrice;
			parameters[3].Value = model.GProvider;
			parameters[4].Value = model.n_bak;

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
		public bool Update(Cao.WMS.Model.caowms.Goods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Goods set ");
			strSql.Append("GName=@GName,");
			strSql.Append("GPrice=@GPrice,");
			strSql.Append("GProvider=@GProvider,");
			strSql.Append("n_bak=@n_bak");
			strSql.Append(" where GID=@GID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GName", SqlDbType.NVarChar,50),
					new SqlParameter("@GPrice", SqlDbType.Money,8),
					new SqlParameter("@GProvider", SqlDbType.NVarChar,50),
					new SqlParameter("@n_bak", SqlDbType.NVarChar,200),
					new SqlParameter("@GID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.GName;
			parameters[1].Value = model.GPrice;
			parameters[2].Value = model.GProvider;
			parameters[3].Value = model.n_bak;
			parameters[4].Value = model.GID;

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
		public bool Delete(string GID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Goods ");
			strSql.Append(" where GID=@GID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = GID;

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
		public bool DeleteList(string GIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Goods ");
			strSql.Append(" where GID in ("+GIDlist + ")  ");
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
		public Cao.WMS.Model.caowms.Goods GetModel(string GID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 GID,GName,GPrice,GProvider,n_bak from Goods ");
			strSql.Append(" where GID=@GID ");
			SqlParameter[] parameters = {
					new SqlParameter("@GID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = GID;

			Cao.WMS.Model.caowms.Goods model=new Cao.WMS.Model.caowms.Goods();
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
		public Cao.WMS.Model.caowms.Goods DataRowToModel(DataRow row)
		{
			Cao.WMS.Model.caowms.Goods model=new Cao.WMS.Model.caowms.Goods();
			if (row != null)
			{
				if(row["GID"]!=null)
				{
					model.GID=row["GID"].ToString();
				}
				if(row["GName"]!=null)
				{
					model.GName=row["GName"].ToString();
				}
				if(row["GPrice"]!=null && row["GPrice"].ToString()!="")
				{
					model.GPrice=decimal.Parse(row["GPrice"].ToString());
				}
				if(row["GProvider"]!=null)
				{
					model.GProvider=row["GProvider"].ToString();
				}
				if(row["n_bak"]!=null)
				{
					model.n_bak=row["n_bak"].ToString();
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
			strSql.Append("select GID,GName,GPrice,GProvider,n_bak ");
			strSql.Append(" FROM Goods ");
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
			strSql.Append(" GID,GName,GPrice,GProvider,n_bak ");
			strSql.Append(" FROM Goods ");
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
			strSql.Append("select count(1) FROM Goods ");
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
				strSql.Append("order by T.GID desc");
			}
			strSql.Append(")AS Row, T.*  from Goods T ");
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
			parameters[0].Value = "Goods";
			parameters[1].Value = "GID";
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

