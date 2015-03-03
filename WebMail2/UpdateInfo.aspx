<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateInfo.aspx.cs" Inherits="WebMail2.UpdateInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <link href="Css/border.css" rel="stylesheet" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Script/jquery-easyui-1.4.1/jquery.easyui.min.js"></script>
    <script src="Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <title></title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body {
            font-family: Arial, Helvetica, sans-serif;
        }

        .log_title {
            background-color: rgb(241,241,241);
            border-top: 2px solid rgb(229,229,229);
            padding: 5px;
            font-weight: bold;
            color: #333;
            font-size: 14px;
        }

            .log_title span {
                color: #555;
                font-size: 10px;
                font-weight: normal;
            }

        .log-list {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="clear20">
        </div>
        <div style="padding: 0px 20px;">
            <div style="height: 100px; padding-left: 220px; padding-top: 5px; line-height: 20px; background-image: url(img/green.png); background-repeat: no-repeat;">
                <span style="color: #555; font-family: 微软雅黑; font-size: 20px;">GREEN邮件 v1.1</span><br />
                <span style="color: #aaa; font-size: 12px;">Green Software Co., Ltd.</span>
            </div>
            <a name="update"></a>
            <div class="clear">
            </div>
            <div style="color: rgb(102,102,102); font-size: 16px; font-weight: bold;">
                更新日志：
            </div>
            <!--更新内容-->
            <div class="clear20">
            </div>
            <div class="log_title" style="color: red;">
                v1.1 正式版 <span>（2014年12月24日）</span>
            </div>
            <ul class="log-list">
                <li>优化邮件发送引擎，提高系统性能</li>
                <li>优化邮件删除引擎，避免系统冲突</li>
                <li>优化页面配色</li>
                <li>优化页面加载方式，避免页面部署在加载时混乱</li>
                <li>优化邮件列表时间显示，使用时间分段显示</li>
                <li>优化邮箱容量提醒</li>
                <li>优化收件人打开方式</li>
                <li>优化附件下载</li>
                <li>优化邮件列表，屏蔽由于网络较慢造成的参数错误</li>
                <li>解决在IE10以上浏览器无法发送邮件问题</li>
                <li>优化邮件预览缓存</li>
                <li>优化邮件容量计算方式，提供系统性能</li>
                <li>优收件人列表，屏蔽由于网络较慢造成的参数错误</li>
                <li>添加邮件图片功能</li>
                <li>优化邮件缓存减少内存占用</li>
            </ul>
            <div class="clear20">
            </div>
            <div class="log_title">
                v1.03 Beta版 <span>（2014年11月26日）</span>
            </div>
            <ul class="log-list">
                <li>优化系统初始化过程</li>
                <li>优化发送邮件失败时错误处理</li>
                <li>优化系统内核代码</li>
                <li>优化邮件自动删除引擎</li>
            </ul>
            <div class="clear20">
            </div>
            <div class="log_title">
                v1.02 Beta版 <span>（2014年11月25日）</span>
            </div>
            <ul class="log-list">
                <li>优化邮件等级选择方式，鼠标点击选择</li>
                <li>优化收件人列表，增加是否已删除列</li>
                <li>新增邮件容量提醒</li>
                <li>优化系统数据库视图，去掉多余字段，提高系统性能</li>
            </ul>
            <div class="clear20">
            </div>
            <div class="log_title">
                v1.01 Beta版 <span>（2014年11月24日）</span>
            </div>
            <ul class="log-list">
                <li><span style="color: red;">2014年11月24日公共测试版发布\(^o^)/</span> </li>
            </ul>
            <div class="clear20">
            </div>
            <div class="log_title">
                v1.0 Alpha版 <span>（2014年11月22日）</span>
            </div>
            <ul class="log-list">
                <li>2014年11月24日发布内部测试版</li>
            </ul>

            <!--更新内容结束-->
            <div class="clear20">
            </div>
            <div class="clear20">
            </div>
            <div class="border-line">
            </div>
            <div class="clear20">
            </div>
            <div class="copyright">
                @2015 Green<br />
            </div>
            <div class="clear20">
            </div>
        </div>
    </form>
</body>
</html>
