using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Cao.WMS.Model.caowmsview;

namespace Cao.WMS.BLL.caowmsview
{
    /// <summary>
    /// view_GWS
    /// </summary>
    public partial class view_GWS_BLL
    {
        private readonly Cao.WMS.DAL.caowmsview.view_GWS dal = new Cao.WMS.DAL.caowmsview.view_GWS();
        public view_GWS_BLL()
		{ }
        #region  BasicMethod
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public List<Cao.WMS.Model.caowmsview.view_GWS> DataTableToList(DataTable dt)
        //{
        //    List<Cao.WMS.Model.caowmsview.view_GWS> modelList = new List<Cao.WMS.Model.caowmsview.view_GWS>();
        //    int rowsCount = dt.Rows.Count;
        //    if (rowsCount > 0)
        //    {
        //        Cao.WMS.Model.caowmsview.view_GWS model;
        //        for (int n = 0; n < rowsCount; n++)
        //        {
        //            model = dal.DataRowToModel(dt.Rows[n]);
        //            if (model != null)
        //            {
        //                modelList.Add(model);
        //            }
        //        }
        //    }
        //    return modelList;
        //}


        ///// <summary>
        ///// 得到一个对象实体
        ///// </summary>
        //public Cao.WMS.Model.caowmsview.view_GWS DataRowToModel(DataRow row)
        //{
        //    Cao.WMS.Model.caowmsview.view_GWS model = new Cao.WMS.Model.caowmsview.view_GWS();
        //    if (row != null)
        //    {
        //        if (row["RID"] != null && row["RID"].ToString() != "")
        //        {
        //            model.RID = int.Parse(row["RID"].ToString());
        //        }
        //        if (row["RGID"] != null)
        //        {
        //            model.RGID = row["RGID"].ToString();
        //        }
        //        if (row["RWID"] != null && row["RWID"].ToString() != "")
        //        {
        //            model.RWID = row["RWID"].ToString();
        //        }
        //        if (row["RQuantity"] != null && row["RQuantity"].ToString() != "")
        //        {
        //            model.RQuantity = int.Parse(row["RQuantity"].ToString());
        //        }
        //        if (row["Rtype"] != null && row["Rtype"].ToString() != "")
        //        {
        //            model.Rtype = int.Parse(row["Rtype"].ToString());
        //        }
        //        if (row["RHandler"] != null)
        //        {
        //            model.RHandler = row["RHandler"].ToString();
        //        }
        //        if (row["RTime"] != null && row["RTime"].ToString() != "")
        //        {
        //            model.RTime = DateTime.Parse(row["RTime"].ToString());
        //        }
        //    }
        //    return model;
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
