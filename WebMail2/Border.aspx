<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Border.aspx.cs" Inherits="WebMail2.Border" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link href="/css/border.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Script/jquery-easyui-1.4.1/jquery.easyui.min.js"></script>
    <script src="/Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="/script/Highcharts-4.0.1/js/highcharts.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $(document).ready(function () {

                // 绑定邮件数量统计列表
                $('#mail_count').highcharts({
                    chart: {
                        plotBackgroundColor: null,
                        plotBorderWidth: null,
                        plotShadow: false
                    },
                    title: false,
                    tooltip: { pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>' },
                    plotOptions: {
                        pie: {
                            allowPointSelect: true,
                            cursor: 'pointer',
                            dataLabels: { enabled: false },
                            showInLegend: true
                        }
                    },
                    series: [{
                        type: 'pie',
                        name: '邮件数量',
                        data: [['收件箱', <%=CountRecive%>], { name: '发件箱', y: <%=CountSend%>, selected: true }, ['草稿箱', <%=CountDraft%>], ['垃圾箱', <%=CountDust%>]]
                    }]
                });

                ///绑定邮件容量统计
                $('#mail_size').highcharts({
                    chart: {
                        plotBackgroundColor: null,
                        plotBorderWidth: null,
                        plotShadow: false
                    },
                    title: false,
                    tooltip: { pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>' },
                    plotOptions: {
                        pie: {
                            allowPointSelect: true,
                            cursor: 'pointer',
                            dataLabels: { enabled: false },
                            showInLegend: true
                        }
                    },
                    series: [{
                        type: 'pie',
                        name: '邮件容量',
                        data: [['收件箱', <%=SumReciveAttachs%>], { name: '发件箱', y: <%=SumSendAttachs%>, selected: true }, ['剩余', <%=SumLastAttachs%>]]
                    }]
                });
            });
        });
    </script>
    <script type="text/javascript">
        $(function(){
            <%if(SumLastAttachs<=100*1024*1024){%>
            $.messager.show({
                title: '邮件容量提醒',
                msg: '尊敬的用户您好，您的邮件容量仅剩余 <span style="color:red; font-weight:bold;"><%=SumLastAttachsStr%></span>，请尽快删除垃圾邮件！',
                timeout: 0,
            });
            <%}%>
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 0px 20px; width: 800px">
            <div class="clear20">
            </div>
            <div class="title">
                尊敬的&nbsp;<asp:Label CssClass="user" ID="lab_UserName" runat="server" Text="Label"></asp:Label>&nbsp;您好。
            </div>
            <div class="clear5">
            </div>
            <div class="mail-notread">
                邮件：<b><%=CountNotRead %></b> 封 <a href="MailList.aspx">未读邮件</a>
            </div>
            <div class="clear20">
            </div>
            <div class="clear20">
            </div>
            <div class="infor-box">
                <div class="box-title">
                    邮箱统计
                </div>
                <div class="clear10">
                </div>
                <table>
                    <tr>
                        <td>
                            <div class="box-content">
                                邮件数量统计
                            <br />
                                <span class="box-subtitle">邮箱中共收到<span style="color:darkorange; font-weight:bold;"> <%=CountRecive %> </span>封邮件。</span>
                                <br />
                                <div id="mail_count" style="width: 340px; height: 200px;">
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class="box-content">
                                邮件容量统计
                            <br />
                                <span class="box-subtitle">共使用了 <span style="color:darkorange;font-weight:bold;"> <%=SumTotalAttachsStr %></span> 的邮箱容量，剩余 <span style="color:red; font-weight:bold;"><%=SumLastAttachsStr %></span>。</span>
                                <br />
                                <div id="mail_size" style="width: 340px; height: 200px;">
                                </div>
                            </div>
                        </td>
                    </tr>
                </table>
                <div class="clear10">
                </div>
                <div class="clear10">
                </div>
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
        </div>
    </form>
</body>
</html>
