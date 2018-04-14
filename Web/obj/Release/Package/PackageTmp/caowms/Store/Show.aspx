<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Cao.WMS.Web.caowms.Store.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		货物类型编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSGID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存放仓库编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSWID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		货物存放下限
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTopLine" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		货物存放上限
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSbaseLine" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		当前存储量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSQuantity" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




