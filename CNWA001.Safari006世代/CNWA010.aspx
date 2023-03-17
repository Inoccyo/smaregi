<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWA010.aspx.vb" Inherits="CNWA001.CNWA010" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>
	<head>
		<title>CNWA010</title>
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
	    <meta content="False" name="vs_showGrid"/>
	    <meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR"/>
	    <meta content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
	    <meta content="JavaScript" name="vs_defaultClientScript"/>
	    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
	    <script language="JavaScript" type="text/javascript">
		    var id;
		    function FStart(interval,termkind){
			    // 10秒ごとに 当関数を再帰呼び出しする
			    var strReload;
			    strReload = "fTimerReload('" + termkind + "');"
			    id = setTimeout(strReload, interval);
		    }
//		    function fTimerReload(termkind){
//			    // リロード処理を行う
//			    switch(termkind){
//				    case "TCA":location.href = "/CNWH001/CNWH010.aspx";break;
//				    case "TCB":location.href = "/CNWH002/CNWH010.aspx";break;
//				    case "TC0":location.href = "/CNWI001/CNWI010.aspx";break;
//			    	case "TC1":location.href = "/CNWC001/CNWC010.aspx";break;
//			    	case "TC2":location.href = "/CNWC002/CNWC010.aspx";break;
//			    	case "TC3":location.href = "/CNWC003/CNWC010.aspx";break;
//			    	case "TC4":location.href = "/CNWC004/CNWC010.aspx";break;
//			    	case "TC5":location.href = "/CNWC005/CNWC010.aspx";break;
//			    	case "TC6":location.href = "/CNWC006/CNWC010.aspx";break;
//			    	case "TC6":location.href = "/CNWC007/CNWC010.aspx";break;
//			    	case "TC7":location.href = "/CNWQ002/CNWQ030.aspx";break;
//				    case "TC8":location.href = "/CNWD008/CNWD030.aspx";break;
//				    case "TC9":location.href = "/CNWG001/CNWG010.aspx";break;
//				    case "TCQ":location.href = "/CNWQ001/CNWQ030.aspx";break;
//				    case "TCT":location.href = "/CNWT001/CNWT010.aspx";break;
//				    case "TCS":location.href = "/CNWS001/CNWS010.aspx";break;
//				    case "TCU":location.href = "/CNWQ003/CNWQ030.aspx";break;
//				    default:location.href = "./CNWA010.aspx";break;
//			    }
//		    }
		    function FStop(){
			    // タイマーの停止
			    clearTimeout(id);
			}
	    </script>
	    <% JSWrite()%>
	</head>
	<% LS_BodyWrite %>
	<form method="post" runat="server" ID="Form1">
		<!-- 画面サイズによって表示位置変更　top: 8px; height: 31px -->
		<table align="center">
			<tr>
				<td>
					<table style="COLOR:#2c1213; FONT-WEIGHT: bold; FONT-SIZE: 24pt; Z-INDEX: 103; FONT-FAMILY: 'ＭＳ ゴシック'; TOP: 125px" cellspacing="2" align="center">
						<tr>
							<td align="center">画面表示中です。</td>
						</tr>
						<tr>
							<td align="center">このままお待ち下さい。</td>
						</tr>
					</table>
					<br/><br/><br/><br/>
					<table style="FONT-WEIGHT: bold; FONT-SIZE: 24pt; Z-INDEX: 103; FONT-FAMILY: 'ＭＳ ゴシック'; TOP: 125px" cellspacing="2" align="center">
						<tr>
							<td align="center"><asp:button id="btn_Next" runat="server" width="129px" height="80px" font-names="ＭＳ ゴシック" forecolor="white" font-size="12pt" font-bold="True" text="メニュー表示" backcolor="#dc3632"></asp:button></td>
						</tr>
					</table>
					<br/><br/><br/><br/>
					<!-- 画面サイズにより、表示位置変更 -->
					<table style="FONT-WEIGHT: bold; FONT-SIZE: 24pt; Z-INDEX: 103; FONT-FAMILY: 'ＭＳ ゴシック'; TOP: 125px" cellspacing="" align="center">
						<tr>
							<td width="640">
								<table style="COLOR:#2c1213; FONT-WEIGHT: bold; FONT-SIZE: 11pt; WIDTH: 613px; HEIGHT: 120px; border-bottom-style: none; border-bottom-width: 0px;" cellspacing="0" cellpadding="1" border="1">
									<tr>
										<td style="WIDTH: 200px" align="center"><font size="5">画面</font>&nbsp;</td>
										<td align="center"><asp:label id="lbl_status" runat="server" font-size="16pt" font-names="ＭＳ ゴシック">画面名</asp:label></td>
									</tr>
									<tr>
										<td style="WIDTH: 200px" align="center"><font size="5"><asp:label id="lbl_SeatName" runat="server">座席</asp:label></font>&nbsp;</td>
										<td align="center"><asp:label id="lbl_SeatId" runat="server" font-size="16pt" font-names="ＭＳ ゴシック">01</asp:label></td>
									</tr>
								</table>
                            	<asp:Panel id="pnl_IP" runat="server" visible="False">
								<table style="COLOR:#2c1213; FONT-WEIGHT: bold; FONT-SIZE: 11pt; WIDTH: 613px; HEIGHT: 60px; border-top-style: none; border-top-width: 0px;" cellspacing="0" cellpadding="1" border="1">
									    <tr>
										    <td style="WIDTH: 200px" align="center"><font size="5">IPアドレス</font>&nbsp;</td>
										    <td align="center"><asp:label id="lbl_IP" runat="server" font-size="16pt" font-names="ＭＳ ゴシック">192.168.194.101</asp:label></td>
									    </tr>
								</table>
                                </asp:Panel>
							</td>
						</tr>
					</table>
				</td>
			</tr>
		</table>
	</form>
	
	
	<script type="text/javascript" src="jquery-3.1.1.min.js"></script>
    <script type="text/javascript">
	    $(function(){
		    $('a').click(function(){
			    location.href = $(this).attr('href');
			    return false;
		    });
	    });
    </script>
	
	<% LS_IframeWrite %>
</html>
