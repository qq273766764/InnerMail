<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailView.aspx.cs" Inherits="WebMail2.MailView" %>

<%@ Register Src="Ctrs/AttachList.ascx" TagName="AttachList" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="Script/jquery-easyui-1.4.1/jquery.easyui.min.js"></script>
    <script src="Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="Script/main.js" type="text/javascript"></script>
    <title></title>
    <link href="css/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .showaddress {
            cursor: pointer;
            background-image: url(img/hamburg16x16/address.png);
            background-repeat: no-repeat;
            display: inline-block;
            width: 20px;
            background-position: center;
        }

        span.stars1, span.stars2, span.stars3, span.stars4 {
            background-image: url(img/hamburg16x16/star.png);
            background-repeat: repeat-x;
            background-position-y: center;
            width: 64px;
            height: 20px;
            display: inline-block;
        }

        span.stars1 {
            width: 16px;
        }

        span.stars2 {
            width: 32px;
        }

        span.stars3 {
            width: 48px;
        }
    </style>
    <script type="text/javascript">
        $.ajaxSetup({
            cache: false //关闭AJAX相应的缓存
        });
        function ShowAddress() {
            $('#w_address').window('open')
        }
        function ShowReciver() {
            $("#w_recivers").window('open');
            $("#grid_recivers").datagrid();
        }
        function DoSearch()
        {
            var key = $("#keybox").val();
            $('#grid_recivers').datagrid('options').queryParams.key = key;
            $('#grid_recivers').datagrid('reload');
        }
        function IsDelFormater(value) {
            return value ? "已删除" : "未删除";
        }
        function DeleteMail(isDel) {
            $.messager.confirm('提示', 
                isDel?'选中邮件将会被彻底删除，您确定要删除吗？':'邮件删除后您将可以从垃圾箱中找到，确定要删除吗？', 
                function (r) {
                    if (r) {
                        var win = $.messager.progress({ title: '请等待', msg: '删除中……' });
                        $.post("Server/DataDelete.ashx", { ids: <%=MailID %>,t:<%=Convert.ToInt32(DataType) %>,isdel:isDel}, function (data, status) {
                            $.messager.progress('close');
                            if (status != 'success') {
                                $.messager.alert("提示", "连接服务失败，请稍后重试！", "error");
                            }
                            if (data != 'OK') {
                                $.messager.alert("提示", "删除失败，请检查后重试！", "error");
                            } else {
                                window.parent.RefrashGrid();
                                var navurl="MailBlank.aspx?act="+(isDel==true?"del2":"del");
                                window.location.href=navurl;
                            }
                        });
                    }
                });
            }
    </script>
</head>

<body style="overflow: hidden;">
    <form id="form1" runat="server">
        <div class="edit-content" style="padding: 0px; margin: 2px; height: 100%; background-color: white; overflow: scroll;">
            <div class="toolbar" style="padding: 0px;">
                <div style="width: 800px; padding: 0px;">
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-undo',plain:true" ID="lnk_Repay" runat="server">回复</asp:HyperLink>
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-redo',plain:true" ID="lnk_Forward" runat="server">转发</asp:HyperLink>
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-edit',plain:true" ID="lnk_Edit" runat="server">编辑</asp:HyperLink>
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-clear',plain:true" ID="lnk_Del" onclick="DeleteMail()" runat="server">删除</asp:HyperLink>
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-cancel',plain:true" ID="lnk_Del2" onclick="DeleteMail(true)" runat="server">彻底删除</asp:HyperLink>
                    <asp:HyperLink Target="sysCenterPage" CssClass="easyui-linkbutton" data-options="iconCls:'icon-man',plain:true" ID="lnk_State" onclick="ShowReciver()" runat="server">收件状态</asp:HyperLink>
                </div>
            </div>
            <div style="padding: 0px 20px;">
                <div class="clear10">
                </div>
                <div class="whitepage" style="width: 800px; margin: 0px; padding: 0px;">
                    <table class="edit-content" style="width: 100%; border-bottom: 1px solid #eee;">
                        <tr>
                            <td>
                                <div class="clear10">
                                </div>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="padding: 0px 20px;">
                                <asp:Label ID="labSubject" Font-Size="14" Font-Bold="true" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="edit-title">时 &nbsp; 间：
                            </td>
                            <td>
                                <asp:Label ID="labSendTime" runat="server" Text=""></asp:Label></td>
                        </tr>
                        <tr>
                            <td class="edit-title">发件人：
                            </td>
                            <td>
                                <asp:Label ID="labSender" Font-Bold="true" ForeColor="#5fa207" runat="server" Text=""></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="edit-title">收件人：
                            </td>
                            <td>
                                <asp:Literal ID="ltrAddressName" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td class="edit-title">等 &nbsp; 级：
                            </td>
                            <td>
                                <asp:Literal ID="LtrStars" runat="server"></asp:Literal>
                            </td>
                        </tr>
                        <tr>
                            <td class="edit-title">附 &nbsp; 件：
                            </td>
                            <td>
                                <uc1:AttachList ID="AttachList1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                    <div class="clear10">
                    </div>
                    <div style="padding: 10px 20px; min-height: 300px;">
                        <asp:Literal ID="ltrContext" runat="server"></asp:Literal>
                    </div>
                    <div class="clear20">
                    </div>
                </div>
                <div class="clear20">
                </div>
            </div>
            <div id="w_address" class="easyui-window" title="收件人"
                style="width: 400px; height: 200px; padding: 5px;"
                data-options=" iconCls:'icon-save',modal:false,closed:true,onResize:function(){ $(this).window('hcenter'); }">
                <p>
                    <asp:Literal ID="ltrAddressNameAll" runat="server"></asp:Literal>
                </p>
            </div>
            <div id="w_recivers" class="easyui-window" title="已发送成功"
                style="width: 400px; height: 500px;"
                data-options=" iconCls:'icon-save',modal:true,closed:true,onResize:function(){ $(this).window('hcenter'); }">
                <table id="grid_recivers"
                    data-options="
                        singleSelect:true,
                        method:'get',
                        url: '/Server/DataState.ashx?id=<%=MailID %>',
                        collapsible:true,
                        fit:true,
                        pagination:true, 
                        rownumbers:true,
                        toolbar:'#toolbar',
                        pageSize:50"
                    fit='true'>
                    <thead>
                        <tr>
                            <th data-options="field:'IsRead',width:40,align:'center',formatter:function(v,r,i){return ReadFormater(v,r);}">阅读
                            </th>
                            <th data-options="field:'UName',width:100,align:'center'">收件人
                            </th>
                            <th data-options="field:'ReadTime',width:120,formatter:function(v,r,i){return DateFormater(v);}">收件时间
                            </th>
                            <th data-options="field:'IsDel',width:60,formatter:function(v,r,i){return IsDelFormater(v);}">删除
                            </th>
                        </tr>
                    </thead>
                </table>
                <div id="toolbar">
                    <table style="width: 100%;">
                        <tr>
                            <td>&nbsp;
                            </td>
                            <td width="205px">
                                <input id="keybox" class="easyui-textbox" data-options="prompt:'请输入用户名'" type="text" name="name" style="width: 200px;"></input>
                            </td>
                            <td width="60px">
                                <a href="#" class="easyui-linkbutton" iconcls="icon-search" onclick="DoSearch();">搜索</a>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
