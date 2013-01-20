<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MAS.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html dir="ltr" lang="en-US">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>Medical Appointment System</title>
    <meta name="keywords" content=" , MAS , ">
    <meta name="description" content=" | ">
    <meta charset="UTF-8">
    <!--[RSS]-->
    <link rel="alternate" type="application/rss+xml" title="ABCLOGIC" href="http://livedemo00.template-help.com/wordpress_34210/?feed=rss2">
    <link rel="alternate" type="application/atom+xml" title="ABCLOGIC" href="http://livedemo00.template-help.com/wordpress_34210/?feed=atom">
    <link rel="alternate" type="application/rss+xml" title="ABCLOGIC » Feed" href="http://livedemo00.template-help.com/wordpress_34210/?feed=rss2">
    <link rel="alternate" type="application/rss+xml" title="ABCLOGIC » Comments Feed"
        href="http://livedemo00.template-help.com/wordpress_34210/?feed=comments-rss2">
    <!--Styles-->
    <link rel="stylesheet" type="text/css" media="all" href="./Styles/style.css">
    <!--Scripts-->
    <script type="text/javascript" src="./Scripts/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="./Scripts/jquery.nivo.slider.pack.js"></script>
    <script type="text/javascript" src="./Scripts/superfish.js"></script>
    <script type="text/javascript" src="./Scripts/maxheight.js"></script>
    <script type="text/javascript">
        // initialise plugins
        jQuery(function () {
            // main navigation init
            jQuery('ul.sf-menu').superfish({
                delay: 1000, 		// one second delay on mouseout 
                animation: { opacity: 'false', height: 'show' }, // fade-in and slide-down animation 
                speed: 'normal',  // faster animation speed 
                autoArrows: true        // generation of arrow mark-up (for submenu) 
            });
        });
    </script>
    <script type="text/javascript">
        $(window).load(function () {
            $('#slider').nivoSlider({
                effect: 'fade',
                animSpeed: 500,
                pauseTime: 5000,
                startSlide: 0,
                directionNav: true,
                directionNavHide: false
            });
        });
    </script>
    <script type="text/javascript" src="chrome-extension://dlnembnfbcpjnepmfjmngjenhhajpdfd/resources/LocalScript.js"></script>
    <script type="text/javascript" src="chrome-extension://dlnembnfbcpjnepmfjmngjenhhajpdfd/libraries/DataExchangeScript.js"></script>
    <!--[if lt IE 9]>
  <style type="text/css">
    #sidebar,
	#sidebar-right,
	.post_cycle li .post-date,
	.button,
	h1#page-title {
      behavior:url(http://livedemo00.template-help.com/wordpress_34210/wp-content/themes/theme1275/PIE.php)
      }
  </style>
  <![endif]-->
    <!-- The HTML5 Shim is required for older browsers, mainly older versions IE -->
    <!--[if lt IE 9]>
		<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
	<![endif]-->
    <!--[if lt IE 7]>
    <div style=' clear: both; text-align:center; position: relative;'>
    	<a href="http://www.microsoft.com/windows/internet-explorer/default.aspx?ocid=ie6_countdown_bannercode"><img src="http://www.theie6countdown.com/images/upgrade.jpg" border="0" &nbsp;alt="" /></a>
    </div>
    <![endif]-->
</head>
<body class="home blog cat-26-id cat-28-id" onload="new ElementMaxHeight();">
    <div id="main">
        <!-- this encompasses the entire Web site -->
        <div class="main-box container">
            <div class="main-box-top">
                <header id="header">
	        <div class="logo">
	           	           	           <a href="#"><img src="./Images/logo.png" alt="ABCLOGIC" title=""></a>
	                        </div>
		
	        <!--.primary-->
	       <form  runat="server" > 
           <div class="header-top">
	         <div id="top-search">
	          
	              <label>search</label><span class="input-search"><input type="text" name="s"></span><input type="submit" value="" id="submit">
               
	           </div>
		   		   </div>
                    <div class="loginDisplay">
                    <% if (Request.IsAuthenticated)
                       { %>
                        <asp:Label ID="lblusername" runat="server" Text="Welcome"></asp:Label>
                        
                        <asp:LinkButton runat="server" ID="lbLogout" Text="Logout" ></asp:LinkButton>
                     <% }
                       else
                       { %>
                       <a href="#login-box" class="login-window">Sign In</a>
                       <asp:TextBox runat="server" ID="txtKey" Style="display: none" /> 
                    <%} %>
            </div>
                </form>
		   <!--.container-->
          </header>
            </div>
            <div class="primary_content_wrap clearfix main-box-tail">
                <div class="main-box-extra-bot">
                    <div id="widget_my_cyclewidget">
                        <ul class="ban_cycle">
                            <li class="ban_item color1">
                                <div class="ban-top">
                                    <div class="ban-bot">
                                        <a href="#" class="link">read more </a>
                                    </div>
                                </div>
                            </li>
                            <li class="ban_item color2">
                                <div class="ban-top">
                                    <div class="ban-bot">
                                        <a href="#" class="link">read more </a>
                                    </div>
                                </div>
                            </li>
                            <li class="ban_item color3">
                                <div class="ban-top">
                                    <div class="ban-bot">
                                        <a href="#" class="link">read more </a>
                                    </div>
                                </div>
                            </li>
                            <li class="ban_item color4">
                                <div class="ban-top">
                                    <div class="ban-bot">
                                        <a href="#" class="link">read more </a>
                                    </div>
                                </div>
                            </li>
                            <li class="ban_item nomargin color5">
                                <div class="ban-top">
                                    <div class="ban-bot">
                                        <a href="#" class="link">read more </a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                        <!-- end of ban_cycle -->
                    </div>
                    <section id="slider-wrapper">
					   <div id="slider" class="nivoSlider"  >
		                <a href="#" class="nivo-imageLink" style="display: none;"><img src="./Images/slide02.jpg" alt="" title="" style="display: none;"></a>    	    
                        <a href="#" class="nivo-imageLink" style="display: none;"><img src="./Images/slide04.jpg" alt="" title="" style="display: none;"></a>    
            	        <a href="#" class="nivo-imageLink" style="display: block;"><img src="./Images/slide03.jpg" alt="" title="" style="display: none;"></a>  
                      	<a href="#" class="nivo-imageLink" style="display: none;"><img src="./Images/slide02.jpg" alt="" title="" style="display: none;"></a>    	
                        <a href="#" class="nivo-imageLink" style="display: none;"><img src="./Images/slide01.jpg" alt="" title="" style="display: none;"></a>  
                       </div>
				  </section>
                    <!--#slider-->
                    <div class="main-box-inner">
                        <div class="wrapper">
                            <aside id="sidebar" class="maxheight" style="height: 545px;">
	<div class="inside">
		<div id="categories-4" class="widget"><h3>Categories</h3>		<ul>
	<li class="cat-item cat-item-22"><a href="#" title="View all posts filed under Employment &amp; skills">Employment &amp; skills</a>
</li>
	<li class="cat-item cat-item-24"><a href="#" title="View all posts filed under Environment &amp; efficiency">Environment &amp; efficiency</a>
</li>
	<li class="cat-item cat-item-25"><a href="#" title="View all posts filed under Exploit your ideas">Exploit your ideas</a>
</li>
	<li class="cat-item cat-item-20"><a href="#" title="View all posts filed under Finance and grants">Finance and grants</a>
</li>
	<li class="cat-item cat-item-29"><a href="#" title="View all posts filed under Grow your business">Grow your business</a>
</li>
	<li class="cat-item cat-item-23"><a href="#" title="View all posts filed under Health, safety, premises">Health, safety, premises</a>
</li>
	<li class="cat-item cat-item-28"><a href="#" title="View all posts filed under International trade">International trade</a>
</li>
	<li class="cat-item cat-item-26"><a href="#" title="View all posts filed under IT &amp; e-commerce">IT &amp; e-commerce</a>
</li>
	<li class="cat-item cat-item-27"><a href="#" title="View all posts filed under Sales and marketing">Sales and marketing</a>
</li>
	<li class="cat-item cat-item-19"><a href="#" title="View all posts filed under Starting up">Starting up</a>
</li>
	<li class="cat-item cat-item-21"><a href="#" title="View all posts filed under Taxes, returns &amp; payroll">Taxes, returns &amp; payroll</a>
</li>
		</ul>
</div>	</div>
</aside>
                            <!--sidebar-->
                            <div id="content">
                                <div class="inside">
                                    <div id="widget_my_requestquotewidget" class="widget">
                                        <div class="box">
                                            <div class="box-text ">
                                                <h3>
                                                    See what we can do for your business!</h3>
                                                <a href="#" class="img-wrap"><span class="img-border"></span>
                                                    <img src="./Images/request-image.jpg"></a>
                                                <div class="extra-wrap">
                                                    <h5>
                                                        Lorem ipsum dolor sit amet, consec tetuer adipiscing elit. Praesent vestibulum</h5>
                                                    <p>
                                                        Molestie lacus. Aenean nonummy hendrerit mauris. Phasellus porta. Fusce suscipit
                                                        varius mi. <a href="#">Cum sociis natoque</a> penatibus et magnis dis parturient
                                                        montes, nascetur ridiculus mus. Nulla dui. Fusce feugiat malesuada odio</p>
                                                    <div class="box-button">
                                                        <a href="#" class="button">more <span>››</span></a>
                                                    </div>
                                                    <!-- end 'button' -->
                                                </div>
                                            </div>
                                            <!-- end 'with title' -->
                                        </div>
                                    </div>
                                    <div class="hr">
                                    </div>
                                    <div id="widget_text" class="widget-area">
                                        <h3>
                                            Premium Services</h3>
                                        <div class="textwidget">
                                            <div class="wrapper">
                                                <div class="one_half">
                                                    <ul>
                                                        <li><a href="#">Management Consulting</a></li>
                                                        <li><a href="#">Policy and Regulatory Analysis</a></li>
                                                        <li><a href="#">Market Assessment</a></li>
                                                        <li><a href="#">Program Management</a></li>
                                                        <li><a href="#">Regulatory Support</a></li>
                                                    </ul>
                                                </div>
                                                <div class="one_half last">
                                                    <ul>
                                                        <li><a href="#">Scientific and Risk Assessment</a></li>
                                                        <li><a href="#">Change Management </a></li>
                                                        <li><a href="#">Information Technology </a></li>
                                                        <li><a href="#">Strategic Communications</a></li>
                                                        <li><a href="#">Training and Education</a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!--#content-->
                            <div id="sidebar-right" class="maxheight" style="height: 545px;">
                                <div class="inside">
                                    <div id="my_cyclewidget-9" class="widget">
                                        <h3>
                                            News</h3>
                                        <ul class="post_cycle">
                                            <li class="cycle_item"><a href="#" class="post-date">
                                                <time datetime="2011-04-26T16:14">26.04.11</time>
                                            </a>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut in dignissim lectus....
                                                </p>
                                            </li>
                                            <li class="cycle_item"><a href="#" class="post-date">
                                                <time datetime="2011-03-26T16:14">26.03.11</time>
                                            </a>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut in dignissim lectus....
                                                </p>
                                            </li>
                                            <li class="cycle_item"><a href="#" class="post-date">
                                                <time datetime="2011-02-26T16:15">26.02.11</time>
                                            </a>
                                                <p>
                                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut in dignissim lectus....
                                                </p>
                                            </li>
                                        </ul>
                                        <!-- end of post_cycle -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!--.primary_content_wrap-->
            <div class="main-box-bot">
            </div>
        </div>
        <!--.main-box-->
        <footer id="footer">
		<div class="container clearfix">
   		             <nav class="primary">
		      <ul id="topnav" class="sf-menu sf-js-enabled sf-shadow">
 <li id="Li1" class="menu-item menu-item-type-post_type menu-item-7"><a href="#">Home</a></li>
             
<li id="menu-item-7" class="menu-item menu-item-type-post_type menu-item-7"><a href="#">About</a></li>
<li id="menu-item-281" class="menu-item menu-item-type-post_type menu-item-281"><a href="#">Solutions</a></li>
<li id="menu-item-280" class="menu-item menu-item-type-post_type menu-item-280"><a href="#">Partners</a></li>
<li id="menu-item-59" class="menu-item menu-item-type-post_type menu-item-59"><a href="#">Contacts</a></li>
</ul>             </nav>

		   		    	       </div>
		<!--.container-->


	</footer>
    </div>
    <!--#main-->
    <%-- <script type="text/javascript" src="./ABCLOGIC_files/jquery.form.js"></script>
    <script type="text/javascript" src="./ABCLOGIC_files/scripts.js"></script>
    --%>
    <!-- this is used by many Wordpress features and for plugins to work proporly -->
    <!-- Show Google Analytics -->
    <div id="LCS_336D0C35_8A85_403a_B9D2_65C292C39087_communicationDiv">
    </div>
    <span style="display: block; position: absolute; font-size: 1em; top: -1000px; left: -1000px;">
        A</span>
</body>
</html>
