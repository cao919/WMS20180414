using System;
namespace Cao.WMS.Model.caowms
{
	/// <summary>
	/// Store:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Store
	{
		public Store()
		{}
		#region Model
		private int _sid;
		private string _sgid;
		private string _swid;
		private int? _stopline;
		private int? _sbaseline;
		private int? _squantity;
        private string _n_bak;
		/// <summary>
		/// 
		/// </summary>
		public int SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 货物类型编号
		/// </summary>
		public string SGID
		{
			set{ _sgid=value;}
			get{return _sgid;}
		}
		/// <summary>
		/// 存放仓库编号
		/// </summary>
        public string SWID
		{
			set{ _swid=value;}
			get{return _swid;}
		}
		/// <summary>
		/// 货物存放下限
		/// </summary>
		public int? STopLine
		{
			set{ _stopline=value;}
			get{return _stopline;}
		}
		/// <summary>
		/// 货物存放上限
		/// </summary>
		public int? SbaseLine
		{
			set{ _sbaseline=value;}
			get{return _sbaseline;}
		}
		/// <summary>
		/// 当前存储量
		/// </summary>
		public int? SQuantity
		{
			set{ _squantity=value;}
			get{return _squantity;}
		}
        /// <summary>
        /// _n_bak
        /// </summary>
        public string N_bak
        {
            set { _n_bak = value; }
            get { return _n_bak; }
        }
		#endregion Model

	}
}

