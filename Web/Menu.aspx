<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs"  Theme="Glass"
    Inherits="Cao.WMS.Web.Menu" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
    <%--  <script src="/MSJs/Main.js"></script>--%>
    <script type="text/javascript">
        // loadCss(top._skinId, 'Page.css');
    </script>
    <style type="text/css">
        html, body
        {
            background-color: #E1EDF6;
            margin: 0; /*控制滚动条左右侧实线颜色*/ /*overflow-x: hidden; 隐藏底部的横向滚动条*/
            scrollbar-arrow-color: #B0C4DE; /*三角箭头的颜色*/
            scrollbar-face-color: #EFF6FB; /*立体滚动条的颜色*/
            scrollbar-3dlight-color: #ffffff; /*立体滚动条亮边的颜色*/
            scrollbar-highlight-color: #ECF3F9; /*滚动条空白部分的颜色*/
            scrollbar-shadow-color: #ECF3F9; /*立体滚动条阴影的颜色*/
            scrollbar-darkshadow-color: #F2F2F2; /*滚动条强阴影颜色*/
            scrollbar-track-color: #FFFFFF; /*立体滚动条背景颜色*/
            scrollbar-base-color: #F2F2F2; /*滚动条的基本颜色*/
        }
        a:link
        {
            text-decoration: none;
            color: #000000;
        }
        a:visited
        {
            text-decoration: none;
            color: #000000;
        }
        a
        {
            font-size: 10px;
            color: #000000;
        }
        .left_menu
        {
            float: left;
            width: 184px;
        }
    </style>
    <link href="MusCss/css.css" rel="stylesheet" type="text/css" /> 
</head>
<%--<body  oncontextmenu="return false">--%>
<body>
    <form id="form1" runat="server" style="padding: 0px; margin: 0px;">
    <table width="100%" border="0" cellpadding="1" cellspacing="1" class="" style="background: #ffffff"
        align="left">
        <tr>
            <td style="">
                <%--<div id="Div1" style="overflow-y: auto; height: 500px; width: 100%; margin: 0px;">--%>
                <div id="MenuPanel" style="overflow-y: auto; width: 100%; margin: 0px;">
                    <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </cc1:ToolkitScriptManager>
                    <cc1:Accordion ID="Accordion1" runat="server">
                    </cc1:Accordion>
                </div>
            </td>
        </tr>
    </table>
    </form>
    <%-- <br />
        <asp:TreeView ID="TreeView1"   ShowExpandCollapse="True"  runat="server"  ExpandDepth="1" ImageSet="XPFileExplorer" NodeIndent="15">
           <Nodes>
                <asp:TreeNode   Text="新建节点1" Expanded="true" Value="新建节点">
                    <asp:TreeNode Text="系统介绍" NavigateUrl="javascript:top.myTab.Cts('系统介绍','default1.aspx')" Value="系统介绍">
                         <asp:TreeNode Text="系统介绍111" NavigateUrl="javascript:top.myTab.Cts('系统介绍1111','default1.aspx')" Value="系统介绍1111"></asp:TreeNode>
                    <asp:TreeNode Text="tab页的调用222" NavigateUrl="javascript:top.myTab.Cts('tab页的调用1111','default3.aspx')" Value="tab页的调用111"></asp:TreeNode>

                    </asp:TreeNode>
                    <asp:TreeNode Text="tab页的调用" NavigateUrl="javascript:top.myTab.Cts('tab页的调用','default3.aspx')" Value="tab页的调用"></asp:TreeNode>
                </asp:TreeNode>
                
                
                  <asp:TreeNode Text="新建节点2" Expanded="false" Value="新建节点">
                    <asp:TreeNode Text="系统介绍" NavigateUrl="javascript:top.myTab.Cts('系统介绍','default1.aspx')" Value="系统介绍">
                         <asp:TreeNode Text="系统介绍111" NavigateUrl="javascript:top.myTab.Cts('系统介绍1111','default1.aspx')" Value="系统介绍1111"></asp:TreeNode>
                    <asp:TreeNode Text="tab页的调用222" NavigateUrl="javascript:top.myTab.Cts('tab页的调用1111','default3.aspx')" Value="tab页的调用111"></asp:TreeNode>

                    </asp:TreeNode>
                    <asp:TreeNode Text="tab页的调用" NavigateUrl="javascript:top.myTab.Cts('tab页的调用','default3.aspx')" Value="tab页的调用"></asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <ParentNodeStyle Font-Bold="False" />
            <HoverNodeStyle Font-Underline="True" ForeColor="#6666AA" />
            <SelectedNodeStyle BackColor="#B5B5B5" Font-Underline="False" HorizontalPadding="0px" VerticalPadding="0px" />
            <NodeStyle Font-Names="Tahoma" Font-Size="8pt" ForeColor="Black" HorizontalPadding="2px" NodeSpacing="0px" VerticalPadding="2px" />
        </asp:TreeView>--%>
</body>
</html>
