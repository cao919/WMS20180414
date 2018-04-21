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

namespace Cao.WMS.Web.caowms.Records
{
    public partial class Add : Page
    {
        Cao.WMS.BLL.caowms.Store bllStore = new Cao.WMS.BLL.caowms.Store();
        Cao.WMS.Model.caowms.Store modelStore = new Cao.WMS.Model.caowms.Store();
        bool addStore = true;

        string newSQuantity;//当前产品数量
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.RadioButton1.Checked = true;
               
                bindData();
            }     
        }
        private void bindData()
        {

            //string st = "select * from Goods,Store where Goods.GID=Store.SGID and SWID='" + Session["Udep"].ToString() + "'order by GID desc";
            //SqlConnection con = WMS.createCon();
            //con.Open();
            //SqlCommand da = new SqlCommand(st, con);
            //SqlDataReader cn = da.ExecuteReader();
            //while (cn.Read())
            //{
            //    DropDownList1.Items.Add(new ListItem(cn["GID"].ToString()));
            //}
            //con.Close();
            //BindTextBox();

            //Cao.WMS.BLL.caowms.Records bll = new Cao.WMS.BLL.caowms.Records();
            //bll.Add(model);
            //Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");
        }
        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtRGID.Text.Trim().Length==0)
			{
				strErr+="SKU编号不能为空！\\n";	
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
            //if(!PageValidate.IsDateTime(txtRTime.Text))
            //{
            //    strErr+="RTime格式错误！\\n";	
            //}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
                     
			string RGID=this.txtRGID.Text;
			string RWID=this.txtRWID.Text;
			int RQuantity=int.Parse(this.txtRQuantity.Text);
            int Rtype=1;// = int.Parse(this.txtRtype.Text);
            
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
              newSQuantity="0"; //当前数量为0；
          }else{ 
            modelStore = bllStore.GetModel(this.txtRGID.Text, this.txtRWID.Text);
            newSQuantity = modelStore.SQuantity.ToString();
          } 
            //否则 根据出入库计算 当前数据
               //当前数量 入库则加
                if (Rtype == 1)
                {
                    //当前数据库加 现在入库的
                   // newSQuantity = Convert.ToString(int.Parse(newSQuantity) + int.Parse(txtRQuantity.Text));
                    newSQuantity = Convert.ToString(int.Parse(newSQuantity) + RQuantity);
                    modelStore.SQuantity = int.Parse(newSQuantity);
                    bllStore.Update(modelStore);
                }
                //出库则减
                else {
                    //当前数据库减 现在入库的
                   // newSQuantity = Convert.ToString(int.Parse(newSQuantity) - int.Parse(txtRQuantity.Text));
                    newSQuantity = Convert.ToString(int.Parse(newSQuantity) + RQuantity);
                    if (int.Parse(newSQuantity)<0)
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
                     
			string RHandler=this.txtRHandler.Text;
			//DateTime RTime=DateTime.Parse(this.txtRTime.Text);
            DateTime RTime = DateTime.Now;
			Cao.WMS.Model.caowms.Records model=new Cao.WMS.Model.caowms.Records();
			model.RGID=RGID;
			model.RWID=RWID;
            model.RQuantity = int.Parse(newSQuantity);//RQuantity;
			model.Rtype=Rtype;
			model.RHandler=RHandler;
            model.RTime = RTime;
            model.n_bakk = this.txt_bak.Text.Trim();
			Cao.WMS.BLL.caowms.Records bll=new Cao.WMS.BLL.caowms.Records();
			bll.Add(model);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");

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
                modelStore.STopLine =  1000; //默认上线 1000
                modelStore.SbaseLine = 1; //默认下线 1  
                modelStore.SQuantity = 0; //当前数量 0
                modelStore.N_bak = "自动创建规则"; 
                bllStore.Add(modelStore);
            } 
        }
      
    }
}
