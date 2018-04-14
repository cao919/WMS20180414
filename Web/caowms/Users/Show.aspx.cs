using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace Cao.WMS.Web.caowms.Users
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string UID= strid;
					ShowInfo(UID);
				}
			}
		}
		
	private void ShowInfo(string UID)
	{
		Cao.WMS.BLL.caowms.Users bll=new Cao.WMS.BLL.caowms.Users();
		Cao.WMS.Model.caowms.Users model=bll.GetModel(UID);
		this.lblUID.Text=model.UID;
		this.lblUPassword.Text=model.UPassword;
		this.lblUPower.Text=model.UPower;
		this.lblUSex.Text=model.USex;
		this.lblUName.Text=model.UName;
		this.lblUAddress.Text=model.UAddress;
		this.lblUTel.Text=model.UTel;
		this.lblUEmail.Text=model.UEmail;
		this.lblUDep.Text=model.UDep;

	}


    }
}
