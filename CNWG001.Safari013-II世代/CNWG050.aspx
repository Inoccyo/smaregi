<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG050.aspx.vb" Inherits="CNWG001.CNWG050" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG050</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">

		    //iPad縦スクロールロック
		    document.addEventListener('touchmove', bindTouch, false);
		    function bindTouch(event) {
		        event.preventDefault();
		    }
//			function __doPostBack(eventTarget, eventArgument) {
//				document.Form1.txt_Msg.value      = "しばらくお待ち下さい．．．";
//				document.Form1.btn_true.disabled  = "true";
//				document.Form1.btn_false.disabled = "true";
//				var theform;
//				if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) {
//					theform = document.Form1;
//				} else {
//					theform = document.forms["Form1"];
//				}
//				theform.__EVENTTARGET.value = eventTarget.split("$").join(":");
//				theform.__EVENTARGUMENT.value = eventArgument;
//				theform.submit();
//			}
			function fChgPage(pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG020"].location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG020"].contentWindow.location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}
			function fChgPage2(pSEATID, pMENUID, pCOURSE, pGOODSCD) {
				//parent.frames["F_CNWG021"].location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
				parent.document.getElementsByTagName("iframe")["F_CNWG021"].contentWindow.location.href = "./CNWG040.aspx?SEATID=" + pSEATID + "&MENUID=" + pMENUID + "&COURSE=" + pCOURSE + "&GOODSCD=" + pGOODSCD;
			}

    		supportTouch = 'ontouchend' in document.documentElement;
    		eventTouchStart = supportTouch ? 'touchstart' : 'mousedown';
    		eventTouchEnd = supportTouch ? 'touchend' : 'mouseup';
			// iPadボタンイベント
			document.addEventListener(eventTouchEnd, function(e) {
			    var target = e.target;
			    switch (target.id) {
			        case 'btn_1':
			            document.Form1.txt_number.value = 1;
			            break;
			        case 'btn_2':
			            document.Form1.txt_number.value = 2;
			            break;
			        case 'btn_3':
			            document.Form1.txt_number.value = 3;
			            break;
			        case 'btn_4':
			            document.Form1.txt_number.value = 4;
			            break;
			        case 'btn_5':
			            document.Form1.txt_number.value = 5;
			            break;
			        case 'btn_6':
			            document.Form1.txt_number.value = 6;
			            break;
			        case 'btn_7':
			            document.Form1.txt_number.value = 7;
			            break;
			        case 'btn_8':
			            document.Form1.txt_number.value = 8;
			            break;
			        case 'btn_9':
			            document.Form1.txt_number.value = 9;
			            break;
			        case 'btn_0':
			            document.Form1.txt_number.value = 0;
			            break;
			        case 'btn_cls':
			            document.Form1.txt_number.value = "";
			            break;
			        case 'btn_back':
			            parent.fWinClose();
			            break;
			        case 'btn_Set':
			            fSubmit(target.id);
                       e.preventDefault();
                       e.stopPropagation();
			            break;
			    }
			}, false);

			// 決定ボタン押下時サブミット
			function fSubmit(id) {
			    document.location.href = "./CNWG050.aspx?SUBMITID=" + id + "&SEATID=" + getQuerystring("SEATID") + "&MENUID=" + getQuerystring("MENUID") + "&GOODSCD=" + getQuerystring("GOODSCD") + "&NUMBER=" + document.Form1.txt_number.value;
			}
			
			function getQuerystring(key, default_) {
			    if (default_ == null) default_ = "";
			    key = key.replace(/[\[]/, "\\\[").replace(/[\]]/, "\\\]");
			    var regex = new RegExp("[\\?&]" + key + "=([^&#]*)");
			    var qs = regex.exec(window.location.href);
			    if (qs == null)
			        return default_;
			    else
			        return qs[1];
			}
		</script>
		
	    <style type="text/css">
            .style1
            {
                width: 72px;
            }
            .style2
            {
                z-index: 110;
                left: 2px;
                position: absolute;
                top: 80px;
            }
            .style3
            {
                z-index: 110;
                left: 87px;
                position: absolute;
                top: 80px;
                right: 1396px;
            }
            .style4
            {
                z-index: 110;
                left: 172px;
                position: absolute;
                top: 80px;
            }
            .style5
            {
                z-index: 110;
                left: 257px;
                position: absolute;
                top: 80px;
            }
            .style6
            {
                z-index: 110;
                left: 342px;
                position: absolute;
                top: 80px;
                right: 1141px;
            }
            .style7
            {
                z-index: 110;
                left: 427px;
                position: absolute;
                top: 80px;
            }
            .style8
            {
                z-index: 110;
                left: 512px;
                position: absolute;
                top: 80px;
            }
            .style9
            {
                z-index: 110;
                left: 597px;
                position: absolute;
                top: 80px;
            }
            .style10
            {
                z-index: 110;
                left: 682px;
                position: absolute;
                top: 80px;
            }
            .style11
            {
                z-index: 109;
                left: 767px;
                position: absolute;
                top: 80px;
            }
            .style12
            {
                z-index: 110;
                left: 852px;
                position: absolute;
                top: 80px;
            }
            .style13
            {
                z-index: 110;
                left: 22px;
                position: absolute;
                top: 0px;
            }
            .style14
            {
                z-index: 100;
                left: 261px;
                width: 337px;
                position: absolute;
                top: -5px;
                height: 50px;
            }
        </style>
		
		
	</HEAD>
	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="#e5decc" onSelectStart='return false'>
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
				<asp:textbox id="txt_Seat" runat="server" 
                Height="62px" Font-Size="28pt" Font-Names="ＭＳ ゴシック" Width="200px" 
                BackColor="#e5decc" Font-Bold="True" BorderStyle="None" ForeColor="Black" 
                ReadOnly="True" CssClass="style13">901番席</asp:textbox>
				&nbsp;<table style="FONT-SIZE: 20pt; FONT-FAMILY: 'ＭＳ ゴシック'; " 
                height="62px" class="style14">
					<TR align="center">
						<TD valign="bottom" class="style1">
							<input type="text" readonly value="人数" 
                                style="text-align: center; background-color:#e5decc; border-style:None; font-family:ＭＳ ゴシック; font-size:28pt; font-weight:bold; height:62px; width:110px"/>
						</TD>
						<TD valign="bottom" width="200">
							<asp:textbox id="txt_number" runat="server" Height="32px" Font-Size="26pt" Font-Names="ＭＳ ゴシック" Width="70px" BackColor="#e5decc" Font-Bold="True" BorderStyle="None" style="height:62px;"></asp:textbox>
							<asp:textbox id="txt_unit" runat="server" Height="32px" Font-Size="24pt" style="height:62px;"
                                Font-Names="ＭＳ ゴシック" Width="80px" BackColor="#e5decc" Font-Bold="True" 
                                BorderStyle="None" ReadOnly="True">人</asp:textbox>
						</TD>
					</TR>
				</table>
				<asp:button id="btn_1" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="１" Font-Bold="True" CssClass="style2"></asp:button>
				<asp:button id="btn_2" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="２" Font-Bold="True" CssClass="style3"></asp:button>
				<asp:button id="btn_3" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="３" Font-Bold="True" CssClass="style4"></asp:button>
				<asp:button id="btn_4" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="４" Font-Bold="True" CssClass="style5"></asp:button>
				<asp:button id="btn_5" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="５" Font-Bold="True" CssClass="style6"></asp:button>
				<asp:button id="btn_6" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="６" Font-Bold="True" CssClass="style7"></asp:button>
				<asp:button id="btn_7" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="７" Font-Bold="True" CssClass="style8"></asp:button>
				<asp:button id="btn_8" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="８" Font-Bold="True" CssClass="style9"></asp:button>
				<asp:button id="btn_9" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="９" Font-Bold="True" CssClass="style10"></asp:button>
				<asp:button id="btn_0" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="０" Font-Bold="True" CssClass="style11"></asp:button>
				<asp:button id="btn_cls" runat="server" Height="48px" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="169px" Text="Ｃ" Font-Bold="True" CssClass="style12"></asp:button>
				<asp:button id="btn_back" 
                style="Z-INDEX: 101; LEFT: 852px; POSITION: absolute; TOP: 5px" runat="server" 
                Height="48px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="キャンセル" 
                Font-Bold="True"></asp:button>
				<input type="hidden" name="__EVENTTARGET">
				<input type="hidden" name="__EVENTARGUMENT">
			</FONT>
		    <p>
			<FONT face="ＭＳ ゴシック">
				<asp:button id="btn_Set" style="Z-INDEX: 102; LEFT: 660px; POSITION: absolute; TOP: 5px" runat="server" Height="48px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Width="169px" Text="決定" Font-Bold="True"></asp:button>
			</FONT>
		    </p>
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
