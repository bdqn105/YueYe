<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.refrighousemonitoring.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HouseId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHouseId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temperature1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemperature1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Humidity1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHumidity1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temperature2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemperature2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Humidity2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHumidity2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Temperature3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemperature3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Humidity3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHumidity3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MonitorTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMonitorTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




