<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.productdelivery.Show" Title="显示页" %>
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
		ProductId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProductId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQuantity" runat="server"></asp:Label>
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
		Destination
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDestination" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Longitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLongitude" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Latitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLatitude" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PredictDeliveryTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPredictDeliveryTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeliveryTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeliveryTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ClientId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblClientId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArriveTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Signer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSigner" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Telephone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTelephone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBackFee
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsBackFee" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDeliver
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDeliver" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




