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
namespace Cao.WMS.Web.caowms.Records
{
    public partial class Modify : Page
    {
        Cao.WMS.BLL.caowms.Store bllStore = new Cao.WMS.BLL.caowms.Store();
        Cao.WMS.Model.caowms.Store modelStore = new Cao.WMS.Model.caowms.Store();
        bool addStore = true;

        string newSQuantity;//当前产品数量
        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int RID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(RID);
				}
			}
		}
			
	private void ShowInfo(int RID)
	{
		Cao.WMS.BLL.caowms.Records bll=new Cao.WMS.BLL.caowms.Records();
		Cao.WMS.Model.caowms.Records model=bll.GetModel(RID);
		this.lblRID.Text=model.RID.ToString();
		this.txtRGID.Text=model.RGID;
		this.txtRWID.Text=model.RWID.ToString();
		this.txtRQuantity.Text=model.RQuantity.ToString();
		//this.txtRtype.Text=model.Rtype.ToString();
        if (model.Rtype == 2)
        {
            this.RadioButton2.Checked = true;
        }
        else {
            this.RadioButton1.Checked = true;
        }
		this.txtRHandler.Text=model.RHandler;
        this.txtRTime.Text = model.RTime.ToString();
        this.txt_bak.Text = model.N_bak;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRGID.Text.Trim().Length==0)
			{
                strErr += "SKU编号不能为空！\\n";	
			}
            if (this.txtRWID.Text.Trim().Length == 0)
            {
                strErr += "存储仓库编号不能为空！\\n";
            }
			if(!PageValidate.IsNumber(txtRQuantity.Text))
			{
				strErr+="进出数量格式错误！\\n";	
			}
            //if(!PageValidate.IsNumber(txtRtype.Text))
            //{
            //    strErr+="1入库  2出库格式错误！\\n";	
            //}
			if(this.txtRHandler.Text.Trim().Length==0)
			{
				strErr+="提（送）货人名不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRTime.Text))
			{
				strErr+="RTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RID=int.Parse(this.lblRID.Text);
			string RGID=this.txtRGID.Text;
            string RWID =this.txtRWID.Text;
			int RQuantity=int.Parse(this.txtRQuantity.Text);
			
            int Rtype=1;
			string RHandler=this.txtRHandler.Text;
			DateTime RTime=DateTime.Parse(this.txtRTime.Text);
            if (RadioButton2.Checked == true)
            {
                Rtype = 2;
            }
            else
            {
                Rtype = 1;
            }

            //判断如果SKU和仓库
            addGoods();
            addWarehouses();
            //如果没有此款规则 则添加默认规则
            ExistsGoodsGIDadnWarehousesWID();

            if (!addStore)
            {
                newSQuantity = "0"; //当前数量为0；
            }
            else
            { 
                modelStore = bllStore.GetModel(this.txtRGID.Text, this.txtRWID.Text);
                newSQuantity = modelStore.SQuantity.ToString();
            }
             
            //否则 根据出入库计算 当前数据
            //当前数量 入库则加
            if (Rtype == 1)
            {
                //当前数据库加 现在入库的
               // newSQuantity = Convert.ToString(int.Parse(newSQuantity) + int.Parse(txtSQuantity.Text));
                newSQuantity = Convert.ToString(int.Parse(newSQuantity) + RQuantity);
                modelStore.SQuantity = int.Parse(newSQuantity);
                bllStore.Update(modelStore);
            }
            //出库则减
            else
            {
                //当前数据库减 现在入库的
                //newSQuantity = Convert.ToString(int.Parse(newSQuantity) - int.Parse(txtSQuantity.Text));
                newSQuantity = Convert.ToString(int.Parse(newSQuantity) + RQuantity);
                if (int.Parse(newSQuantity) < 0)
                {
                    strErr += "超出库存量 \\n";
                    MessageBox.Show(this, strErr);
                    return;
                }
                if (int.Parse(newSQuantity) == 0)
                {
                    strErr += "SKU清空为0 \\n";
                    MessageBox.Show(this, strErr);
                    // return;
                }
                modelStore.SQuantity = int.Parse(newSQuantity);
                bllStore.Update(modelStore);
            }


			Cao.WMS.Model.caowms.Records model=new Cao.WMS.Model.caowms.Records();
			model.RID=RID;
			model.RGID=RGID;
			model.RWID=RWID;
			model.RQuantity=RQuantity;
			model.Rtype=Rtype;
			model.RHandler=RHandler;
			model.RTime=RTime;
            model.N_bak = this.txt_bak.Text.Trim();

			Cao.WMS.BLL.caowms.Records bll=new Cao.WMS.BLL.caowms.Records();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }


        /// <summary>
        /// 新增商品sku
        /// </summary>
        public void addGoods()
        {
            bool addGoods = true;
            Cao.WMS.BLL.caowms.Goods bllgoods = new Cao.WMS.BLL.caowms.Goods();
            addGoods = bllgoods.Exists(this.txtRGID.Text.Trim());
            if (!addGoods)
            {
                Cao.WMS.Model.caowms.Goods modelgoods = new Cao.WMS.Model.caowms.Goods();
                modelgoods.GID = this.txtRGID.Text.Trim();
                modelgoods.GName = "";
                modelgoods.GPrice = 0;
                modelgoods.GProvider = "";
                modelgoods.n_bak = "入库新增SKU";
                bllgoods.Add(modelgoods);
            }
        }

        /// <summary>
        ///新增仓库货位
        /// </summary>
        public void addWarehouses()
        {
            bool addWarehouses = true;
            Cao.WMS.BLL.caowms.Warehouses bllWarehouses = new Cao.WMS.BLL.caowms.Warehouses();
            addWarehouses = bllWarehouses.Exists(this.txtRWID.Text);
            if (!addWarehouses)
            {
                Cao.WMS.Model.caowms.Warehouses modelWarehouses = new Cao.WMS.Model.caowms.Warehouses();
                modelWarehouses.WID = this.txtRWID.Text;
                modelWarehouses.WName = "";
                modelWarehouses.WArea = 0;
                modelWarehouses.WAddress = "";
                modelWarehouses.WDescribe = "入库新增货位";
                bllWarehouses.Add(modelWarehouses);
            }
        }
        /// <summary>
        /// 新增规则及当前货物
        /// </summary>
        public void ExistsGoodsGIDadnWarehousesWID()
        {

            addStore = bllStore.ExistsGoodsGIDadnWarehousesWID(this.txtRGID.Text, this.txtRWID.Text);
            if (!addStore)
            {

                modelStore.SGID = this.txtRGID.Text.Trim();
                modelStore.SWID = this.txtRWID.Text.Trim();
                modelStore.STopLine = 1000; //默认上线 1000
                modelStore.SbaseLine = 1; //默认下线 1  
                modelStore.SQuantity = 0; //当前数量 0
                modelStore.N_bak = "自动创建规则";
                bllStore.Add(modelStore);
            }
        }
    }
}
