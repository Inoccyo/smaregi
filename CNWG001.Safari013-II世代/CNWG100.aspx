<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG100.aspx.vb" Inherits="CNWG001.CNWG100" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG100</title>
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript">
			function fMsg(pMSGCD, pGOODSCD){
				//frames["F_CNWG100"].location.href = "./CNWG101.aspx?MSGCD=" + pMSGCD + "&GOODSCD=" + pGOODSCD + "&PGNM=CNWG100";
				document.getElementsByTagName("iframe")["F_CNWG100"].contentWindow.location.href = "./CNWG101.aspx?MSGCD=" + pMSGCD + "&GOODSCD=" + pGOODSCD + "&PGNM=CNWG100";
				document.all["F_CNWG100"].style.visibility = "visible";
				// ÇRïbå„Ç…ÅAÉÅÉbÉZÅ[ÉWïîï™ÇîÒï\é¶Ç…ê›íËÇ∑ÇÈ
				setTimeout("fWinClose()",2000);			
			}
			function fWinClose(){
				document.all["F_CNWG100"].style.visibility = "hidden";
			}
			function fRefBack(){
				//parent.document.all["F_CNWG020"].style.visibility = "hidden";
				top.location.href = "./CNWG010.aspx";
			}
		</script>
        <style type="text/css">
            .style_btnCansel
            {
            	z-index: 103;
            	left: 175px;
            	position: absolute;
            	top: 25px;
            	width: 674px;
            	height: 47px;
            	text-align: CENTER;
            	vertical-align: bottom;
            }
        </style>
	</HEAD>
	<body onselectstart="return false" <% Call GS_BodyWrite() %>>
		<form id="Form1" method="post" runat="server">
            <asp:label id="lbl_head" runat="server" Font-Size="22pt" Font-Names="ÇlÇr ÉSÉVÉbÉN" 
                BackColor="White" Font-Bold="True" BorderStyle="Outset" ReadOnly="True" 
                CssClass="style_btnCansel"></asp:label>
			<p></p>
			<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 110px">
				<TR height="88">
					<TD style="width:50%" align="middle"><asp:button id="btn_1" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
					<TD style="width:50%"  align="middle"><asp:button id="btn_6" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
				</TR>
				<TR height="88">
					<TD align="middle"><asp:button id="btn_2" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
					<TD align="middle"><asp:button id="btn_7" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
				</TR>
				<TR height="88">
					<TD align="middle"><asp:button id="btn_3" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
					<TD align="middle"><asp:button id="btn_8" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
				</TR>
				<TR height="88">
					<TD align="middle"><asp:button id="btn_4" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
					<TD align="middle"><asp:button id="btn_9" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
				</TR>
				<TR height="88">
					<TD align="middle"><asp:button id="btn_5" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
					<TD align="middle"><asp:button id="btn_10" runat="server" Font-Size="X-Large" Height="80" Width="384" Text="ÇmÇmÇmÇmÇmÇmÇmÇmÇmÇm"></asp:button></TD>
				</TR>
				<TR height="6">
					<TD></TD>
				</TR>
			</TABLE>
<%--			<HR width="100%">--%>
			<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 630px">
				<TR height="10">
					<TD colSpan="3"><FONT face="MS UI Gothic"></FONT></TD>
				</TR>
				<TR>
					<TD align="middle"><asp:button id="btn_Prev" runat="server" Font-Size="X-Large" Height="65" Width="180" Text="ëOÇÃÇPÇOåè"></asp:button></TD>
					<TD align="middle"><asp:button id="btn_Next" runat="server" Font-Size="X-Large" Height="65" Width="180" Text="éüÇÃÇPÇOåè"></asp:button></TD>
					<td align=center><input type=button value="ñﬂÇÈ" style="FONT-SIZE: x-large; width:180px; height:65px;" onclick="fRefBack();"></td>
				</TR>
			</TABLE>
			<IFRAME style="Z-INDEX: 101; LEFT: 320px; VISIBILITY: hidden; POSITION: absolute; TOP: 225px" name="F_CNWG100" src="about:blank" frameborder="0" width="384" scrolling="no" height="256">
			</IFRAME>
		</form>
	</body>
</HTML>
