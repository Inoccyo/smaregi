<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG070.aspx.vb" Inherits="CNWG001.CNWG070" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG070</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">
		function FFrame(){
			try {
				document.all["F_CNWG060"].style.visibility = "visible";
			} catch(e) { }
		}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="Azure" onSelectStart='return false'>
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
				<table style="FONT-SIZE: 20pt; Z-INDEX: 100; LEFT: 115px; WIDTH: 240px; FONT-FAMILY: 'ＭＳ ゴシック'; POSITION: absolute; TOP: 30px; HEIGHT: 40px" height="40" width="240">
					<TR vAlign="middle">
						<TD align="left" width="80">
							<input type="text" readonly value="人数" style="text-align: center; background-color:#e5decc; border-style:None; font-family:ＭＳ ゴシック; font-size:24pt; font-weight:bold; height:36px; width:80px"/>
						</TD>
						<TD align="middle" width="160">
							<asp:textbox id="txt_number" runat="server" Height="28px" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Width="42px" BackColor="Azure" Font-Bold="True" BorderStyle="None"></asp:textbox>
							<asp:textbox id="txt_unit" runat="server" Height="28px" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Width="30px" BackColor="Azure" Font-Bold="True" BorderStyle="None">人</asp:textbox>
						</TD>
					</TR>
				</table>
				<asp:button id="btn_7" style="Z-INDEX: 110; LEFT: 65px; POSITION: absolute; TOP: 100px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="７" Font-Bold="True"></asp:button>
				<asp:button id="btn_8" style="Z-INDEX: 110; LEFT: 185px; POSITION: absolute; TOP: 100px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="８" Font-Bold="True"></asp:button>
				<asp:button id="btn_9" style="Z-INDEX: 110; LEFT: 305px; POSITION: absolute; TOP: 100px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="９" Font-Bold="True"></asp:button>
				<asp:button id="btn_4" style="Z-INDEX: 110; LEFT: 65px; POSITION: absolute; TOP: 160px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="４" Font-Bold="True"></asp:button>
				<asp:button id="btn_5" style="Z-INDEX: 110; LEFT: 185px; POSITION: absolute; TOP: 160px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="５" Font-Bold="True"></asp:button>
				<asp:button id="btn_6" style="Z-INDEX: 110; LEFT: 305px; POSITION: absolute; TOP: 160px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="６" Font-Bold="True"></asp:button>
				<asp:button id="btn_1" style="Z-INDEX: 110; LEFT: 65px; POSITION: absolute; TOP: 220px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="１" Font-Bold="True"></asp:button>
				<asp:button id="btn_2" style="Z-INDEX: 110; LEFT: 185px; POSITION: absolute; TOP: 220px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="２" Font-Bold="True"></asp:button>
				<asp:button id="btn_3" style="Z-INDEX: 110; LEFT: 305px; POSITION: absolute; TOP: 220px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="３" Font-Bold="True"></asp:button>
				<asp:button id="btn_0" style="Z-INDEX: 109; LEFT: 65px; POSITION: absolute; TOP: 280px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="100px" Text="０" Font-Bold="True"></asp:button>
				<asp:button id="btn_cls" style="Z-INDEX: 110; LEFT: 185px; POSITION: absolute; TOP: 280px" runat="server" Height="49px" Font-Size="20px" Font-Names="ＭＳ ゴシック" Width="220px" Text="Ｃ／ＡＣ" Font-Bold="True"></asp:button>
				<HR style="Z-INDEX: 102; LEFT: 10px; WIDTH: 450px; POSITION: absolute; TOP: 350px; HEIGHT: 3px; BACKGROUND-COLOR: gray" SIZE="3">
				<asp:button id="btn_Set" style="Z-INDEX: 102; LEFT: 66px; POSITION: absolute; TOP: 365px" runat="server" Height="43px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="159px" Text="決定" Font-Bold="True"></asp:button>
				<asp:button id="btn_back" style="Z-INDEX: 101; LEFT: 245px; POSITION: absolute; TOP: 365px" runat="server" Height="43px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="159px" Text="閉じる" Font-Bold="True"></asp:button>
			</FONT>
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
