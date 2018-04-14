using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Cao.WMS.Model.caowms;
namespace Cao.WMS.BLL.caowms
{
	/// <summary>
	/// Store
	/// </summary>
	public partial class Store
	{
		private readonly Cao.WMS.DAL.caowms.Store dal=new Cao.WMS.DAL.caowms.Store();
		public Store()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SID)
		{
			return dal.Exists(SID);
		}
        /// <summary>
        /// SKU和仓库 当前的数量
        /// </summary>
        /// <param name="GoodsGID"></param>
        /// <param name="WarehousesWID"></param>
        /// <returns></returns>
        public bool ExistsGoodsGIDadnWarehousesWID(string GoodsGID, string WarehousesWID)
        {
            return dal.ExistsGoodsGIDadnWarehousesWID(GoodsGID, WarehousesWID);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Cao.WMS.Model.caowms.Store model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Cao.WMS.Model.caowms.Store model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SID)
		{
			
			return dal.Delete(SID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SIDlist )
		{
			return dal.DeleteList(SIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Cao.WMS.Model.caowms.Store GetModel(int SID)
		{
			
			return dal.GetModel(SID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Cao.WMS.Model.caowms.Store GetModelByCache(int SID)
		{
			
			string CacheKey = "StoreModel-" + SID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(SID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Cao.WMS.Model.caowms.Store)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Cao.WMS.Model.caowms.Store> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Cao.WMS.Model.caowms.Store> DataTableToList(DataTable dt)
		{
			List<Cao.WMS.Model.caowms.Store> modelList = new List<Cao.WMS.Model.caowms.Store>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Cao.WMS.Model.caowms.Store model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
        /// <summary>
        /// 根据 SGID和 SEID得到一个实体
        /// </summary>
        /// <param name="SGID"></param>
        /// <param name="SWID"></param>
        /// <returns></returns>
         public Cao.WMS.Model.caowms.Store GetModel(string SGID, string SWID)
        {
            return dal.GetModel(SGID,SWID);
         }
	}
}

