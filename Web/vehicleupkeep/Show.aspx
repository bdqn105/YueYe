<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.vehicleupkeep.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		auto_increment
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VehicleId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVehicleId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Kilometres
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblKilometres" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpkeepDescribe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpkeepDescribe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpkeepMoneys
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpkeepMoneys" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpkeepTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpkeepTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpkeepMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpkeepMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpkeepLocation
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpkeepLocation" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoicePhoto
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoicePhoto" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




