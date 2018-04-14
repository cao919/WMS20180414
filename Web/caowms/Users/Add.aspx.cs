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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUID.Text.Trim().Length==0)
			{
				strErr+="UID不能为空！\\n";	
			}
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
			string UID=this.txtUID.Text;
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
