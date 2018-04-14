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
namespace Cao.WMS.Web.caowms.Store
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
					int SID=(Convert.ToInt32(strid));
					ShowInfo(SID);
				}
			}
		}
		
	private void ShowInfo(int SID)
	{
		Cao.WMS.BLL.caowms.Store bll=new Cao.WMS.BLL.caowms.Store();
		Cao.WMS.Model.caowms.Store model=bll.GetModel(SID);
		this.lblSID.Text=model.SID.ToString();
		this.lblSGID.Text=model.SGID;
		this.lblSWID.Text=model.SWID.ToString();
		this.lblSTopLine.Text=model.STopLine.ToString();
		this.lblSbaseLine.Text=model.SbaseLine.ToString();
		this.lblSQuantity.Text=model.SQuantity.ToString();

	}


    }
}
