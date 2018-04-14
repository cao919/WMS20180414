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
namespace Cao.WMS.Web.caowms.Records
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
					int RID=(Convert.ToInt32(strid));
					ShowInfo(RID);
				}
			}
		}
		
	private void ShowInfo(int RID)
	{
		Cao.WMS.BLL.caowms.Records bll=new Cao.WMS.BLL.caowms.Records();
		Cao.WMS.Model.caowms.Records model=bll.GetModel(RID);
		this.lblRID.Text=model.RID.ToString();
		this.lblRGID.Text=model.RGID;
		this.lblRWID.Text=model.RWID.ToString();
		this.lblRQuantity.Text=model.RQuantity.ToString();
		this.lblRtype.Text=model.Rtype.ToString();
		this.lblRHandler.Text=model.RHandler;
		this.lblRTime.Text=model.RTime.ToString();

	}


    }
}
