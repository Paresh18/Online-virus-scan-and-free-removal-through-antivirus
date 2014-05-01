<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Small.aspx.cs" Inherits="Small" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Free Online Virus Scan - Bitdefender Online Virus Scanner</title>
<meta name="keywords" content="" />
<meta name="description" content="" />
<link rel="stylesheet" href="nivo-slider.css" type="text/css" media="screen" />
<link href="styles.css" rel="stylesheet" type="text/css" />
<link href="colorbox.css" rel="stylesheet" type="text/css" />

</head>
<body>

  <div id="main">
    	<!-- header begins -->
    <div id="header">
        <div id="buttons">
              <a href="index.html" title="">Home</a><div class="but_razd"></div>
                <a href="Small.aspx" title="">Small Business</a><div class="but_razd"></div>
                <a href="Enter.aspx" title="">Enterprises</a><div class="but_razd"></div>
                <a href="Aboutus.aspx" title="">About&nbsp;us</a><div class="but_razd"></div>
                <a href="Contactus.aspx" title="">Contact&nbsp;us</a>
      </div>
	<br /><br />
    <br /><br />
    <!-- header ends -->
    <form id="form1" runat="server">
   <div style="font-size:xx-large;color:Black;text-align:center;">
    <p><strong><b>Bitdefender Quick Scan </b></strong><br /><br />
    <strong><b>Fast & free online virus scanner </b></strong><br /><br /></p>
   
       <asp:Image ID="Image1" runat="server" 
           ImageUrl="~/pcsentry-soldier-and-gremlins1.png" />
       <br />
       <br />
       <br />
       <asp:ImageButton ID="ImageButton1" runat="server" Height="100px" 
           ImageUrl="~/start-scan-button.gif" onclick="ImageButton1_Click1" 
           ToolTip="Virus Scanner" /> 
       <br />
       <br />
       <br />

       </p>
    
    </div>
    </form>
</body>
</html>
