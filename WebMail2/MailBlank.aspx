<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailBlank.aspx.cs" Inherits="WebMail2.MailBlank" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <link href="/Css/border.css" rel="stylesheet" />
    <script src="/Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="/Script/jquery-easyui-1.4.1/jquery.easyui.min.js"></script>
    <script src="/Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <title></title>
    <link href="/css/main.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        window.onload = function () {
            if (document.getElementById("<%=hid_act.ClientID%>").value == "init") {
                window.setTimeout(function () {
                    location.reload();
                }, 5000);
            }
        }
    </script>
</head>
<body style="overflow: hidden; padding: 10px 10px;">
    <form id="form1" runat="server">
        <div class="clear10">
        </div>
        <div style="height: 450px; color: #f8f8f8; padding-left: 20px; padding-right: 20px;">
            <div style="font-size: 14px; font-family: 宋体; color: #aaa;">点击邮件主题预览邮件</div>
            <div class="clear20" style="height: 150px;">
            </div>
            <div style="text-align: center; font-size: 60px; font-family: 微软雅黑; line-height: 60px; font-weight: bold;">
                <asp:Label ID="labMessage" runat="server" Text="邮件预览"></asp:Label>
                <asp:HiddenField ID="hid_act" runat="server" />
            </div>
        </div>
        <div class="clear20">
        </div>
        <div class="border-line" style="background-image: url(/img/sidebar_divider2.png); background-repeat: repeat-x; height: 2px;">
        </div>
        <div class="clear20">
        </div>
        <div class="copyright" style="color:#aaa; font-size:12px;">
            @2015 Green<br />
        </div>
    </form>
</body>
</html>

