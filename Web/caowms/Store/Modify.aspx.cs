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
namespace Cao.WMS.Web.caowms.Store
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SID);
				}
			}
		}
			
	private void ShowInfo(int SID)
	{
		Cao.WMS.BLL.caowms.Store bll=new Cao.WMS.BLL.caowms.Store();
		Cao.WMS.Model.caowms.Store model=bll.GetModel(SID);
		this.lblSID.Text=model.SID.ToString();
		this.txtSGID.Text=model.SGID;
		this.txtSWID.Text=model.SWID.ToString();
		this.txtSTopLine.Text=model.STopLine.ToString();
		this.txtSbaseLine.Text=model.SbaseLine.ToString();
		this.txtSQuantity.Text=model.SQuantity.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSGID.Text.Trim().Length==0)
			{
				strErr+="货物类型编号不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSWID.Text))
			{
				strErr+="存放仓库编号格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSTopLine.Text))
			{
				strErr+="货物存放下限格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSbaseLine.Text))
			{
				strErr+="货物存放上限格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSQuantity.Text))
			{
				strErr+="当前存储量格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int SID=int.Parse(this.lblSID.Text);
			string SGID=this.txtSGID.Text;
            string SWID = this.txtSWID.Text;
			int STopLine=int.Parse(this.txtSTopLine.Text);
			int SbaseLine=int.Parse(this.txtSbaseLine.Text);
			int SQuantity=int.Parse(this.txtSQuantity.Text);


			Cao.WMS.Model.caowms.Store model=new Cao.WMS.Model.caowms.Store();
			model.SID=SID;
			model.SGID=SGID;
			model.SWID=SWID;
			model.STopLine=STopLine;
			model.SbaseLine=SbaseLine;
			model.SQuantity=SQuantity;

			Cao.WMS.BLL.caowms.Store bll=new Cao.WMS.BLL.caowms.Store();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
