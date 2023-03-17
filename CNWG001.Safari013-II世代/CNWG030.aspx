<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CNWG030.aspx.vb" Inherits="CNWG001.CNWG030" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CNWG030</title>
		<META http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta content="Microsoft Visual Studio .NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">

    		supportTouch = 'ontouchend' in document.documentElement;
    		eventTouchStart = supportTouch ? 'touchstart' : 'mousedown';
    		eventTouchEnd = supportTouch ? 'touchend' : 'mouseup';
    		movedX = -1;
    		movedY = -1;
    		touchMargin = 20;
    		var startObj = null;

         function objectSelectBegin(e) {
             if((startObj == null) && ((e.target.type == "submit") || (e.target.type == "button"))) {
                 startObj = e.target;
                  //element = document.getElementById(event.target.id);
                  if(supportTouch) {
                     var iItem = e.touches.item(0);
                     movedX = iItem.pageX;
                     movedY = iItem.pageY;
                     traceTouch(e);
                 //} else {
                 //    movedX = e.offsetX;
                 //    movedY = e.offsetY;
                 }
             }
         }

		    // iPadボタンイベント
		    //document.addEventListener('touchend', function(e) {
		    //document.addEventListener('click', function(e) {
         function objectSelectEnd(e) {
    		    var target = e.target;
    		    var fGoOn = true;
    		    if(target != startObj) {
    			    startObj = null;
    			    return;
    		    } else {
    			    if(supportTouch) {
    				    var bounds = target.getBoundingClientRect();
    				    if((movedX < bounds.left - touchMargin) || (movedX > bounds.right + touchMargin) || (movedY < bounds.top - touchMargin) || (movedY > bounds.bottom + touchMargin)) {
    					    startObj = null;
    					    return;
    				    }
    			    }
    		    }
		        var target = e.target;
		        switch (target.id) {
		            case 'btn_back':
		                parent.fWinClose();
		                break;
		            case 'btn_Set':
		                fSubmit(target.id);
		                FFrame();
		                break;
		            case 'btn_minus':
		                fSubmit(target.id);
		                break;
                    case "btn_TblChg":
                        location.href = './CNWG032.aspx';
                        break; 		                
		        }
    			    if(supportTouch) {
        			    unselectElement(startObj);
        			 }
				    startObj = null;
		    //}, false);
		    }

document.addEventListener(eventTouchStart, objectSelectBegin, false);
document.addEventListener(eventTouchEnd, objectSelectEnd, false);

		    //iPad縦スクロールロック
		    document.addEventListener('touchmove', bindTouch, false);
		    function bindTouch(event) {
		        event.preventDefault();
		    }
		    
		document.addEventListener('touchmove', bindTouch, false);
		document.addEventListener('touchcancel', objectSelectCancel, false);
            //document.addEventListener('touchmove', bindTouch, false);
		function bindTouch(event) {
			//iPad縦スクロールロック
			event.preventDefault();
			if(startObj != null) {
				traceTouch(event);
			}
		}

		function objectSelectCancel(event) {
			if(event.target == startObj) {
			    unselectElement(startObj);
				startObj = null;
			}
		}

       function traceTouch(event) {
                  if(supportTouch) {
                     if(event.target == startObj) {
                         //switch (startObj.id) {
                         //case 'dispAdv':
                             var iItem = event.touches.item(0);
                             movedX = iItem.pageX;
                             movedY = iItem.pageY;
                            var bounds = event.target.getBoundingClientRect();
                            var element = document.getElementById(event.target.id);
                            if((movedX < bounds.left - touchMargin) || (movedX > bounds.right + touchMargin) || (movedY < bounds.top - touchMargin) || (movedY > bounds.bottom + touchMargin)) {
	                            unselectElement(element);
	                         } else {
                                //element.disabled = false;
                                 //event.target.src="about:blank"
                                 //element.select();
                     //          element.style.border = 'solid blue';
                     //          element.style.borderWidth = '2px';
                               //element.style.box-shadow = '0px 0px 5px rgb(100, 100, 100, 0.5) inset';
                               //element.setStyle(item, {
                               // 'border-left-color':'#808080'
                               // ,'border-top-color':'#808080'
                               //});
	                             //iItem.select();
                               //element.enabled = true;
	                         }
	                       //  break;
	                     //}
	                 }
                  //} else {
                  //   movedX = e.offsetX;
                  //   movedY = e.offsetY;
                  }
       }

       function unselectElement(pElement) {
                                //pElement.disabled = true;
                               pElement.style.border = 'solid black';
                                  pElement.style.borderWidth = '1px';
                               //pElement.enabled = false;
       }

		    // お会計ボタン押下時サブミット
		    function fSubmit(id) {
		        document.location.href = "./CNWG030.aspx?SUBMITID=" + id + "&BTN_STATUS=" + getQuerystring("BTN_STATUS") + "&YOBI=" + getQuerystring("YOBI") + "&SEATID=" + getQuerystring("SEATID");
		    }

		    function FFrame() {
		        try {
		            document.all["F_CNWG040"].style.visibility = "visible";
		        } catch (e) { }
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
		    
	 	    //		function __doPostBack(eventTarget, eventArgument) {
		    //			document.Form1.txt_Msg.value      = "しばらくお待ち下さい．．．";
		    //			document.Form1.btn_true.disabled  = "true";
		    //			document.Form1.btn_false.disabled = "true";
		    //			var theform;
		    //			if (window.navigator.appName.toLowerCase().indexOf("microsoft") > -1) {
		    //				theform = document.Form1;
		    //			} else {
		    //				theform = document.forms["Form1"];
		    //			}
		    //			theform.__EVENTTARGET.value = eventTarget.split("$").join(":");
		    //			theform.__EVENTARGUMENT.value = eventArgument;
		    //			theform.submit();
		    //		}



		    //		//ウィンドウ消去
		    //		function fWinClose(){
		    //			parent.document.all["F_CNWG020"].style.visibility = "hidden";
		    //		}

		    //「マイナス伝票」ボタン押下時処理
		    function fminus(pNo) {
		        location.href = "./CNWG031.aspx?SEATID=" + pNo + "&MODE=1";
		        //parent.document.all["F_CNWL020"].style.visibility = "visible"; 
		        //parent.frames["F_CNWL020"].location.href = "../CNWL001/CNWL020.aspx?SEATID=" + pNo + "&MODE=1"; 
		        //fWinClose();
		    }
		</script>
		
		 
		
	    <style type="text/css">
            .style1
            {
                z-index: 500;
                left: 22px;
                position: absolute;
                top: 0px;
            }
        </style>
		
	</HEAD>
	<body MS_POSITIONING="GridLayout" <% OnInitBody() %> bgColor="#e5decc" onSelectStart='return false'>
	<!--	<form id="Form1" method="post" runat="server"> -->
			<FONT face="MS UI Gothic">
				<input type="hidden" name="__EVENTTARGET">
				<input type="hidden" name="__EVENTARGUMENT">
				<asp:button id="btn_Set" 
                style="Z-INDEX: 500; LEFT: 21px; POSITION: absolute; TOP: 65px; height: 59px;" 
                runat="server" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Width="120px" Text="お会計" 
                Font-Bold="True"></asp:button>
<!-- 2018-12-14 add -->
				<asp:button ID="btn_minus" 
                style="Z-INDEX: 500; LEFT: 151px; POSITION: absolute; TOP: 65px; height: 59px;" 
                runat="server" Font-Size="15pt" Font-Names="ＭＳ ゴシック" width="120px" Text="伝票訂正" 
                Font-Bold="True"></asp:button>

				<asp:button id="btn_back" 
                style="Z-INDEX: 500; LEFT: 281px; POSITION: absolute; TOP: 65px; height: 59px;" 
                runat="server" Font-Size="14pt" Font-Names="ＭＳ ゴシック" Width="120px" Text="キャンセル" 
                Font-Bold="True"></asp:button>
				<asp:button ID="btn_TblChg" 
                style="Z-INDEX: 500; LEFT: 411px; POSITION: absolute; TOP: 65px; height: 59px;" 
                runat="server" Font-Size="15pt" Font-Names="ＭＳ ゴシック" 
                width="109px" Text="座席移動" Font-Bold="True"></asp:button>
				<asp:textbox id="txt_Seat" runat="server" 
                Height="62px" Font-Size="28pt" Font-Names="ＭＳ ゴシック" Width="200px" 
                BackColor="#e5decc" Font-Bold="True" BorderStyle="None" ForeColor="Black" 
                ReadOnly="True" CssClass="style1">901番席</asp:textbox>
                <asp:label id="lbl_menu" 
                style="Z-INDEX: 500; LEFT: 546px; POSITION: absolute; TOP: 7px" runat="server" 
                Height="42px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Font-Bold="True">MENU</asp:label>
                <asp:label id="lbl_course" 
                style="Z-INDEX: 500; LEFT: 546px; POSITION: absolute; TOP: 36px" runat="server" 
                Height="42px" Font-Size="15pt" Font-Names="ＭＳ ゴシック" Font-Bold="True">COURSE</asp:label>
                <asp:label id="lbl_LastOrder_End" 
                style="Z-INDEX: 500; LEFT: 546px; POSITION: absolute; TOP: 81px" runat="server" 
                Height="42px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Font-Bold="True">ラストオーダー終了</asp:label>                
                <asp:label id="lbl_Course_End" 
                style="Z-INDEX: 500; LEFT: 546px; POSITION: absolute; TOP: 120px" runat="server" 
                Height="42px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Font-Bold="True">コース終了</asp:label>                
				<asp:label id="lbl_disp" style="Z-INDEX: 500; LEFT: 200px; POSITION: absolute; TOP: 15px" runat="server" Height="42px" Font-Size="18pt" Font-Names="ＭＳ ゴシック" Font-Bold="True">MESSAGE</asp:label>
				<table style="FONT-SIZE: 20pt; Z-INDEX: 500; LEFT: 246px; WIDTH: 400px; FONT-FAMILY: 'ＭＳ ゴシック'; POSITION: absolute; TOP: 15px; HEIGHT: 42px" 
                height="100">
					<TR height="50">
						<TD style="HEIGHT: 36px" vAlign="center" align="middle" colSpan="2">
							<asp:textbox id="txt_number" runat="server" Height="28px" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Width="42px" BackColor="#e5decc" Font-Bold="True" BorderStyle="None"></asp:textbox>
							<asp:textbox id="txt_unit" runat="server" Height="28px" Font-Size="20pt" Font-Names="ＭＳ ゴシック" Width="30px" BackColor="#e5decc" Font-Bold="True" BorderStyle="None">人</asp:textbox>
						</TD>
					</TR>
				</table>
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
