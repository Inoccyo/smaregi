<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG031.aspx.vb" Inherits="CNWG001.CNWG031" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG031</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.0">
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript">
			// 「決定」ボタン押下時処理
			function fSetValue(pUrl,pNo) {
				//parent.frames["F_CNWL020"].location.href = pUrl + "?SEATID=" + pNo + "&MODE=1";
				parent.document.getElementsByTagName("iframe")["F_CNWL020"].contentWindow.location.href = pUrl + "?SEATID=" + pNo + "&MODE=1";
				parent.document.all["F_CNWL020"].style.visibility = "visible";
				parent.ClearReflexive();
			}
		</script>
	</HEAD>
	<% BodyWrite() %>
	<form id="F_CNWG031" method="post" runat="server">
		<table border='0' cellspacing='3' cellpadding='0' width='100%' height='100%' bgcolor="#8080ff">
			<tr>
				<td>
					<table border='0' cellspacing='0' cellpadding='0' width='100%' height='100%' bgcolor='lightblue'>
						<tr>
							<td align="middle">
								<asp:Label id="lbl_Msg1" runat="server" Font-Size="Large">Label1</asp:Label><br>
								<asp:Label id="lbl_Msg2" runat="server" Font-Size="Large">Label2</asp:Label><br>
								<asp:Label id="lbl_Msg3" runat="server" Font-Size="Large">Label3</asp:Label>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
		<asp:button id="btn_Dummy" style="Z-INDEX: 100; LEFT: 1px; POSITION: absolute; TOP: 1px" runat="server" Text="Button" Width="0px" Height="0px"></asp:button>
	</form>
	</body>
	
	
	<script type="text/javascript" src="jquery-3.1.1.min.js"></script>
    <script type="text/javascript">
	    $(function(){
		    $('a').click(function(){
			    location.href = $(this).attr('href');
			    return false;
		    });
	    });
    </script>
	
</HTML>
