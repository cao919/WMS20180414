<%@ Page Language="C#" MasterPageFile="~/WebForm/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Cao.WMS.Web.caowms.Records.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		RID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SKU编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRGID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存储仓库编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRWID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		进出数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRQuantity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		1入库  2出库
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRtype" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		提（送）货人名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRHandler" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRTime" runat="server"></asp:Label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lbln_bakk" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




