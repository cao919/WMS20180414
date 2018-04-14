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
namespace Cao.WMS.Web.caowms.Warehouses
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string WID=Request.Params["id"];
					ShowInfo(WID);
				}
			}
		}

                private void ShowInfo(string WID)
	{
		Cao.WMS.BLL.caowms.Warehouses bll=new Cao.WMS.BLL.caowms.Warehouses();
		Cao.WMS.Model.caowms.Warehouses model=bll.GetModel(WID);
		this.lblWID.Text=model.WID.ToString();
		this.txtWName.Text=model.WName;
		this.txtWArea.Text=model.WArea.ToString();
		this.txtWAddress.Text=model.WAddress;
		this.txtWDescribe.Text=model.WDescribe;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtWName.Text.Trim().Length==0)
			{
				strErr+="仓库名称不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWArea.Text))
			{
				strErr+="仓库容积格式错误！\\n";	
			}
			if(this.txtWAddress.Text.Trim().Length==0)
			{
				strErr+="仓库地址不能为空！\\n";	
			}
			if(this.txtWDescribe.Text.Trim().Length==0)
			{
				strErr+="简单描述不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}


            string WID = this.lblWID.Text;
			string WName=this.txtWName.Text;
			decimal WArea=decimal.Parse(this.txtWArea.Text);
			string WAddress=this.txtWAddress.Text;
			string WDescribe=this.txtWDescribe.Text;


			Cao.WMS.Model.caowms.Warehouses model=new Cao.WMS.Model.caowms.Warehouses();
			model.WID=WID;
			model.WName=WName;
			model.WArea=WArea;
			model.WAddress=WAddress;
			model.WDescribe=WDescribe;

			Cao.WMS.BLL.caowms.Warehouses bll=new Cao.WMS.BLL.caowms.Warehouses();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
