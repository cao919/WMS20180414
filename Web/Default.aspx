<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cao.WMS.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>首页</title> 
 <link rel="stylesheet" type="text/css" href="MusCss/default.css" />
    <link href="js/themes/default/easyui.css" rel="stylesheet" type="text/css" />
    <link href="js/themes/icon.css" rel="stylesheet" type="text/css" />
      <%-- <script src="js/jquery.min.js" type="text/javascript"></script>--%>
    <script src="js/jquery-1.4.2.min.js" type="text/javascript"></script>
<%--    <script src="js/jquery.easyui.min.js" type="text/javascript"></script>--%>
    <script src="js/jquery.easyui.pack.js" type="text/javascript"></script>
    <script src="js/outlook2.js" type="text/javascript"></script>
</head>
<body class="easyui-layout" style="overflow-y: hidden" scroll="no">
    <noscript>
        <div style="position: absolute; z-index: 100000; height: 2046px; top: 0px; left: 0px;
            width: 100%; background: white; text-align: center;">
            <%--<img src="images/noscript.gif" alt='抱歉，请开启脚本支持！' />--%>
        </div>
    </noscript>

    <div region="north" split="true" border="false" style="overflow: hidden; height: 66px;
        background: url(images/layout-browser-hd-bg.gif) #7f99be repeat-x center 50%;
        line-height: 20px; color: #fff; font-family: Verdana, 微软雅黑,黑体">
        <div>
            <div style="float: left; width: 91%">
                <%--<img src="MSImage/logo.jpg" id="pindexlogo" />--%> 
                </div>
            <div style="float: left; width: 8%; padding-top: 36px; font-weight: bold;">
                <a href="#" name="loginOut" style="color: #41519A;">安全退出</a></div>
        </div>
        <%--     <div style="background: url(MSImage/title_bg.gif) top repeat-x; border-bottom: 1px #B0C4DE solid;
            line-height: 21px;">
            <div style="width: 36%; background: url(MSImage/headertop_person.png) no-repeat 5% 48%;
                font-weight: bold; padding-left: 55px; color: #fff; float: left;">
                &nbsp;&nbsp;<%=StaffInfo%></div>
        </div>--%>
        <%-- <div style="clear: both"></div>--%>
    </div>

    <div style="float: right;">
    </div>

     <div region="south" split="true" style="height: 30px; background: #D2E0F2;">
        <div class="footer">
            欢迎您,&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;<a href="#" style="text-decoration: underline" name="loginOut"
                style="color: #41519A;">安全退出</a>
          
        </div>
    </div>
    <div region="west" split="true" title="系统导航" style="width: 218px; overflow-x: hidden;
        overflow-y: hidden" id="west">
        <iframe style="width: 100%; height: 100%" frameborder="0" src="Menu.aspx"></iframe>
    </div>

     <div id="mainPanle" region="center" style="background: #eee; overflow-y: hidden">
        <div id="tabs" class="easyui-tabs" fit="true" border="false">
        <div title="欢迎使用" style="padding: 20px; overflow: hidden; display: none" id="home">
           
         
        <h1> <a href="#" onclick="top.myTab.Cts('仓库货物详细信息', 'caowmsview/view_GWS/List.aspx');">仓库货物详细信息</a> 
        <a href="javascript:top.myTab.Cts('商品','caowms/Goods/List.aspx',true)">商品</a>
          <a href="javascript:top.myTab.Cts('出入库','caowms/Records/List.aspx',true)">出入库</a>
          
          <a href="caowms/Store/List.aspx">存储规则</a>
          <a href="caowms/Warehouses/List.aspx">仓库</a>
          <a href="caowmsview/view_GWS/List.aspx">仓库货物详细信息</a>
          </h1>
       <h1>
            <a href="caowms/Goods/Add.aspx">新增商品</a>
            <a href="caowms/Records/Add.aspx">新增出入库</a>
            <a href="caowms/Store/Add.aspx">新增存储规则</a>
            <a href="caowms/Warehouses/Add.aspx">新增仓库</a>
         </h1>
     
        </div>
         </div>
         <script>
             var myTab = new HTabControl();
             myTab.Cts('系统首页', '/Index.aspx?moduleid=qq', 'a');
             //                myTab.Cts('系统首页', 'MS_OA/main/default.aspx?moduleid=qq', 'a');
             //为了切换以前的链接构造出来的
             function HTabControl() {
                 this.Cts = function (title, url, isclose) {
                     //addTab(title, url, 'refresh');
                     if (isclose != 'a') {
                         isclose = 'refresh';
                     }
                     addTab(title, url, isclose);
                 }
             }

             $(function () {
                 $('a[name=loginOut]').click(function () {
                     $.messager.confirm('系统提示', '您确定要退出本次登录吗?', function (r) {

                         if (r) {
                             location.href = '/SignOut.aspx';
                         }
                     });

                 })
             })
        </script>
     </div>
          <div id="mm" class="easyui-menu" style="width: 150px;">
        <div id="mm-tabclose">
            关闭</div>
        <div id="mm-tabcloseall">
            全部关闭</div>
        <div id="mm-tabcloseother">
            除此之外全部关闭</div>
        <div class="menu-sep">
        </div>
        <div id="mm-tabcloseright">
            当前页右侧全部关闭</div>
        <div id="mm-tabcloseleft">
            当前页左侧全部关闭</div>
        <div class="menu-sep">
        </div>
        <%--<div id="mm-exit">
            退出</div>--%>
    </div>
   
</body>
</html>
