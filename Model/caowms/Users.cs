using System;
namespace Cao.WMS.Model.caowms
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Users
	{
		public Users()
		{}
		#region Model
		private string _uid;
		private string _upassword;
		private string _upower;
		private string _usex;
		private string _uname;
		private string _uaddress;
		private string _utel;
		private string _uemail;
		private string _udep;
		/// <summary>
		/// 
		/// </summary>
		public string UID
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPassword
		{
			set{ _upassword=value;}
			get{return _upassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPower
		{
			set{ _upower=value;}
			get{return _upower;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USex
		{
			set{ _usex=value;}
			get{return _usex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UName
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UAddress
		{
			set{ _uaddress=value;}
			get{return _uaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UTel
		{
			set{ _utel=value;}
			get{return _utel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UEmail
		{
			set{ _uemail=value;}
			get{return _uemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UDep
		{
			set{ _udep=value;}
			get{return _udep;}
		}
		#endregion Model

	}
}

