using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Cao.WMS.Model.caowms;
namespace Cao.WMS.BLL.caowms
{
	/// <summary>
	/// Warehouses
	/// </summary>
	public partial class Warehouses
	{
		private readonly Cao.WMS.DAL.caowms.Warehouses dal=new Cao.WMS.DAL.caowms.Warehouses();
		public Warehouses()
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
		public bool Exists(string WID)
		{
			return dal.Exists(WID);
		}
        /// <summary>
        /// 是否存在该记录WName
        /// </summary>
        public bool ExistsWName(string WName)
        {
            return dal.ExistsWName(WName);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Cao.WMS.Model.caowms.Warehouses model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Cao.WMS.Model.caowms.Warehouses model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string WID)
		{
			
			return dal.Delete(WID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string WIDlist )
		{
			return dal.DeleteList(WIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Cao.WMS.Model.caowms.Warehouses GetModel(string WID)
		{
			
			return dal.GetModel(WID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Cao.WMS.Model.caowms.Warehouses GetModelByCache(string WID)
		{
			
			string CacheKey = "WarehousesModel-" + WID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(WID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Cao.WMS.Model.caowms.Warehouses)objModel;
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
		public List<Cao.WMS.Model.caowms.Warehouses> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Cao.WMS.Model.caowms.Warehouses> DataTableToList(DataTable dt)
		{
			List<Cao.WMS.Model.caowms.Warehouses> modelList = new List<Cao.WMS.Model.caowms.Warehouses>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Cao.WMS.Model.caowms.Warehouses model;
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
	}
}

