<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG060.aspx.vb" Inherits="CNWG001.CNWG060" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG060</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">
			function __doPostBack(eventTarget, eventArgument) {
				document.Form1.txt_Msg.value      = "しばらくお待ち下さい．．．";
				document.Form1.btn_true.disabled  = "true";
				document.Form1.btn_false.disabled = "true";
				var theform;
				if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) {
					theform = document.Form1;
				} else {
					theform = document.forms["Form1"];
				}
				theform.__EVENTTARGET.value = eventTarget.split("$").join(":");
				theform.__EVENTARGUMENT.value = eventArgument;
				theform.submit();
			}
			function fChgPage(pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG020"].location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG020"].contentWindow.location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}
			function fChgPage2(pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG021"].location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG021"].contentWindow.location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}
			//「決定」、「閉じる」ボタン押下時処理
			function fWinClose(){
				document.all["F_CNWG060"].style.visibility = "hidden";
			}
		</script>
	</HEAD>

	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="powderblue" onSelectStart='return false'>
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
				<asp:textbox id="txt_Seat" style="Z-INDEX: 110; LEFT: 22px; POSITION: absolute; TOP: 15px" runat="server" Height="27px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="106px" BackColor="powderblue" Font-Bold="True" BorderStyle="None" ForeColor="Black">901番席</asp:textbox>
				<asp:label id="lbl_status" style="Z-INDEX: 110; LEFT: 282px; POSITION: absolute; TOP: 15px" runat="server" Height="27px" Font-Size="24pt" Font-Names="ＭＳ ゴシック" Width="123px" BackColor="powderblue" Font-Bold="True">お通し済み（15:00）</asp:label>
				<span style="background-color:powderblue; font-family:ＭＳ ゴシック; font-size:15pt; font-weight:bold; height:27px; width:185px; Z-INDEX: 110; LEFT: 6px; POSITION: absolute; TOP: 58px">【選択メニュー】</span>
				<asp:label id="lbl_MenuNM" style="Z-INDEX: 101; LEFT: 192px; POSITION: absolute; TOP: 60px" runat="server" Height="24px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="458px" Font-Bold="True" BackColor="powderblue">選択メニュー：NNNNNNNNNN</asp:label>
				<asp:textbox id="txt_Main" style="Z-INDEX: 110; LEFT: 6px; POSITION: absolute; TOP: 103px" runat="server" Height="27px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="235px" BackColor="powderblue" Font-Bold="True" BorderStyle="None" ForeColor="Black">飲み放題メインコース</asp:textbox>
				<asp:textbox id="txt_Sub" style="Z-INDEX: 110; LEFT: 6px; POSITION: absolute; TOP: 365px" runat="server" Height="27px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="235px" BackColor="powderblue" Font-Bold="True" BorderStyle="None" ForeColor="Black">飲み放題サブコース</asp:textbox>
				<asp:button id="btn_MMenu1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 132px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称１" Font-Bold="True"></asp:button>
				<asp:button id="btn_MMenu2" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 192px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称２" Font-Bold="True"></asp:button>
				<asp:button id="btn_MMenu3" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 252px" runat="server" Height="53px" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="534px" Text="メニュー名称３" Font-Bold="True"></asp:button>
				<asp:button id="btn_SMenu1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 393px" runat="server" Height="63px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="244px" Text="メニュー名称４" Font-Bold="True"></asp:button>
				<asp:button id="btn_SMenu2" style="Z-INDEX: 101; LEFT: 336px; POSITION: absolute; TOP: 393px" runat="server" Height="63px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="244px" Text="メニュー名称５" Font-Bold="True"></asp:button>
				<asp:button id="btn_MMenuID1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 132px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ１"></asp:button>
				<asp:button id="btn_MMenuID2" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 192px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ２"></asp:button>
				<asp:button id="btn_MMenuID3" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 252px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ３"></asp:button>
				<asp:button id="btn_SMenuID1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 312px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ４"></asp:button>
				<asp:button id="btn_SMenuID2" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 372px" runat="server" Height="0px" Width="0px" Text="メニューＩＤ５"></asp:button>
				<asp:button id="btn_SGOODSCD1" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 312px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ４"></asp:button>
				<asp:button id="btn_SGOODSCD2" style="Z-INDEX: 101; LEFT: 46px; POSITION: absolute; TOP: 372px" runat="server" Height="0px" Width="0px" Text="商品ＩＤ５"></asp:button>
				<asp:button id="btn_Prev" style="Z-INDEX: 101; LEFT: 262px; POSITION: absolute; TOP: 315px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="前ページ" Font-Bold="True"></asp:button>
				<asp:button id="btn_Next" style="Z-INDEX: 101; LEFT: 442px; POSITION: absolute; TOP: 315px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="次ページ" Font-Bold="True"></asp:button>
				<asp:textbox id="txt_number1" style="Z-INDEX: 111; LEFT: 141px; POSITION: absolute; TOP: 473px"  runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="42px" BackColor="powderblue" Font-Bold="True" BorderStyle="None">888</asp:textbox>
				<asp:textbox id="txt_unit1" style="Z-INDEX: 110; LEFT: 81px; POSITION: absolute; TOP: 473px"  runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="170px" BackColor="powderblue" Font-Bold="True" BorderStyle="None">【        人】</asp:textbox>
				<asp:textbox id="txt_number2" style="Z-INDEX: 111; LEFT: 431px; POSITION: absolute; TOP: 473px"  runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="42px" BackColor="powderblue" Font-Bold="True" BorderStyle="None">999</asp:textbox>
				<asp:textbox id="txt_unit2" style="Z-INDEX: 110; LEFT: 371px; POSITION: absolute; TOP: 473px"  runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="170px" BackColor="powderblue" Font-Bold="True" BorderStyle="None">【        人】</asp:textbox>
				<input type="hidden" name="__EVENTTARGET">
				<input type="hidden" name="__EVENTARGUMENT">
				<asp:textbox id="txt_Msg" style="Z-INDEX: 103; LEFT: 69px; POSITION: absolute; TOP: 520px" runat="server" Height="32px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="500px" BackColor="White" Font-Bold="True" BorderStyle="Outset" ReadOnly="True">NNN</asp:textbox>
				<HR style="Z-INDEX: 102; LEFT: 6px; WIDTH: 614px; POSITION: absolute; TOP: 575px; HEIGHT: 5px; BACKGROUND-COLOR: gray" SIZE="3">
				<asp:button id="btn_Set" style="Z-INDEX: 101; LEFT: 36px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="決定" Font-Bold="True"></asp:button>
				<asp:button id="btn_Prev2" style="Z-INDEX: 101; LEFT: 226px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="戻る" Font-Bold="True"></asp:button>
				<asp:button id="btn_back" style="Z-INDEX: 101; LEFT: 416px; POSITION: absolute; TOP: 600px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="閉じる" Font-Bold="True"></asp:button>
				<asp:table id="tbl_Confirm" style="Z-INDEX: 120; LEFT: 133px; POSITION: absolute; TOP: 200px" runat="server" BackColor="Azure" width="373px" height="188px" BorderColor="Navy" BorderWidth="2px">
					<asp:TableRow>
						<asp:TableCell Text="　"></asp:TableCell>
					</asp:TableRow>
				</asp:table>
				<asp:label id="lbl_Confirm" style="Z-INDEX: 121; LEFT: 166px; POSITION: absolute; TOP: 238px" runat="server" Height="21px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="333px" BackColor="Azure" Font-Bold="True">お通しします</asp:label>
				<asp:button id="btn_true" style="Z-INDEX: 121; LEFT: 168px; POSITION: absolute; TOP: 302px" runat="server" Height="70px" Font-Size="17pt" Font-Names="ＭＳ ゴシック" Width="140px" Text="はい" Font-Bold="True"></asp:button>
				<asp:button id="btn_false" style="Z-INDEX: 121; LEFT: 333px; POSITION: absolute; TOP: 302px" runat="server" Height="70px" Font-Size="17pt" Font-Names="ＭＳ ゴシック" Width="140px" Text="いいえ" Font-Bold="True"></asp:button>
			</FONT>
		<% LS_IframeWrite %>
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
