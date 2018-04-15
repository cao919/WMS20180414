﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Cao.WMS.Web.caowms.Records.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SKU编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRGID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		存储仓库编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRWID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		当前数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSQuantity" runat="server" Width="200px"></asp:TextBox>所有新增SKU仓库默认为0
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		进出数量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRQuantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		入库 出库
	：</td>
	<td height="25" width="*" align="left">
		<%--<asp:TextBox id="txtRtype" runat="server" Width="200px"></asp:TextBox>--%>
           <asp:RadioButton ID="RadioButton1" runat="server" GroupName="1" Text="入库" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="1" Text="出库" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		提（送）货人名
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRHandler" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txt_bak" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<%--<td height="25" width="30%" align="right">
		RTime
	：</td>--%>
	<%--<td height="25" width="*" align="left">
		<asp:TextBox ID="txtRTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td>--%></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
