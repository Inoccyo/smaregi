<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG032.aspx.vb" Inherits="CNWG001.CNWG032" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG032</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">

            parent.document.getElementById("map").style.visibility = "visible";		
		
			//iPad縦スクロールロック
            document.addEventListener('touchmove', bindTouch, false);
            function bindTouch(event) {
                event.preventDefault();
            }
		
            //IOS6.0フリック対応
		    document.addEventListener('touchend', function(e) {
                var target = e.target;
                var targetid = target.id;

                switch(targetid){
                    //ボタンタッチ
                    case "btn_0":
                        location.href = './CNWG032.aspx?UPDID=0';
                        break;                    
                    case "btn_1":
                        location.href = './CNWG032.aspx?UPDID=1';
                        break;
                    case "btn_2":
                        location.href = './CNWG032.aspx?UPDID=2';
                        break;
                    case "btn_3":
                        location.href = './CNWG032.aspx?UPDID=3';
                        break;
                    case "btn_4":
                        location.href = './CNWG032.aspx?UPDID=4';
                        break;    
                    case "btn_5":
                        location.href = './CNWG032.aspx?UPDID=5';
                        break;
                    case "btn_6":
                        location.href = './CNWG032.aspx?UPDID=6';
                        break;
                    case "btn_7":
                        location.href = './CNWG032.aspx?UPDID=7';
                        break;    
                    case "btn_8":
                        location.href = './CNWG032.aspx?UPDID=8';
                        break;                        
                    case "btn_9":
                        location.href = './CNWG032.aspx?UPDID=9';
                        break;
                    //決定ボタン      
                    case "btn_Set":
                        location.href = './CNWG032.aspx?SETFLG=1';
                        break;                          
                    //キャンセルボタン
                    case "btn_back":
                        parent.fWinClose();
                        break;
                    //クリアボタン
                    case "btn_cls":
                        location.href = './CNWG032.aspx?UPDID=10';
                        break;
                    case "":
                        event.preventDefault();
                        break;                                                                                                                                                 
                    default:
                        break;
                }
            }, false);			
			
			function noBack() {
                return false;
            } 			
		
		
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
		</script>

	    <style type="text/css">
            .style1{width: 72px;}
            .style2{z-index: 110;left: 15px;
position: absolute;top: 91px;
                height: 64px;
            }
            .style3{z-index: 110;left: 107px;
position: absolute;top: 91px;
right: 912px;
                height: 63px;
            }
            .style4{z-index: 110;left: 196px;
position: absolute;top: 91px;
                height: 64px;
            }
            .style5{z-index: 110;left: 284px;
position: absolute;top: 91px;
                height: 64px;
                margin-right: 0px;
            }
            .style6{z-index: 110;left: 373px;
position: absolute;top: 91px;
right: 646px;
                height: 64px;
            }
            .style7{z-index: 110;left: 462px;
position: absolute;top: 91px;
                height: 65px;
            }
            .style8{z-index: 110;left: 551px;
position: absolute;top: 92px;
                height: 65px;
            }
            .style9{z-index: 110;left: 639px;
position: absolute;top: 92px;
                height: 64px;
            }
            .style10{z-index: 110;left: 729px;
position: absolute;top: 91px;
                height: 64px;
            }
            .style11{z-index: 109;left: 819px;
position: absolute;top: 91px;
                height: 65px;
            }
            .style12{z-index: 110;left: 918px;
position: absolute;top: 91px;
                width: 103px;
                height: 64px;
            }
            .style13{z-index: 110;left: 22px;position: absolute;top: 0px;}
            .style14{z-index: 100;left: 261px;width: 337px;position: absolute;top: -5px;height: 50px;}
            .style15{height: 30px;}
        </style>
		
	</HEAD>
	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="#e5decc" onSelectStart='return false' onload="parent.ClearReflexive();">
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
			<asp:label id="lbl_Seat" 
                style="Z-INDEX: 510; LEFT: 12px; POSITION: absolute; TOP: 15px; height: 33px; left: 18px; width: 475px;" 
                runat="server" Font-Size="20pt" Font-Names="ＭＳ ゴシック" 
                BackColor="#e5decc" Font-Bold="True" BorderStyle="None" ForeColor="Black">移動先の座席番号を入力して下さい</asp:label>
			&nbsp;
<%--			<table style="FONT-SIZE: 16pt; Z-INDEX: 100; LEFT: 513px; WIDTH: 140px; FONT-FAMILY: 'ＭＳ ゴシック'; POSITION: absolute; TOP: 12px; HEIGHT: 42px">
				<tr align="center">
					<td valign="top" width="60px" class="style15">
						<asp:label id="lbl_number111" runat="server" Font-Size="24pt" Font-Names="ＭＳ ゴシック" 
                            Width="60px" BackColor="#E5DECC" Font-Bold="True" BorderStyle="None"></asp:label>
					</td>
					<td valign="top" width="80px" class="style15">
						<asp:label id="Label222" runat="server"  Font-Size="24pt" Font-Names="ＭＳ ゴシック" Width="80px" BackColor="#e5decc" Font-Bold="True" BorderStyle="None">番席</asp:label>
					</td>
				</tr>
			</table>--%>
			
			<div style="Z-INDEX: 100; TOP: 15px; LEFT: 551px; WIDTH: 140px; POSITION: absolute;">
				<asp:label id="lbl_number" runat="server" Font-Size="28pt" Font-Names="ＭＳ ゴシック" 
                    Width="60px" BackColor="#E5DECC" Font-Bold="True" BorderStyle="None"></asp:label>
			</div>
			
			<div style="Z-INDEX: 101; TOP: 12px; LEFT: 613px; WIDTH: 140px; POSITION: absolute;">
				<asp:label id="Label2" runat="server"  Font-Size="24pt" Font-Names="ＭＳ ゴシック" 
				    Width="80px" BackColor="#e5decc" Font-Bold="True" BorderStyle="None">番席</asp:label>

			</div>
			
				<asp:button id="btn_1" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="１" Font-Bold="True" 
                CssClass="style2"></asp:button>
				<asp:button id="btn_2" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="２" Font-Bold="True" 
                CssClass="style3"></asp:button>
				<asp:button id="btn_3" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="３" Font-Bold="True" 
                CssClass="style4"></asp:button>
				<asp:button id="btn_4" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="４" Font-Bold="True" 
                CssClass="style5"></asp:button>
				<asp:button id="btn_5" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="５" Font-Bold="True" 
                CssClass="style6"></asp:button>
				<asp:button id="btn_6" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="６" Font-Bold="True" 
                CssClass="style7"></asp:button>
				<asp:button id="btn_7" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="７" Font-Bold="True" 
                CssClass="style8"></asp:button>
				<asp:button id="btn_8" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="８" Font-Bold="True" 
                CssClass="style9"></asp:button>
				<asp:button id="btn_9" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="９" Font-Bold="True" 
                CssClass="style10"></asp:button>
				<asp:button id="btn_0" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Width="84px" Text="０" Font-Bold="True" 
                CssClass="style11"></asp:button>
				<asp:button id="btn_cls" runat="server" Font-Size="26px" 
                Font-Names="ＭＳ ゴシック" Text="Ｃ" Font-Bold="True" CssClass="style12"></asp:button>
				<asp:button id="btn_back" 
                
                style="Z-INDEX: 101; LEFT: 887px; POSITION: absolute; TOP: 5px; width: 134px;" runat="server" 
                Height="60px" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Text="キャンセル" 
                Font-Bold="True"></asp:button>
				<input type="hidden" name="__EVENTTARGET">
				<input type="hidden" name="__EVENTARGUMENT">
			</FONT>
		    <p>
			<FONT face="ＭＳ ゴシック">
				<asp:button id="btn_Set" 
                    style="Z-INDEX: 102; LEFT: 733px; POSITION: absolute; TOP: 6px; width: 133px;" 
                    runat="server" Height="60px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Text="決定" 
                    Font-Bold="True"></asp:button>
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
