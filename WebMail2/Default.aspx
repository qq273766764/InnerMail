<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebMail2.Default" %>

<%@ Register Src="Ctrs/PageLoading.ascx" TagName="PageLoading" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Script/jquery-easyui-1.4.1/jquery.easyui.min.js"></script>
    <script src="/Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
</head>
<body class="easyui-layout">
    <form id="form1" runat="server">
        <uc1:PageLoading ID="PageLoading1" runat="server" />
        <div data-options="region:'west',iconCls:'icons-tip'" style="width: 200px; background-color: rgb(244, 245, 246); overflow-x: hidden; overflow-y: hidden;">
            <iframe frameborder="0" src="Menu.aspx" width="100%" height="100%" id="Iframe1"></iframe>

        </div>
        <div data-options="region:'center',border:false" style="overflow: hidden;">
            <iframe frameborder="0" src="border.aspx" width="100%" height="100%" name="sysCenterPage" id="sysCenterPage"></iframe>
        </div>

    </form>
</body>
</html>
