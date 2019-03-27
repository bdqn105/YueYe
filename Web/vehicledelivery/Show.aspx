<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.vehicledelivery.Show" Title="显示页" %>
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
		DeliveryId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeliveryId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeviceId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeviceId" runat="server"></asp:Label>
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
		Driver1Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDriver1Id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Driver2Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDriver2Id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Origin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrigin" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BeginTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBeginTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MinTempThreshold
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMinTempThreshold" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxTempThreshold
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxTempThreshold" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MinHumThreshold
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMinHumThreshold" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxHumThreshold
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxHumThreshold" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IfEnd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIfEnd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RecordId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRecordId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Auditor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAuditor" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




