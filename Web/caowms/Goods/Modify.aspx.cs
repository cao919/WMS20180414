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
namespace Cao.WMS.Web.caowms.Goods
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string GID= Request.Params["id"];
					ShowInfo(GID);
				}
			}
		}
			
	private void ShowInfo(string GID)
	{
		Cao.WMS.BLL.caowms.Goods bll=new Cao.WMS.BLL.caowms.Goods();
		Cao.WMS.Model.caowms.Goods model=bll.GetModel(GID);
		this.lblGID.Text=model.GID;
		this.txtGName.Text=model.GName;
		this.txtGPrice.Text=model.GPrice.ToString();
		this.txtGProvider.Text=model.GProvider;
		this.txtn_bak.Text=model.n_bak;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGName.Text.Trim().Length==0)
			{
				strErr+="SKU不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtGPrice.Text))
			{
				strErr+="单价格式错误！\\n";	
			}
			if(this.txtGProvider.Text.Trim().Length==0)
			{
				strErr+="供应商不能为空！\\n";	
			}
			if(this.txtn_bak.Text.Trim().Length==0)
			{
				strErr+="n_bak不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string GID=this.lblGID.Text;
			string GName=this.txtGName.Text;
			decimal GPrice=decimal.Parse(this.txtGPrice.Text);
			string GProvider=this.txtGProvider.Text;
			string n_bak=this.txtn_bak.Text;


			Cao.WMS.Model.caowms.Goods model=new Cao.WMS.Model.caowms.Goods();
			model.GID=GID;
			model.GName=GName;
			model.GPrice=GPrice;
			model.GProvider=GProvider;
			model.n_bak=n_bak;

			Cao.WMS.BLL.caowms.Goods bll=new Cao.WMS.BLL.caowms.Goods();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
