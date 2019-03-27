<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="YueYePlat.Web.logiscompanyinfo.Show" Title="显示页" %>
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
		CompanyID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyUnifiedCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyUnifiedCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ToPublicAccount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblToPublicAccount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ToPrivateAccount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblToPrivateAccount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyLocation
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyLocation" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BusinessNature
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBusinessNature" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LegalRepresentative
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLegalRepresentative" runat="server"></asp:Label>
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
		Mobile
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMobile" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FaxNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFaxNo" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




