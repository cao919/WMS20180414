using System;
namespace Cao.WMS.Model.caowms
{
	/// <summary>
	/// Records:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Records
	{
		public Records()
		{}
		#region Model
		private int _rid;
		private string _rgid;
        private string _rwid;
		private int? _rquantity;
		private int? _rtype;
		private string _rhandler;
		private DateTime? _rtime= DateTime.Now;

        private string _n_bakk;
		/// <summary>
		/// 
		/// </summary>
		public int RID
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// SKU编号
		/// </summary>
		public string RGID
		{
			set{ _rgid=value;}
			get{return _rgid;}
		}
		/// <summary>
		/// 存储仓库编号
		/// </summary>
        public string RWID
		{
			set{ _rwid=value;}
			get{return _rwid;}
		}
		/// <summary>
		/// 进出数量
		/// </summary>
		public int? RQuantity
		{
			set{ _rquantity=value;}
			get{return _rquantity;}
		}
		/// <summary>
		/// 1入库  2出库
		/// </summary>
		public int? Rtype
		{
			set{ _rtype=value;}
			get{return _rtype;}
		}
		/// <summary>
		/// 提（送）货人名
		/// </summary>
		public string RHandler
		{
			set{ _rhandler=value;}
			get{return _rhandler;}
		}
        /// <summary>
        /// 备注
        /// </summary>
        public string n_bakk
		{
            set { _n_bakk = value; }
            get { return _n_bakk; }
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RTime
		{
			set{ _rtime=value;}
			get{return _rtime;}
		}
		#endregion Model

	}
}

