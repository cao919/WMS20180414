using System;
namespace Cao.WMS.Model.caowms
{
	/// <summary>
	/// Warehouses:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Warehouses
	{
		public Warehouses()
		{}
		#region Model
		private string _wid;
		private string _wname;
		private decimal? _warea;
		private string _waddress;
		private string _wdescribe;
		/// <summary>
		/// 仓库编号
		/// </summary>
        public string WID
		{
			set{ _wid=value;}
			get{return _wid;}
		}
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string WName
		{
			set{ _wname=value;}
			get{return _wname;}
		}
		/// <summary>
		/// 仓库容积
		/// </summary>
		public decimal? WArea
		{
			set{ _warea=value;}
			get{return _warea;}
		}
		/// <summary>
		/// 仓库地址
		/// </summary>
		public string WAddress
		{
			set{ _waddress=value;}
			get{return _waddress;}
		}
		/// <summary>
		/// 简单描述
		/// </summary>
		public string WDescribe
		{
			set{ _wdescribe=value;}
			get{return _wdescribe;}
		}
		#endregion Model

	}
}

