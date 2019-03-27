<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="YueYePlat.Web.productdelivery.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		DeliveryId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDeliveryId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProductId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProductId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQuantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Origin
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOrigin" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BeginTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtBeginTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Destination
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDestination" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Longitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLongitude" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Latitude
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLatitude" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PredictDeliveryTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtPredictDeliveryTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeliveryTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDeliveryTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ClientId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtClientId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArriveTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtArriveTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Signer
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSigner" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Telephone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTelephone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBackFee
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsBackFee" Text="IsBackFee" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Amount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAmount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDeliver
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsDeliver" Text="IsDeliver" runat="server" Checked="False" />
	</td></tr>
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
