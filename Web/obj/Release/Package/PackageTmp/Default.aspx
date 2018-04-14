<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cao.WMS.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>首页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <a href="caowms/Goods/List.aspx">商品</a>
        <a href="caowms/Records/List.aspx">出入库</a>
        <a href="caowms/Store/List.aspx">存储规则</a>
        <a href="caowms/Warehouses/List.aspx">仓库</a>
    </div>
        <div>
            <a href="caowms/Goods/Add.aspx">新增商品</a>
            <a href="caowms/Records/Add.aspx">新增出入库</a>
            <a href="caowms/Store/Add.aspx">新增存储规则</a>
            <a href="caowms/Warehouses/Add.aspx">新增仓库</a>
        </div>
    </form>
</body>
</html>
