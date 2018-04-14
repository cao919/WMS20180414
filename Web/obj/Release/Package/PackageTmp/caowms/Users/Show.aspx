<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Cao.WMS.Web.caowms.Users.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		UID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPassword
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPassword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPower
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPower" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		USex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUSex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UTel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UEmail
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UDep
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUDep" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




