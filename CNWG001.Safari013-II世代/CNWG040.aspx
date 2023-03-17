<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG040.aspx.vb" Inherits="CNWG001.CNWG040" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG040</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">
			function fChgPage(pURL, pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG020"].location.href = "./" + pURL + ".aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG020"].contentWindow.location.href = "./" + pURL + ".aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}
			function fChgPage2(pURL, pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG021"].location.href = "./" + pURL + ".aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG021"].contentWindow.location.href = "./" + pURL + ".aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}
		</script>
	</HEAD>

	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="powderblue" onSelectStart='return false'>
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
				<asp:textbox id="txt_Seat" style="Z-INDEX: 110; LEFT: 22px; POSITION: absolute; TOP: 55px" runat="server" Height="30px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="106px" BackColor="powderblue" Font-Bold="True" BorderStyle="None" ForeColor="Black">901番席</asp:textbox>
				<asp:label id="lbl_status" style="Z-INDEX: 110; LEFT: 282px; POSITION: absolute; TOP: 55px" runat="server" Height="30px" Font-Size="24pt" Font-Names="ＭＳ ゴシック" Width="123px" BackColor="powderblue" Font-Bold="True">お通し済み（15:00）</asp:label>
				<!--<asp:button id='btn_Normal' style="Z-INDEX: 101; LEFT: 91px; POSITION: absolute; TOP: 75px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="199px" Text="通常メニュー" Font-Bold="True"></asp:button>
				<asp:button id="btn_Course" style="Z-INDEX: 101; LEFT: 331px; POSITION: absolute; TOP: 75px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="199px" Text="コースメニュー" Font-Bold="True"></asp:button>-->
				<HR style="Z-INDEX: 102; LEFT: 6px; WIDTH: 614px; POSITION: absolute; TOP: 132px; HEIGHT: 5px; BACKGROUND-COLOR: gray" SIZE="3">
				<asp:button id="btn_Menu1" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 145px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称１" Font-Bold="True"></asp:button>
				<asp:button id="btn_Menu2" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 205px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称２" Font-Bold="True"></asp:button>
				<asp:button id="btn_Menu3" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 265px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称３" Font-Bold="True"></asp:button>
				<asp:button id="btn_Menu4" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 325px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称４" Font-Bold="True"></asp:button>
				<asp:button id="btn_Menu5" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 385px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称５" Font-Bold="True"></asp:button>
				<asp:Label id="lbl_Menu1" style="Z-INDEX: 101; LEFT: 555px; POSITION: absolute; TOP: 160px" runat="server" Height="53px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="70px" Text="" Font-Bold="True"></asp:Label>
				<asp:Label id="lbl_Menu2" style="Z-INDEX: 101; LEFT: 555px; POSITION: absolute; TOP: 220px" runat="server" Height="53px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="70px" Text="" Font-Bold="True"></asp:Label>
				<asp:Label id="lbl_Menu3" style="Z-INDEX: 101; LEFT: 555px; POSITION: absolute; TOP: 280px" runat="server" Height="53px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="70px" Text="" Font-Bold="True"></asp:Label>
				<asp:Label id="lbl_Menu4" style="Z-INDEX: 101; LEFT: 555px; POSITION: absolute; TOP: 340px" runat="server" Height="53px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="70px" Text="" Font-Bold="True"></asp:Label>
				<asp:Label id="lbl_Menu5" style="Z-INDEX: 101; LEFT: 555px; POSITION: absolute; TOP: 400px" runat="server" Height="53px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="70px" Text="" Font-Bold="True"></asp:Label>
				<asp:button id="btn_MenuID1" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 145px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ１"></asp:button>
				<asp:button id="btn_MenuID2" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 205px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ２"></asp:button>
				<asp:button id="btn_MenuID3" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 265px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ３"></asp:button>
				<asp:button id="btn_MenuID4" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 325px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ４"></asp:button>
				<asp:button id="btn_MenuID5" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 385px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ５"></asp:button>
				<asp:button id="btn_GOODSCD1" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 145px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ１"></asp:button>
				<asp:button id="btn_GOODSCD2" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 205px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ２"></asp:button>
				<asp:button id="btn_GOODSCD3" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 265px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ３"></asp:button>
				<asp:button id="btn_GOODSCD4" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 325px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ４"></asp:button>
				<asp:button id="btn_GOODSCD5" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 385px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ５"></asp:button>
				<asp:button id="btn_FreeDrinkMenuID1" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 145px" runat="server" Height="0px" Width="0px" Text="飲み放題メニューＩＤ１"></asp:button>
				<asp:button id="btn_FreeDrinkMenuID2" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 205px" runat="server" Height="0px" Width="0px" Text="飲み放題メニューＩＤ２"></asp:button>
				<asp:button id="btn_FreeDrinkMenuID3" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 265px" runat="server" Height="0px" Width="0px" Text="飲み放題メニューＩＤ３"></asp:button>
				<asp:button id="btn_FreeDrinkMenuID4" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 325px" runat="server" Height="0px" Width="0px" Text="飲み放題メニューＩＤ４"></asp:button>
				<asp:button id="btn_FreeDrinkMenuID5" style="Z-INDEX: 101; LEFT: 10px; POSITION: absolute; TOP: 385px" runat="server" Height="0px" Width="0px" Text="飲み放題メニューＩＤ５"></asp:button>
				<asp:button id="btn_Prev" style="Z-INDEX: 101; LEFT: 262px; POSITION: absolute; TOP: 463px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="前ページ" Font-Bold="True"></asp:button>
				<asp:button id="btn_Next" style="Z-INDEX: 101; LEFT: 442px; POSITION: absolute; TOP: 463px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="次ページ" Font-Bold="True"></asp:button>
				<asp:textbox id="txt_Msg" style="Z-INDEX: 103; LEFT: 69px; POSITION: absolute; TOP: 520px" runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="500px" BackColor="White" Font-Bold="True" BorderStyle="Outset" ReadOnly="True">NNN</asp:textbox>
				<HR style="Z-INDEX: 102; LEFT: 6px; WIDTH: 614px; POSITION: absolute; TOP: 575px; HEIGHT: 5px; BACKGROUND-COLOR: gray" SIZE="3">
				<asp:button id="btn_Set" style="Z-INDEX: 101; LEFT: 36px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="お通し" Font-Bold="True"></asp:button>
				<asp:button id="btn_Drink" style="Z-INDEX: 101; LEFT: 226px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="" Font-Bold="True"></asp:button>
				<asp:button id="btn_back" style="Z-INDEX: 101; LEFT: 416px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="閉じる" Font-Bold="True"></asp:button>
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
