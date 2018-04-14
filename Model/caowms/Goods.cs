using System;
namespace Cao.WMS.Model.caowms
{
	/// <summary>
	/// Goods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Goods
	{
		public Goods()
		{}
		#region Model
		private string _gid;
		private string _gname;
		private decimal? _gprice;
		private string _gprovider;
		private string _n_bak;
		/// <summary>
		/// 
		/// </summary>
		public string GID
		{
			set{ _gid=value;}
			get{return _gid;}
		}
		/// <summary>
		/// SKU
		/// </summary>
		public string GName
		{
			set{ _gname=value;}
			get{return _gname;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? GPrice
		{
			set{ _gprice=value;}
			get{return _gprice;}
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public string GProvider
		{
			set{ _gprovider=value;}
			get{return _gprovider;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n_bak
		{
			set{ _n_bak=value;}
			get{return _n_bak;}
		}
		#endregion Model

	}
}

