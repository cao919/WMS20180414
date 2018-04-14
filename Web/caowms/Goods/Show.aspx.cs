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
namespace Cao.WMS.Web.caowms.Goods
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
					string GID= strid;
					ShowInfo(GID);
				}
			}
		}
		
	private void ShowInfo(string GID)
	{
		Cao.WMS.BLL.caowms.Goods bll=new Cao.WMS.BLL.caowms.Goods();
		Cao.WMS.Model.caowms.Goods model=bll.GetModel(GID);
		this.lblGID.Text=model.GID;
		this.lblGName.Text=model.GName;
		this.lblGPrice.Text=model.GPrice.ToString();
		this.lblGProvider.Text=model.GProvider;
		this.lbln_bak.Text=model.n_bak;

	}


    }
}
