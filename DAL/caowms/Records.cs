﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Cao.WMS.DAL.caowms
{
	/// <summary>
	/// 数据访问类:Records
	/// </summary>
	public partial class Records
	{
		public Records()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RID", "Records"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Records");
			strSql.Append(" where RID=@RID");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)
			};
			parameters[0].Value = RID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsRGID(int RGID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Records");
            strSql.Append(" where RGID=@RGID");
            SqlParameter[] parameters = {
					new SqlParameter("@RGID", SqlDbType.Int,4)
			};
            parameters[0].Value = RGID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Cao.WMS.Model.caowms.Records model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Records(");
            strSql.Append("RGID,RWID,RQuantity,Rtype,RHandler,RTime,n_bakk)");
			strSql.Append(" values (");
            strSql.Append("@RGID,@RWID,@RQuantity,@Rtype,@RHandler,@RTime,@n_bakk)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@RGID", SqlDbType.NVarChar,50),
					new SqlParameter("@RWID", SqlDbType.Int,4),
					new SqlParameter("@RQuantity", SqlDbType.Int,4),
					new SqlParameter("@Rtype", SqlDbType.Int,4),
					new SqlParameter("@RHandler", SqlDbType.NVarChar,50),
					new SqlParameter("@RTime", SqlDbType.DateTime), 
					new SqlParameter("@n_bakk", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.RGID;
			parameters[1].Value = model.RWID;
			parameters[2].Value = model.RQuantity;
			parameters[3].Value = model.Rtype;
			parameters[4].Value = model.RHandler;
			parameters[5].Value = model.RTime;
            parameters[4].Value = model.n_bakk;

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
		public bool Update(Cao.WMS.Model.caowms.Records model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Records set ");
			strSql.Append("RGID=@RGID,");
			strSql.Append("RWID=@RWID,");
			strSql.Append("RQuantity=@RQuantity,");
			strSql.Append("Rtype=@Rtype,");
			strSql.Append("RHandler=@RHandler,");
            strSql.Append("RTime=@RTime");
            strSql.Append("n_bakk=@n_bakk,");
			strSql.Append(" where RID=@RID");
			SqlParameter[] parameters = {
					new SqlParameter("@RGID", SqlDbType.NVarChar,50),
					new SqlParameter("@RWID", SqlDbType.Int,4),
					new SqlParameter("@RQuantity", SqlDbType.Int,4),
					new SqlParameter("@Rtype", SqlDbType.Int,4),
					new SqlParameter("@RHandler", SqlDbType.NVarChar,50),
					new SqlParameter("@RTime", SqlDbType.DateTime),
					new SqlParameter("@n_bakk", SqlDbType.NVarChar,200),
					new SqlParameter("@RID", SqlDbType.Int,4)};
			parameters[0].Value = model.RGID;
			parameters[1].Value = model.RWID;
			parameters[2].Value = model.RQuantity;
			parameters[3].Value = model.Rtype;
			parameters[4].Value = model.RHandler;
			parameters[5].Value = model.RTime;
            parameters[6].Value = model.n_bakk;
            
			parameters[7].Value = model.RID;

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
		public bool Delete(int RID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Records ");
			strSql.Append(" where RID=@RID");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)
			};
			parameters[0].Value = RID;

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
		public bool DeleteList(string RIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Records ");
			strSql.Append(" where RID in ("+RIDlist + ")  ");
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
		public Cao.WMS.Model.caowms.Records GetModel(int RID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 RID,RGID,RWID,RQuantity,Rtype,RHandler,RTime,n_bakk from Records ");
			strSql.Append(" where RID=@RID");
			SqlParameter[] parameters = {
					new SqlParameter("@RID", SqlDbType.Int,4)
			};
			parameters[0].Value = RID;

			Cao.WMS.Model.caowms.Records model=new Cao.WMS.Model.caowms.Records();
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
		public Cao.WMS.Model.caowms.Records DataRowToModel(DataRow row)
		{
			Cao.WMS.Model.caowms.Records model=new Cao.WMS.Model.caowms.Records();
			if (row != null)
			{
				if(row["RID"]!=null && row["RID"].ToString()!="")
				{
					model.RID=int.Parse(row["RID"].ToString());
				}
				if(row["RGID"]!=null)
				{
					model.RGID=row["RGID"].ToString();
				}
				if(row["RWID"]!=null && row["RWID"].ToString()!="")
				{
					model.RWID=row["RWID"].ToString();
				}
				if(row["RQuantity"]!=null && row["RQuantity"].ToString()!="")
				{
					model.RQuantity=int.Parse(row["RQuantity"].ToString());
				}
				if(row["Rtype"]!=null && row["Rtype"].ToString()!="")
				{
					model.Rtype=int.Parse(row["Rtype"].ToString());
				}
				if(row["RHandler"]!=null)
				{
					model.RHandler=row["RHandler"].ToString();
				}

                if (row["n_bakk"] != null)
				{
                    model.n_bakk = row["n_bakk"].ToString();
				}
				if(row["RTime"]!=null && row["RTime"].ToString()!="")
				{
					model.RTime=DateTime.Parse(row["RTime"].ToString());
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
            strSql.Append("select RID,RGID,RWID,RQuantity,Rtype,RHandler,RTime,n_bakk ");
			strSql.Append(" FROM Records ");
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
            strSql.Append(" RID,RGID,RWID,RQuantity,Rtype,RHandler,RTime,n_bakk ");
			strSql.Append(" FROM Records ");
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
			strSql.Append("select count(1) FROM Records ");
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
				strSql.Append("order by T.RID desc");
			}
			strSql.Append(")AS Row, T.*  from Records T ");
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
			parameters[0].Value = "Records";
			parameters[1].Value = "RID";
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

