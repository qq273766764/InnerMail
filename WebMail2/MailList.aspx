<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MailList.aspx.cs" Inherits="WebMail2.List_RightLeft" %>

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
    <script src="Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="Script/main.js" type="text/javascript"></script>
    <script type="text/javascript">
        $.ajaxSetup({
            cache: false //关闭AJAX相应的缓存
        });
        function LinkFormater(value, row) {
            var href="";
            return "<a class='mail-title shortString' title='"+
                value+
                "' href='MailView.aspx?id="+
                row.ID+
                "&t=<%=DataType %>' onclick='return OpenDetial(this,event,"+ row.ID+","+row.IsRead+")' target='sysDetialPage'>" + value + "</a>";
        }
        function StarFormater(value) {
            return "<span class='mail-start" + value + "'>" + value + "</span>";
        }
        function OpenDetial(obj,e,id,isread)
        {
            <%if (DataType == "3")
              {%>
            window.location.href="SendMail.aspx?act=Edit&id="+id;
            <%}
              else
              {%>
            $("#sysDetialPage").attr("src","MailView.aspx?t=<%=DataType %>&id="+id+"&r="+isread);
            $("#isread"+id).attr("src","img/mailread.png").attr("alt","已读");
            <%}%>
            var evt=(e)?e:window.event;  
            if (window.event) {  
                evt.cancelBubble=true;  
            } else {  
                evt.stopPropagation();  
            }
            return false;
        }
        function DoSearch() {
            var key = $("#keybox").val();
            $('#grid_mail').datagrid('options').queryParams.key = key;
            $('#grid_mail').datagrid('reload');
        }
        function RefrashGrid()
        {
            $('#grid_mail').datagrid('reload');
        }
        function DeleteMail(isDel) {
            var rows = $('#grid_mail').datagrid('getChecked');
            if (rows == null) { $.messager.alert("提示", "请选择要删除的邮件！", "info"); }
            if (rows) {
                $.messager.confirm('提示', 
                    isDel?'选中邮件将会被彻底删除，您确定要删除吗？':'邮件删除后您将可以从垃圾箱中找到，确定要删除吗？', 
                    function (r) {
                        if (r) {
                            var win = $.messager.progress({ title: '请等待', msg: '删除中……' });
                            var ids = "";
                            for (var i = 0; i < rows.length; i++) {
                                ids += rows[i].ID + ",";
                            }
                            $.post("Server/DataDelete.ashx", { ids: ids,t:<%=DataType %>,isdel:isDel}, function (data, status) {
                                $.messager.progress('close');
                                if (status != 'success') {
                                    $.messager.alert("提示", "连接服务失败，请稍后重试！", "error");
                                }
                                if (data != 'OK') {
                                    $.messager.alert("提示", "删除失败，请检查后重试！", "error");
                                } else {
                                    $.messager.alert("提示", "删除成功！", "ok");
                                    $('#grid_mail').datagrid('reload');
                                }
                            });
                        }
                    });
                }
            }
    </script>
    <style type="text/css">
        a.mail-title {
            word-spacing: 3px;
            font-family: "lucida Grande",Verdana;
            text-decoration: none;
            padding-right: 50px;
            min-width: 200px;
            display: inline-block;
        }

        .datagrid-row-selected a {
            color: white;
        }

        .mail-start1,
        .mail-start2,
        .mail-start3,
        .mail-start4 {
            display: inline-block;
            background-color: rgb(245,96,69);
            color: white;
            font-family: Arial;
            font-size: 12px;
            text-align: center;
            width: 14px;
        }

        .mail-start3 {
            background-color: rgb(255,133,71);
        }

        .mail-start2 {
            background-color: rgb(255,172,56);
        }

        .mail-start1 {
            background-color: rgb(142,185,245);
        }

        .datagrid-row-selected {
            background-color: rgb(104, 123, 143);
        }
    </style>
</head>

<body class="easyui-layout">
    <form id="form1" runat="server">
        <uc1:PageLoading ID="PageLoading1" runat="server" />
        <div data-options="region:'west',iconCls:'icon-tip',border:true,split:true" title="<%=Title %>" style="width: 700px; overflow: hidden;">
            <table id="grid_mail" class="easyui-datagrid" data-options="
                    singleSelect:false,
                    url:'/Server/DataServer.ashx?t=<%=DataType %>',
                    method:'get',
                    collapsible:true,
                    fit:true,
                    pagination:true, 
                    rownumbers:true,
                    pageSize:50,
                    toolbar:'#toolbar',
                    rowStyler: function(index,row){
                        row.IsRead=='true'?'font-weight:bold':'font-weight:bold';},border:false"
                fit='true'>
                <thead>
                    <tr>
                        <th data-options="field:'ID',checkbox:true"></th>
                        <th data-options="field:'Level',width:30,align:'center',formatter:function(v,r,i){return StarFormater(v);}">等级
                        </th>
                        <th data-options="field:'IsRead',width:40,align:'center',formatter:function(v,r,i){return ReadFormater(v,r);}">阅读
                        </th>
                        <th data-options="field:'Subject',width:370,formatter:function(v,r,i){return LinkFormater(v,r);}">主题
                        </th>
                        <th data-options="field:'SendFromName',width:80">发件人
                        </th>
                        <th data-options="field:'SendTime',width:100,formatter:function(v,r,i){return DateFormater(v);}">发送时间
                        </th>
                    </tr>
                </thead>
            </table>
            <div id="toolbar">
                <table style="width: 100%;">
                    <tr>
                        <td width="55px">
                            <a href="javascript:void(0)" class="easyui-linkbutton" id="delete" iconcls="icon-clear"
                                plain="true" onclick="DeleteMail()">删除</a>
                        </td>
                        <td width="85px">
                            <a href="javascript:void(0)" class="easyui-linkbutton" id="A1" iconcls="icon-cancel"
                                plain="true" onclick="DeleteMail(true)">彻底删除</a>
                        </td>
                        <td>&nbsp;
                        </td>
                        <td width="265px">
                            <input id="keybox" class="easyui-textbox" 
                                data-options="
                                    prompt:'搜索主题关键字…',
                                    buttonText:'搜索',
                                    buttonIcon:'icon-search',
                                    onClickButton:function(){DoSearch();},width:'260px'"
                                type="text" name="name" style="width: 260px;"></input>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div data-options="
            region:'center',
            iconCls:'icon-tip',
            border:true,
            split:true,
            title:'邮件预览'"
            style="overflow: hidden;">
            <iframe frameborder="0" src="MailBlank.aspx" width="100%" height="100%" name="sysDetialPage" id="sysDetialPage"></iframe>
        </div>
    </form>
</body>
</html>
