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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Cao.WMS.Web.caowms.Users
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string UID= Request.Params["id"];
					ShowInfo(UID);
				}
			}
		}
			
	private void ShowInfo(string UID)
	{
		Cao.WMS.BLL.caowms.Users bll=new Cao.WMS.BLL.caowms.Users();
		Cao.WMS.Model.caowms.Users model=bll.GetModel(UID);
		this.lblUID.Text=model.UID;
		this.txtUPassword.Text=model.UPassword;
		this.txtUPower.Text=model.UPower;
		this.txtUSex.Text=model.USex;
		this.txtUName.Text=model.UName;
		this.txtUAddress.Text=model.UAddress;
		this.txtUTel.Text=model.UTel;
		this.txtUEmail.Text=model.UEmail;
		this.txtUDep.Text=model.UDep;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUPassword.Text.Trim().Length==0)
			{
				strErr+="UPassword不能为空！\\n";	
			}
			if(this.txtUPower.Text.Trim().Length==0)
			{
				strErr+="UPower不能为空！\\n";	
			}
			if(this.txtUSex.Text.Trim().Length==0)
			{
				strErr+="USex不能为空！\\n";	
			}
			if(this.txtUName.Text.Trim().Length==0)
			{
				strErr+="UName不能为空！\\n";	
			}
			if(this.txtUAddress.Text.Trim().Length==0)
			{
				strErr+="UAddress不能为空！\\n";	
			}
			if(this.txtUTel.Text.Trim().Length==0)
			{
				strErr+="UTel不能为空！\\n";	
			}
			if(this.txtUEmail.Text.Trim().Length==0)
			{
				strErr+="UEmail不能为空！\\n";	
			}
			if(this.txtUDep.Text.Trim().Length==0)
			{
				strErr+="UDep不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UID=this.lblUID.Text;
			string UPassword=this.txtUPassword.Text;
			string UPower=this.txtUPower.Text;
			string USex=this.txtUSex.Text;
			string UName=this.txtUName.Text;
			string UAddress=this.txtUAddress.Text;
			string UTel=this.txtUTel.Text;
			string UEmail=this.txtUEmail.Text;
			string UDep=this.txtUDep.Text;


			Cao.WMS.Model.caowms.Users model=new Cao.WMS.Model.caowms.Users();
			model.UID=UID;
			model.UPassword=UPassword;
			model.UPower=UPower;
			model.USex=USex;
			model.UName=UName;
			model.UAddress=UAddress;
			model.UTel=UTel;
			model.UEmail=UEmail;
			model.UDep=UDep;

			Cao.WMS.BLL.caowms.Users bll=new Cao.WMS.BLL.caowms.Users();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
