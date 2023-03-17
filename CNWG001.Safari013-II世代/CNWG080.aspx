<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG080.aspx.vb" Inherits="CNWG001.CNWG080" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG080</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">


		    //インナーフレーム表示時は親フレーム操作不可
            parent.document.getElementById("map").style.visibility = "visible";

		    //iPad縦スクロールロック
		    document.addEventListener('touchmove', bindTouch, false);
		    function bindTouch(event) {
		        event.preventDefault();
		    }

		    function FFrame() {
		        try {
		            document.all["F_CNWG040"].style.visibility = "visible";
		        } catch (e) { }
		    }

		    
    		supportTouch = 'ontouchend' in document.documentElement;
    		eventTouchStart = supportTouch ? 'touchstart' : 'mousedown';
    		eventTouchEnd = supportTouch ? 'touchend' : 'mouseup';
		    document.addEventListener(eventTouchEnd, function(e) {
                var target = e.target;
                var targetid = target.id;
                switch(targetid){
                case "btn_back":
                    parent.fWinClose();
                    break;
                //各ボタンタッチ                               
                case "btn_table1":
                    location.href = './CNWG080.aspx?UPDID=11';
                    break;
                case "btn_table2":       
                    location.href = './CNWG080.aspx?UPDID=12';
                    break;                        
                case "btn_table3":
                    location.href = './CNWG080.aspx?UPDID=13';
                    break;
                case "btn_table4":           
                    location.href = './CNWG080.aspx?UPDID=14';
                    break;
                case "btn_table5":      
                    location.href = './CNWG080.aspx?UPDID=15';
                    break;     
                case "btn_table6":
                    location.href = './CNWG080.aspx?UPDID=16';
                    break;
                case "btn_table7":
                    location.href = './CNWG080.aspx?UPDID=17';
                    break;                        
                case "btn_table8":
                    location.href = './CNWG080.aspx?UPDID=18';
                    break;
                case "btn_table9":
                    location.href = './CNWG080.aspx?UPDID=19';
                    break;
                case "btn_table10":
                    location.href = './CNWG080.aspx?UPDID=20';
                    break;
                case "btn_table11":
                    location.href = './CNWG080.aspx?UPDID=21';
                    break;
                case "btn_table12":
                    location.href = './CNWG080.aspx?UPDID=22';
                    break;                        
                case "btn_table13":
                    location.href = './CNWG080.aspx?UPDID=23';
                    break;
                case "btn_table14":
                    location.href = './CNWG080.aspx?UPDID=24';
                    break;
                case "btn_table15":
                    location.href = './CNWG080.aspx?UPDID=25';
                    break;
                case "btn_table16":
                    location.href = './CNWG080.aspx?UPDID=26';
                    break;
                case "btn_table17":
                    location.href = './CNWG080.aspx?UPDID=27';
                    break;
                case "btn_table18":
                    location.href = './CNWG080.aspx?UPDID=28';
                    break;
                case "btn_table19":
                    location.href = './CNWG080.aspx?UPDID=29';
                    break;
                case "btn_table20":
                    location.href = './CNWG080.aspx?UPDID=30';
                    break;
                case "btn_table21":
                    location.href = './CNWG080.aspx?UPDID=31';
                    break;
                case "btn_table22":
                    location.href = './CNWG080.aspx?UPDID=32';
                    break;                        
                case "btn_table23":
                    location.href = './CNWG080.aspx?UPDID=33';
                    break;
                case "btn_table24":
                    location.href = './CNWG080.aspx?UPDID=34';
                    break;
                case "btn_table25":
                    location.href = './CNWG080.aspx?UPDID=35';
                    break;
                case "btn_table26":
                    location.href = './CNWG080.aspx?UPDID=36';
                    break;
                case "btn_table27":
                    location.href = './CNWG080.aspx?UPDID=37';
                    break;
                case "btn_table28":
                    location.href = './CNWG080.aspx?UPDID=38';
                    break;
                case "btn_table29":
                    location.href = './CNWG080.aspx?UPDID=39';
                    break;
                case "btn_table30":
                    location.href = './CNWG080.aspx?UPDID=40';
                    break;
                case "btn_table31":
                    location.href = './CNWG080.aspx?UPDID=41';
                    break;
                case "btn_table32":
                    location.href = './CNWG080.aspx?UPDID=42';
                    break;                        
                case "btn_table33":
                    location.href = './CNWG080.aspx?UPDID=43';
                    break;
                case "btn_table34":
                    location.href = './CNWG080.aspx?UPDID=44';
                    break;
                case "btn_table35":
                    location.href = './CNWG080.aspx?UPDID=45';
                    break;
                case "btn_table36":
                    location.href = './CNWG080.aspx?UPDID=46';
                    break;
                case "btn_table37":
                    location.href = './CNWG080.aspx?UPDID=47';
                    break;
                case "btn_table38":
                    location.href = './CNWG080.aspx?UPDID=48';
                    break;
                case "btn_table39":
                    location.href = './CNWG080.aspx?UPDID=49';
                    break;
                case "btn_table40":
                    location.href = './CNWG080.aspx?UPDID=50';
                    break;                                                                                         
                default:
                    break;
            }
		        event.preventDefault();
            }, false);			    
		</script>
				
	    <style type="text/css">
            .style_btnCansel{z-index: 103;left: 228px;position: absolute;top: 25px;
width: 574px;height: 47px;text-align: CENTER;
            }
            .style1{z-index: 103;left: 6px;
position: absolute;top: 124px;
height: 89px;width: 121px;
            }
            .style2{z-index: 103;left: 134px;
position: absolute;top: 122px;
height: 89px;width: 121px;
            } 
            .style3{z-index: 103;left: 261px;
position: absolute;top: 123px;
height: 89px;width: 121px;
            } 
            .style4{z-index: 103;left: 387px;
position: absolute;top: 123px;
height: 89px;width: 121px;
            } 
            .style5{z-index: 103;left: 516px;
position: absolute;top: 123px;
height: 89px;width: 121px;
            } 
            .style6{z-index: 103;left: 641px;
position: absolute;top: 125px;
height: 89px;width: 121px;
            } 
            .style7{z-index: 103;left: 769px;
position: absolute;top: 124px;
height: 89px;width: 121px;
            } 
            .style8{z-index: 103;left: 894px;
position: absolute;top: 124px;
height: 89px;width: 121px;
            } 
            .style9{z-index: 103;left: 5px;
position: absolute;top: 218px;
height: 89px;width: 121px;
            } 
            .style10{z-index: 103;left: 132px;
position: absolute;top: 218px;
height: 89px;width: 121px;
            } 
            .style11{z-index: 103;left: 260px;
position: absolute;top: 218px;
height: 89px;width: 121px;
            } 
            .style12{z-index: 103;left: 388px;
position: absolute;top: 220px;
height: 89px;width: 121px;
            } 
            .style13{z-index: 103;left: 516px;
position: absolute;top: 220px;
height: 89px;width: 121px;
            } 
            .style14{z-index: 103;left: 642px;
position: absolute;top: 220px;
height: 89px;width: 121px;
            } 
            .style15{z-index: 103;left: 768px;
position: absolute;top: 220px;
height: 89px;width: 121px;
            } 
            .style16{z-index: 103;left: 893px;
position: absolute;top: 221px;
height: 89px;width: 121px;
            } 
            .style17{z-index: 103;left: 5px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            } 
            .style18{z-index: 103;left: 133px;
position: absolute;top: 316px;
height: 89px;width: 121px;
            } 
            .style19{z-index: 103;left: 261px;
position: absolute;top: 313px;
height: 89px;width: 121px;
            } 
            .style20{z-index: 103;left: 388px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            }             
            .style21{z-index: 103;left: 516px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            }             
            .style22{z-index: 103;left: 642px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            }             
            .style23{z-index: 103;left: 768px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            }             
            .style24{z-index: 103;left: 893px;
position: absolute;top: 314px;
height: 89px;width: 121px;
            }            
            .style25{z-index: 103;left: 5px;
position: absolute;top: 412px;
height: 89px;width: 121px;
            }             
            .style26{z-index: 103;left: 133px;
position: absolute;top: 412px;
height: 89px;width: 121px;
            }             
            .style27{z-index: 103;left: 262px;
position: absolute;top: 413px;
height: 89px;width: 121px;
            }             
            .style28{z-index: 103;left: 387px;
position: absolute;top: 411px;
height: 89px;width: 121px;
            }            
            .style29{z-index: 103;left: 515px;
position: absolute;top: 412px;
height: 89px;width: 121px;
            }            
            .style30{z-index: 103;left: 642px;
position: absolute;top: 413px;
height: 89px;width: 121px;
            }            
            .style31{z-index: 103;left: 768px;
position: absolute;top: 413px;
height: 89px;width: 121px;
            }            
            .style32{z-index: 103;left: 895px;
position: absolute;top: 413px;
height: 89px;width: 121px;
            }             
            .style33{z-index: 103;left: 5px;
position: absolute;top: 508px;
height: 89px;width: 121px;
            }             
            .style34{z-index: 103;left: 133px;
position: absolute;top: 508px;
height: 89px;width: 121px;
            }             
            .style35{z-index: 103;left: 262px;
position: absolute;top: 509px;
height: 89px;width: 121px;
            }            
            .style36{z-index: 103;left: 389px;
position: absolute;top: 510px;
height: 89px;width: 121px;
            }            
            .style37{z-index: 103;left: 518px;
position: absolute;top: 510px;
height: 89px;width: 121px;
            }             
            .style38{z-index: 103;left: 644px;
position: absolute;top: 510px;
height: 89px;width: 121px;
            }             
            .style39{z-index: 103;left: 769px;
position: absolute;top: 510px;
height: 89px;width: 121px;
            }            
            .style40{z-index: 103;left: 895px;
position: absolute;top: 509px;
height: 89px;width: 121px;
            }                     
        </style>
		
	</HEAD>
	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="#e5decc" onSelectStart='return false' onload="parent.ClearReflexive();">
	<!--	<form id="Form1" method="post" runat="server"> -->
			<FONT face="MS UI Gothic">
				<input type="hidden" name="__EVENTTARGET">
				<input type="hidden" name="__EVENTARGUMENT">

				<asp:button id="btn_back" 
                style="Z-INDEX: 500; LEFT: 836px; POSITION: absolute; TOP: 648px; height: 59px;" 
                runat="server" Font-Size="16pt" Font-Names="ＭＳ ゴシック" Width="159px" Text="キャンセル" 
                Font-Bold="True"></asp:button>
				<asp:label id="lbl_head" runat="server" Font-Size="22pt" Font-Names="ＭＳ ゴシック" 
                BackColor="White" Font-Bold="True" BorderStyle="Outset" ReadOnly="True" 
                CssClass="style_btnCansel"></asp:label>	
                
                <asp:button id="btn_table1" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１" CssClass="style1"></asp:button>
                <asp:button id="btn_table2" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２" CssClass="style2"></asp:button>
                <asp:button id="btn_table3" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３" CssClass="style3"></asp:button>                                
                <asp:button id="btn_table4" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="４" CssClass="style4"></asp:button>                
                <asp:button id="btn_table5" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="５" CssClass="style5"></asp:button>                
                <asp:button id="btn_table6" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="６" CssClass="style6"></asp:button> 
                 <asp:button id="btn_table7" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="７" CssClass="style7"></asp:button>
                 <asp:button id="btn_table8" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="８" CssClass="style8"></asp:button>
                 <asp:button id="btn_table9" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="９" CssClass="style9"></asp:button>
                 <asp:button id="btn_table10" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１０" CssClass="style10"></asp:button>
                 <asp:button id="btn_table11" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１１" CssClass="style11"></asp:button>
                 <asp:button id="btn_table12" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１２" CssClass="style12"></asp:button>
                 <asp:button id="btn_table13" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１３" CssClass="style13"></asp:button>
                 <asp:button id="btn_table14" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１４" CssClass="style14"></asp:button>
                 <asp:button id="btn_table15" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１５" CssClass="style15"></asp:button>
                 <asp:button id="btn_table16" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１６" CssClass="style16"></asp:button>
                 <asp:button id="btn_table17" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１７" CssClass="style17"></asp:button>
                 <asp:button id="btn_table18" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１８" CssClass="style18"></asp:button>
                 <asp:button id="btn_table19" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="１９" CssClass="style19"></asp:button>
                <asp:button id="btn_table20" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２０" CssClass="style20"></asp:button>
                <asp:button id="btn_table21" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２１" CssClass="style21"></asp:button>                
                 <asp:button id="btn_table22" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２２" CssClass="style22"></asp:button>               
                <asp:button id="btn_table23" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２３" CssClass="style23"></asp:button>                
                <asp:button id="btn_table24" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２４" CssClass="style24"></asp:button>                
                <asp:button id="btn_table25" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２５" CssClass="style25"></asp:button>
                 <asp:button id="btn_table26" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２６" CssClass="style26"></asp:button>              
                 <asp:button id="btn_table27" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２７" CssClass="style27"></asp:button>              
                <asp:button id="btn_table28" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２８" CssClass="style28"></asp:button>               
                <asp:button id="btn_table29" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="２９" CssClass="style29"></asp:button>               
                 <asp:button id="btn_table30" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３０" CssClass="style30"></asp:button>              
                <asp:button id="btn_table31" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３１" CssClass="style31"></asp:button>
                  <asp:button id="btn_table32" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３２" CssClass="style32"></asp:button>               
                <asp:button id="btn_table33" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３３" CssClass="style33"></asp:button>                
                <asp:button id="btn_table34" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３４" CssClass="style34"></asp:button>                
                <asp:button id="btn_table35" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３５" CssClass="style35"></asp:button>
                 <asp:button id="btn_table36" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３６" CssClass="style36"></asp:button>              
                 <asp:button id="btn_table37" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３７" CssClass="style37"></asp:button>              
                <asp:button id="btn_table38" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３８" CssClass="style38"></asp:button>               
                <asp:button id="btn_table39" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="３９" CssClass="style39"></asp:button>               
                 <asp:button id="btn_table40" runat="server" Font-Bold="True" Font-Size="24pt" 
                Font-Names="ＭＳ ゴシック" Text="４０" CssClass="style40"></asp:button>
                
 			<asp:button id="hdn_btn_table1" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table2" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table3" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table4" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table5" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table6" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table7" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table8" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table9" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table10" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table11" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table12" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table13" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table14" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 9px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table15" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table16" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table17" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table18" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table19" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table20" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table21" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table22" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 6px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table23" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 6px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table24" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table25" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table26" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table27" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table28" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table29" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>               
			<asp:button id="hdn_btn_table30" style="Z-INDEX: 100; LEFT: 1089px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table31" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table32" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 6px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table33" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 6px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table34" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table35" style="Z-INDEX: 100; LEFT: 1088px; POSITION: absolute; TOP: 7px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table36" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table37" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table38" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>
			<asp:button id="hdn_btn_table39" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>                                                                    
			<asp:button id="hdn_btn_table40" style="Z-INDEX: 100; LEFT: 1087px; POSITION: absolute; TOP: 8px" runat="server" Font-Bold="True" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Height="0px" Width="0px" Text="１"></asp:button>                                                                    
			</FONT>
	<!--	</form> -->
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
