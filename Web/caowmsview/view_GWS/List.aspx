<%@ Page Language="C#" MasterPageFile="~/MasterPage.master"  AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Cao.WMS.Web.caowmsview.view_GWS.List" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        <asp:Button ID="btnNPOIHelperExcel" runat="server" Text="导出" OnClick="btnNPOIExcel" />    
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br /> 
                <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" 
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center"  >
                    <Columns>
                           <%--  <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>  --%>
		<asp:BoundField DataField="GID" HeaderText="SKU编号" SortExpression="RGID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GName" HeaderText="货物名称" SortExpression="RWID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GPrice" HeaderText="当前价格" SortExpression="RQuantity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GProvider" HeaderText="供应商" SortExpression="Rtype" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SQuantity" HeaderText="库存量" SortExpression="RHandler" ItemStyle-HorizontalAlign="Center"  />  
                            
                          <%--  <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="RID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />--%>
                           
                           <%-- <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <%--<asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>   --%>                    
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
