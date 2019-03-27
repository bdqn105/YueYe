<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.exceptioninfo.Show" Title="显示页" %>
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
		DeliverId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeliverId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExceptionType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExceptionType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Exceptiondescribe
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExceptiondescribe" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExceptionDispose
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExceptionDispose" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sender
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSender" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SendTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSendTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Conductor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConductor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisposeTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




