<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG022.aspx.vb" Inherits="CNWG001.CNWG022" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG022</title>
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript">
			var TimerId;

			function fReload(){
				// リロード処理を行う
				location.href = "./CNWG010.aspx";
			}

			// 「戻る」ボタン、「お会計」ボタン押下時処理
			function fWinClose(){
				document.all["F_CNWG021"].style.visibility = "hidden";
				fReload();
			}
			
			// テーブル位置設定時処理
			function fSetValue(){
				var retobj = location.search.substr(12,7);			
				parent.document.all[retobj].value = document.forms[0].txt_Pos.value;
				parent.document.all[retobj].focus();
				fWinClosePos();
			}
			
			// 端末設定からの遷移時、テーブル選択処理
			function fWinClosePos(){
				parent.document.all["F_CNWG010"].style.visibility = "hidden";
			}
			
			/**
			 *	一定時間間隔で、自分自身を再呼び出しする。
			 *	2005/03 作成 ソラン北陸
			 **/
			 function Reflexive() {
				TimerId = setTimeout("top.location.href='./CNWG010.aspx';Reflexive();",60000);
			}

			/**
			 *	マイナス画面への遷移時は再呼び出しをクリアする。
			 *	2006/06/02 作成 ソラン北陸
			 **/
			 function ClearReflexive() {
				clearTimeout(TimerId);
			}

			var bcolor1;
			var bcolor2;
			var bcolor3;
			var bcolor4;
			var bcolor5;
			var fcolor1;
			var fcolor2;
			var fcolor3;
			var fcolor4;
			var fcolor5;
			bcolor1 = "";
			bcolor2 = "";
			bcolor3 = "";
			bcolor4 = "";
			bcolor5 = "";
			fcolor1 = "";
			fcolor2 = "";
			fcolor3 = "";
			fcolor4 = "";
			fcolor5 = "";
			
			function fAlert1(){
				if(bcolor1.length == 0 || bcolor1 == "#D4D0C8"){
					bcolor1 = "yellow";
					fcolor1 = "black";
				}else{
					bcolor1 = "#D4D0C8";
					fcolor1 = "white";
				}
				document.Form1.btn_table1.style.backgroundColor = bcolor1;
				document.Form1.btn_table1.style.color = fcolor1;
				setTimeout("fAlert1()", 500);
			}
			
			function fAlert2(){
				if(bcolor2.length == 0 || bcolor2 == "#D4D0C8"){
					bcolor2 = "yellow";
					fcolor2 = "black";
				}else{
					bcolor2 = "#D4D0C8";
					fcolor2 = "white";
				}
				document.Form1.btn_table2.style.backgroundColor = bcolor2;
				document.Form1.btn_table2.style.color = fcolor2;
				setTimeout("fAlert2()", 500);
			}
			
			function fAlert3(){
				if(bcolor3.length == 0 || bcolor3 == "#D4D0C8"){
					bcolor3 = "yellow";
					fcolor3 = "black";
				}else{
					bcolor3 = "#D4D0C8";
					fcolor3 = "white";
				}
				document.Form1.btn_table3.style.backgroundColor = bcolor3;
				document.Form1.btn_table3.style.color = fcolor3;
				setTimeout("fAlert3()", 500);
			}
			
			function fAlert4(){
				if(bcolor4.length == 0 || bcolor4 == "#D4D0C8"){
					bcolor4 = "yellow";
					fcolor4 = "black";
				}else{
					bcolor4 = "#D4D0C8";
					fcolor4 = "white";
				}
				document.Form1.btn_table4.style.backgroundColor = bcolor4;
				document.Form1.btn_table4.style.color = fcolor4;
				setTimeout("fAlert4()", 500);
			}
			
			function fAlert5(){
				if(bcolor5.length == 0 || bcolor5 == "#D4D0C8"){
					bcolor5 = "yellow";
					fcolor5 = "black";
				}else{
					bcolor5= "#D4D0C8";
					fcolor5 = "white";
				}
				document.Form1.btn_table5.style.backgroundColor = bcolor5;
				document.Form1.btn_table5.style.color = fcolor5;
				setTimeout("fAlert5()", 500);
			}

			function fAlert(pPOSITION){
				switch (pPOSITION) {
					case 11:
						fAlert1();
						break;
					case 12:
						fAlert2();
						break;
					case 13:
						fAlert3();
						break;
					case 14:
						fAlert4();
						break;
					case 15:
						fAlert5();
						break;
					default:
						break;
				}
			}
			
			function fChangeKyakuAP(){
				setTimeout("fTimerload()", 1000);
			}

			function fTimerload(){
				// 客席端末へ遷移
				top.location.href = "/CNWJ001/CNWJ010.aspx";
			}
			
		</script>
	</HEAD>
	<body onselectstart="return false" bgColor="white" onload="Reflexive(); <% GF_Check_SPMENU2 %>" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="ＭＳ ゴシック">
				<TABLE id="Table4" style="Z-INDEX: 133; LEFT: 214px; WIDTH: 795px; POSITION: absolute; TOP: 88px; HEIGHT: 10px" bgColor="#66ffff">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>
				<asp:button id="btn_table10" style="Z-INDEX: 132; LEFT: 207px; POSITION: absolute; TOP: 480px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="１０"></asp:button><asp:button id="btn_table9" style="Z-INDEX: 131; LEFT: 59px; POSITION: absolute; TOP: 478px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="９"></asp:button><asp:button id="btn_table8" style="Z-INDEX: 130; LEFT: 641px; POSITION: absolute; TOP: 236px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="８"></asp:button><asp:button id="btn_table7" style="Z-INDEX: 129; LEFT: 496px; POSITION: absolute; TOP: 234px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="７"></asp:button><asp:table id="table_10" style="Z-INDEX: 128; LEFT: 195px; POSITION: absolute; TOP: 471px" runat="server" BackColor="blue" width="128" height="87">
					<asp:TableRow>
						<asp:TableCell Text="　"></asp:TableCell>
					</asp:TableRow>
				</asp:table><asp:table id="table_9" style="Z-INDEX: 127; LEFT: 46px; POSITION: absolute; TOP: 469px" runat="server" BackColor="blue" width="128" height="87">
					<asp:TableRow>
						<asp:TableCell Text="　"></asp:TableCell>
					</asp:TableRow>
				</asp:table><asp:table id="table_8" style="Z-INDEX: 126; LEFT: 628px; POSITION: absolute; TOP: 226px" runat="server" BackColor="blue" width="128" height="87">
					<asp:TableRow>
						<asp:TableCell Text="　"></asp:TableCell>
					</asp:TableRow>
				</asp:table><asp:table id="table_7" style="Z-INDEX: 125; LEFT: 483px; POSITION: absolute; TOP: 225px" runat="server" BackColor="blue" width="128" height="87">
					<asp:TableRow>
						<asp:TableCell Text="　"></asp:TableCell>
					</asp:TableRow>
				</asp:table>
				<!--<TABLE id="Table3" style="Z-INDEX: 124; LEFT: 33px; WIDTH: 435px; POSITION: absolute; TOP: 274px; HEIGHT: 25px" bgColor="#3300cc">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>
				<TABLE id="Table2" style="Z-INDEX: 122; LEFT: 696px; WIDTH: 10px; POSITION: absolute; TOP: 86px; HEIGHT: 63px" bgColor="#66ffff">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>-->
				<!--<asp:button id="btn_back" style="Z-INDEX: 121; LEFT: 511px; POSITION: absolute; TOP: 668px" runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Height="51px" Width="121px" Text="戻る"></asp:button>-->
				<!--<asp:button id="btn_TPJ" style="Z-INDEX: 121; LEFT: 511px; POSITION: absolute; TOP: 668px" runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Height="51px" Width="121px" Text="注文"></asp:button>-->
				<% BTN_WRITE() %>
				<asp:button id="btn_Change" style="Z-INDEX: 121; LEFT: 633px; POSITION: absolute; TOP: 668px" runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Height="51px" Width="121px" Text="切替"></asp:button>
				<!--
				<TABLE id="Table7" style="Z-INDEX: 111; LEFT: 111px; WIDTH: 10px; POSITION: absolute; TOP: 153px; HEIGHT: 499px" bgColor="#66ffff">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>
				<TABLE id="Table4" style="Z-INDEX: 127; LEFT: 328px; WIDTH: 668px; POSITION: absolute; TOP: 444px; HEIGHT: 50px" bgColor="#000066">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>
				
				<TABLE id="Table6" style="Z-INDEX: 101; LEFT: 353px; WIDTH: 10px; POSITION: absolute; TOP: 380px; HEIGHT: 272px" bgColor="#66ffff">
					<TR>
						<TD><FONT face="MS UI Gothic"></FONT></TD>
					</TR>
				</TABLE>
				--></FONT> 
			<!--
			<table style="Z-INDEX: 110; LEFT: 33px; WIDTH: 435px; POSITION: absolute; TOP: 243px; HEIGHT: 25px" bgColor="#3300cc">
				<tr>
					<td><FONT face="MS UI Gothic"></FONT></td>
				</tr>
			</table>
			-->
			<HR style="Z-INDEX: 102; LEFT: 16px; WIDTH: 976px; POSITION: absolute; TOP: 78px; HEIGHT: 1px; BACKGROUND-COLOR: black" SIZE="1">
			<HR style="Z-INDEX: 103; LEFT: 13px; WIDTH: 988px; POSITION: absolute; TOP: 659px; HEIGHT: 2px; BACKGROUND-COLOR: black" SIZE="2">
			<asp:button id="btn_refresh" style="Z-INDEX: 104; LEFT: 755px; POSITION: absolute; TOP: 667px" runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Height="51px" Width="236px" Text="更新"></asp:button><asp:table id="table_5" style="Z-INDEX: 112; LEFT: 192px; POSITION: absolute; TOP: 225px" runat="server" BackColor="yellow" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table5" style="Z-INDEX: 118; LEFT: 205px; POSITION: absolute; TOP: 234px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="１０"></asp:button><asp:table id="table_4" style="Z-INDEX: 108; LEFT: 48px; POSITION: absolute; TOP: 223px" runat="server" BackColor="lime" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table4" style="Z-INDEX: 114; LEFT: 61px; POSITION: absolute; TOP: 232px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="９"></asp:button><asp:table id="table_3" style="Z-INDEX: 105; LEFT: 337px; POSITION: absolute; TOP: 120px" runat="server" BackColor="white" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table3" style="Z-INDEX: 117; LEFT: 350px; POSITION: absolute; TOP: 129px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="８"></asp:button><asp:table id="table_2" style="Z-INDEX: 106; LEFT: 193px; POSITION: absolute; TOP: 120px" runat="server" BackColor="purple" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table2" style="Z-INDEX: 116; LEFT: 206px; POSITION: absolute; TOP: 129px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="７"></asp:button><asp:table id="table_1" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 120px" runat="server" BackColor="blue" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table1" style="Z-INDEX: 115; LEFT: 61px; POSITION: absolute; TOP: 129px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="６"></asp:button><asp:textbox id="txt_Pos" style="Z-INDEX: 119; LEFT: 554px; POSITION: absolute; TOP: 678px" runat="server" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="25px" Width="40px">11</asp:textbox>
			<!--<asp:button id="btn_cancel" style="Z-INDEX: 120; LEFT: 633px; POSITION: absolute; TOP: 667px" runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Height="51px" Width="121px" Text="クリア"></asp:button>--><asp:table id="table_6" style="Z-INDEX: 109; LEFT: 339px; POSITION: absolute; TOP: 225px" runat="server" BackColor="Red" width="128" height="87">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_table6" style="Z-INDEX: 113; LEFT: 352px; POSITION: absolute; TOP: 234px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="69px" Width="104px" Text="６"></asp:button><asp:table id="tbl_Yobi1" style="Z-INDEX: 150; LEFT: 79px; POSITION: absolute; TOP: 659px" runat="server" BackColor="LightSkyBlue" width="126px" height="79px">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table>
			<!--<asp:table id="tbl_Yobi2" style="Z-INDEX: 152; LEFT: 221px; POSITION: absolute; TOP: 660px" runat="server" height="79px" width="125px" BackColor="LightSkyBlue">
				<asp:TableRow>
					<asp:TableCell Text="　"></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:button id="btn_Yobi1" style="Z-INDEX: 151; LEFT: 91px; POSITION: absolute; TOP: 669px" runat="server" Text="予備１" Width="103px" Height="60px" Font-Names="ＭＳ ゴシック" Font-Size="20pt" Font-Bold="True"></asp:button>
			<asp:button id="btn_Yobi2" style="Z-INDEX: 153; LEFT: 233px; POSITION: absolute; TOP: 669px" runat="server" Text="予備２" Width="103px" Height="60px" Font-Names="ＭＳ ゴシック" Font-Size="20pt" Font-Bold="True"></asp:button>
			<asp:Label id="Label1" style="Z-INDEX: 154; LEFT: 90px; POSITION: absolute; TOP: 625px" runat="server" Width="100px" Height="30px" Font-Size="20pt">相席用１</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 154; LEFT: 235px; POSITION: absolute; TOP: 625px" runat="server" Width="100px" Height="30px" Font-Size="20pt">相席用２</asp:Label>
			<div style="BORDER-RIGHT:black 3px solid; BORDER-TOP:black 3px solid; LEFT:61px; BORDER-LEFT:black 3px solid; WIDTH:300px; BORDER-BOTTOM:black 3px solid; POSITION:absolute; TOP:615px; HEIGHT:135px"><FONT face="MS UI Gothic"></FONT></div>
			--><asp:button id="hdn_btn_table1" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table2" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table3" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table4" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table5" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table6" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table7" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table8" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table9" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><asp:button id="hdn_btn_table10" style="LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT><FONT face="MS UI Gothic"></FONT></form>
		<!--<IFRAME style="Z-INDEX: 300; LEFT: 0px; VISIBILITY: hidden; POSITION: absolute; TOP: 0px" name="F_CNWL020" src="about:blank" frameBorder="yes" width="1024" scrolling="no" height="768">
		</IFRAME>-->
		<% LS_IframeWrite %>
		</FORM>
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
