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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			string SGID=this.txtSGID.Text;
            string SWID = this.txtSWID.Text;
			int STopLine=int.Parse(this.txtSTopLine.Text);
			int SbaseLine=int.Parse(this.txtSbaseLine.Text);
			int SQuantity=int.Parse(this.txtSQuantity.Text);

			Cao.WMS.Model.caowms.Store model=new Cao.WMS.Model.caowms.Store();
			model.SGID=SGID;
			model.SWID=SWID;
			model.STopLine=STopLine;
			model.SbaseLine=SbaseLine;
			model.SQuantity=SQuantity;

			Cao.WMS.BLL.caowms.Store bll=new Cao.WMS.BLL.caowms.Store();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
