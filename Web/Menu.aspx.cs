using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using Cao.WMS.Web;


namespace Cao.WMS.Web
{


    public partial class Menu : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Accordion1.Panes.Clear();
            this.Accordion1.HeaderCssClass = "AjaxAccordionHeader";
            this.Accordion1.HeaderSelectedCssClass = "AjaxAccordionHeaderSelected";
            this.Accordion1.ContentCssClass = "AjaxAccordionContent";
            this.Accordion1.RequireOpenedPane = false;
            this.Accordion1.AutoSize = AjaxControlToolkit.AutoSize.None;
            this.Accordion1.SelectedIndex = 0;

            #region 客户管理
            AjaxControlToolkit.AccordionPane p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 0); // "panel_" + comModuleInfo.id;
           
            Label lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 0);
            lTitle.Text = "客户管理";
            p.HeaderContainer.Controls.Add(lTitle);


            TreeView treeView = new TreeView();
            treeView.ID = "pContent_0_0"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView,0);
            p.ContentContainer.Controls.Add(treeView);
            this.Accordion1.Panes.Add(p);
            #endregion

           

            #region 待办事宜
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 1); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 1);
            lTitle.Text = "待办事宜";
            p.HeaderContainer.Controls.Add(lTitle);

         
            treeView = new TreeView();
            treeView.ID = "pContent_0_1"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 1);
            p.ContentContainer.Controls.Add(treeView);
            
            this.Accordion1.Panes.Add(p);
            #endregion

            #region 上报审批
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 2); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 2);
            lTitle.Text = "上报审批";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_2"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 2);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 领导决策
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 3); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 3);
            lTitle.Text = "领导决策";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_3"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 3);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 人事管理
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 4); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 4);
            lTitle.Text = "人事管理";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_4"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 4);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 系统设置
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 5); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 5);
            lTitle.Text = "系统设置";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_5"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 5);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 功能Demo
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 6); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 6);
            lTitle.Text = "功能Demo";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_6"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 6);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 基础信息
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 7); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 7);
            lTitle.Text = "基础信息";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_7"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 7);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 入库管理
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 8); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 8);
            lTitle.Text = "入库管理";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_8"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 8);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 出库管理
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 9); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 9);
            lTitle.Text = "出库管理";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_9"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 9);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 库存管理
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 10); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 10);
            lTitle.Text = "库存管理";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_10"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 10);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

            #region 统计查询 
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 11); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 11);
            lTitle.Text = "统计查询";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_11"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 11);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion


            #region 地图应用
            p = new AjaxControlToolkit.AccordionPane();
            p.ID = string.Format("panel_{0}_{1}", 0, 12); // "panel_" + comModuleInfo.id;

            lTitle = new Label();

            lTitle.ID = string.Format("pHeader_{0}_{1}", 0, 12);
            lTitle.Text = "地图应用";
            p.HeaderContainer.Controls.Add(lTitle);


            treeView = new TreeView();
            treeView.ID = "pContent_0_12"; // "pContent_" + comModuleInfo.id.ToString();
            treeView.SkinID = "treeView";
            treeView.SkipLinkText = "";

            CreateTreeView(treeView, 12);
            p.ContentContainer.Controls.Add(treeView);

            this.Accordion1.Panes.Add(p);
            #endregion

        }


        public void CreateTreeView(TreeView treeView,int index)
        {
            if (index == 0)
            {
                #region 客户管理

                #endregion
            }
            else if(index == 1)
            {
                #region 待办事宜

                #endregion 
            }
            else if (index == 2)
            {
                #region 上报审批 

                #endregion
            }
            else if (index == 3)
            {
                #region 领导决策 

                #endregion
            }

            else if (index == 4)
            {
                #region 人事管理 

                #endregion
            }

            else if (index == 5)
            {
                #region 系统设置 

                #endregion
            }

            else if (index == 6)
            {
                #region 功能Demo
                 
                #endregion
            }
            else if (index == 7)
            {
                #region 基础信息管理



                TreeNode treeNode = new TreeNode();
                treeNode.Text = "仓库货区管理";
                treeNode.Value = "仓库货区管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "仓库货区管理",
                                                     "/caowms/Warehouses/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "货位管理";
                treeNode.Value = "货位管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "货位管理", "/caowms/Warehouses/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "托盘管理";
                treeNode.Value = "托盘管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "托盘管理", "/Sys/Emailsys/EmailsysView.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode); 

                treeNode = new TreeNode();
                treeNode.Text = "供应商管理";
                treeNode.Value = "供应商管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "供应商管理",
                                                     "/caowms/Warehouses/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "计量单位管理";
                treeNode.Value = "计量单位管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "计量单位管理",
                                                     "/caowms/Warehouses/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                
                #endregion
            }

            else if (index == 8)
            {
                #region  入库管理 

                TreeNode treeNode = new TreeNode();
                treeNode.Text = "入库单据管理";
                treeNode.Value = "入库单据管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "入库单据管理",
                                                     "/Sys/FileupLoad/ImagesAutoUpload.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "入库配盘";
                treeNode.Value = "入库配盘";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "入库配盘", "/caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "入库任务管理";
                treeNode.Value = "入库任务管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "入库任务管理", "/caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "空托盘入库";
                treeNode.Value = "空托盘入库";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "空托盘入库",
                                                     "/caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "入库查看";
                treeNode.Value = "入库查看";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "入库查看",
                                                     "caowms/Records/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                #endregion
            }

            else if (index == 9)
            {
                #region 出库管理

                TreeNode treeNode = new TreeNode();
                treeNode.Text = "出库单据管理";
                treeNode.Value = "出库单据管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出库单据管理",
                                                     "caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "出库配盘";
                treeNode.Value = "出库配盘";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出库配盘", "caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "出库任务管理";
                treeNode.Value = "出库任务管理";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出库任务管理", "caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "空托盘出库";
                treeNode.Value = "空托盘出库";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "空托盘出库",
                                                     "caowms/Records/Add.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "出库查看";
                treeNode.Value = "出库查看";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出库查看",
                                                     "/caowms/Records/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                #endregion
            }

            else if (index == 10)
            {
                #region  库存管理

                TreeNode treeNode = new TreeNode();
                treeNode.Text = "库存盘点";
                treeNode.Value = "库存盘点";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "库存盘点",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "移库";
                treeNode.Value = "移库";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "移库", "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "调整单";
                treeNode.Value = "调整单";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "调整单", "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "出库查看";
                treeNode.Value = "出库查看";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出库查看",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "仓位图";
                treeNode.Value = "仓位图";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "仓位图",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                #endregion
            }

            else if (index == 11)
            {
                #region  统计查询

                TreeNode treeNode = new TreeNode();
                treeNode.Text = "库存明细";
                treeNode.Value = "库存明细";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "库存明细",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "库存统计";
                treeNode.Value = "库存统计";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "库存统计", "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "租凭统计";
                treeNode.Value = "租凭统计";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "租凭统计", "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "库存流水账";
                treeNode.Value = "库存流水账";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "库存流水账", "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "系统日志";
                treeNode.Value = "系统日志";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "系统日志",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "货位统计";
                treeNode.Value = "货位统计";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "货位统计",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "出入库物料汇总";
                treeNode.Value = "出入库物料汇总";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出入库物料汇总",
                                                     "caowmsview/view_GWS/List.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                #endregion
            }
            else if (index == 12)
            {
                #region  地图应用

                TreeNode treeNode = new TreeNode();
                treeNode.Text = "行政区域查询";
                treeNode.Value = "行政区域查询";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "行政区域查询",
                                                     "http://520mus.com/city.html");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "行政区域统计";
                treeNode.Value = "行政区域统计";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "行政区域统计", "http://520mus.com/city.html");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "库存流水账";
                treeNode.Value = "库存流水账";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "库存流水账", "/Sys/Emailsys/EmailsysView.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "系统日志";
                treeNode.Value = "系统日志";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "系统日志",
                                                     "/MS_Styseting/MS_Designoffice/MS_DesignofficeView.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);

                treeNode = new TreeNode();
                treeNode.Text = "货位统计";
                treeNode.Value = "货位统计";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "货位统计",
                                                     "/MS_Styseting/MS_Designoffice/MS_DesignofficeView.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);


                treeNode = new TreeNode();
                treeNode.Text = "出入库物料汇总";
                treeNode.Value = "出入库物料汇总";
                treeNode.NavigateUrl = string.Format("javascript:top.myTab.Cts('{0}','{1}',true)", "出入库物料汇总",
                                                     "/MS_Styseting/MS_Designoffice/MS_DesignofficeView.aspx");
                treeNode.Expanded = true;
                treeView.Nodes.Add(treeNode);
                #endregion
            }
        }

    }
}