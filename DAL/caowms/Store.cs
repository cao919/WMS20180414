using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Cao.WMS.DAL.caowms
{
	/// <summary>
	/// 数据访问类:Store
	/// </summary>
	public partial class Store
	{
		public Store()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SID", "Store"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Store");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 是否存在该记录 SKU和仓库 当前的数量
        /// </summary>
        public bool ExistsGoodsGIDadnWarehousesWID(string GoodsGID, string WarehousesWID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Store");
            strSql.Append(" where SGID=@SGID");
            strSql.Append(" and SWID=@SWID");
            SqlParameter[] parameters = {
					new SqlParameter("@SGID", SqlDbType.NVarChar,50),
					new SqlParameter("@SWID", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = GoodsGID;
            parameters[1].Value = WarehousesWID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Cao.WMS.Model.caowms.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Store(");
			strSql.Append("SGID,SWID,STopLine,SbaseLine,SQuantity)");
			strSql.Append(" values (");
			strSql.Append("@SGID,@SWID,@STopLine,@SbaseLine,@SQuantity)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SGID", SqlDbType.NVarChar,50),
					new SqlParameter("@SWID", SqlDbType.NVarChar,50),
					new SqlParameter("@STopLine", SqlDbType.Int,4),
					new SqlParameter("@SbaseLine", SqlDbType.Int,4),
					new SqlParameter("@SQuantity", SqlDbType.Int,4)};
			parameters[0].Value = model.SGID;
			parameters[1].Value = model.SWID;
			parameters[2].Value = model.STopLine;
			parameters[3].Value = model.SbaseLine;
			parameters[4].Value = model.SQuantity;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Cao.WMS.Model.caowms.Store model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Store set ");
			strSql.Append("SGID=@SGID,");
			strSql.Append("SWID=@SWID,");
			strSql.Append("STopLine=@STopLine,");
			strSql.Append("SbaseLine=@SbaseLine,");
			strSql.Append("SQuantity=@SQuantity");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SGID", SqlDbType.NVarChar,50),
					new SqlParameter("@SWID", SqlDbType.NVarChar,50),
					new SqlParameter("@STopLine", SqlDbType.Int,4),
					new SqlParameter("@SbaseLine", SqlDbType.Int,4),
					new SqlParameter("@SQuantity", SqlDbType.Int,4),
					new SqlParameter("@SID", SqlDbType.Int,4)};
			parameters[0].Value = model.SGID;
			parameters[1].Value = model.SWID;
			parameters[2].Value = model.STopLine;
			parameters[3].Value = model.SbaseLine;
			parameters[4].Value = model.SQuantity;
			parameters[5].Value = model.SID;

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
		public bool Delete(int SID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

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
		public bool DeleteList(string SIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Store ");
			strSql.Append(" where SID in ("+SIDlist + ")  ");
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
		public Cao.WMS.Model.caowms.Store GetModel(int SID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SID,SGID,SWID,STopLine,SbaseLine,SQuantity from Store ");
			strSql.Append(" where SID=@SID");
			SqlParameter[] parameters = {
					new SqlParameter("@SID", SqlDbType.Int,4)
			};
			parameters[0].Value = SID;

			Cao.WMS.Model.caowms.Store model=new Cao.WMS.Model.caowms.Store();
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
		public Cao.WMS.Model.caowms.Store DataRowToModel(DataRow row)
		{
			Cao.WMS.Model.caowms.Store model=new Cao.WMS.Model.caowms.Store();
			if (row != null)
			{
				if(row["SID"]!=null && row["SID"].ToString()!="")
				{
					model.SID=int.Parse(row["SID"].ToString());
				}
				if(row["SGID"]!=null)
				{
					model.SGID=row["SGID"].ToString();
				}
				if(row["SWID"]!=null && row["SWID"].ToString()!="")
				{
					model.SWID=row["SWID"].ToString();
				}
				if(row["STopLine"]!=null && row["STopLine"].ToString()!="")
				{
					model.STopLine=int.Parse(row["STopLine"].ToString());
				}
				if(row["SbaseLine"]!=null && row["SbaseLine"].ToString()!="")
				{
					model.SbaseLine=int.Parse(row["SbaseLine"].ToString());
				}
				if(row["SQuantity"]!=null && row["SQuantity"].ToString()!="")
				{
					model.SQuantity=int.Parse(row["SQuantity"].ToString());
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
			strSql.Append("select SID,SGID,SWID,STopLine,SbaseLine,SQuantity ");
			strSql.Append(" FROM Store ");
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
			strSql.Append(" SID,SGID,SWID,STopLine,SbaseLine,SQuantity ");
			strSql.Append(" FROM Store ");
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
			strSql.Append("select count(1) FROM Store ");
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
				strSql.Append("order by T.SID desc");
			}
			strSql.Append(")AS Row, T.*  from Store T ");
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
			parameters[0].Value = "Store";
			parameters[1].Value = "SID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Cao.WMS.Model.caowms.Store GetModel(string SGID, string SWID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 SID,SGID,SWID,STopLine,SbaseLine,SQuantity from Store ");
            strSql.Append(" where SGID=@SGID");
            strSql.Append(" and SWID=@SWID");
            SqlParameter[] parameters = {
					new SqlParameter("@SGID", SqlDbType.NVarChar,50),
					new SqlParameter("@SWID", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = SGID;
            parameters[1].Value=SWID;

            Cao.WMS.Model.caowms.Store model = new Cao.WMS.Model.caowms.Store();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
		#endregion  ExtensionMethod


	}
}

