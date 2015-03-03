<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebMail2.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <script src="Script/jquery-1.7.2.min.js"></script>
    <link href="/css/menu.css" rel="stylesheet" type="text/css" />
</head>
<body  style=" background-color: rgb(244, 245, 246);">
    <form id="form1" runat="server">
        <div class="clear10">
        </div>
        <div class="menu-big menu-big-send">
            <a href="sendmail.aspx" target="sysCenterPage">写邮件</a>
        </div>
        <div class="clear10">
        </div>
        <div class="menu-line">
        </div>
        <div class="clear10">
        </div>
        <div class="menu-normal">
            
            <a href="MailList.aspx?t=1" target="sysCenterPage">收件箱(<b><asp:Label ID="lab_NotRead" runat="server" Text="0"></asp:Label></b>/<asp:Label ID="lab_ReadAll" runat="server" Text="0"></asp:Label>)</a>
        </div>
        <div class="menu-normal">
            <a href="MailList.aspx?t=2" target="sysCenterPage">已发送(<b><asp:Label ID="lab_Send" runat="server" Text="0"></asp:Label></b>)</a>
        </div>
        <div class="menu-normal">
            <a href="MailList.aspx?t=3" target="sysCenterPage">草稿箱(<b><asp:Label ID="lab_draft" runat="server" Text="0"></asp:Label></b>)</a>
        </div>
        <div class="menu-normal">
            <a href="MailList.aspx?t=4" target="sysCenterPage">垃圾箱(<b><asp:Label ID="lab_dust" runat="server" Text="0"></asp:Label></b>)</a>
        </div>
        <%--<div class="menu-normal menu-normal-sc">
            <a href="MailList.aspx?t=4" target="sysCenterPage">收件箱(1)</a>
        </div>
        <div class="menu-normal menu-normal-sc">
            <a href="MailList.aspx?t=5" target="sysCenterPage">发件箱(1)</a>
        </div>--%>
        <div class="clear10">
        </div>
        <div class="menu-line">
        </div>
        <div class="clear5">
        </div>
        <div class="menu-setting">
            <a href="border.aspx" target="sysCenterPage">邮箱首页</a>&nbsp;&nbsp;&nbsp;&nbsp;
            <!--<a href="MailBlank.aspx?act=debug" target="sysCenterPage">反馈中心</a><br />-->
            <a href="UpdateInfo.aspx#update"  target="sysCenterPage">系统更新</a><br />
        </div>
        <div class="clear10">
        </div>
        <div class="clear10">
        </div>
        <script type="text/javascript">
            $(function () {
                $('.menu-normal').click(function () {
                    $(this).addClass("menu-selected").siblings().removeClass("menu-selected");
                });
            });
        </script>
    </form>
</body>
</html>
