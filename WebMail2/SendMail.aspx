<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMail.aspx.cs" Inherits="WebMail2.SendMail" ValidateRequest="false" %>

<%@ Register Src="Ctrs/Uploadify.ascx" TagName="Uploadify" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <link href="Css/main.css" rel="stylesheet" type="text/css" />
    <link href="Script/umeditor/themes/default/css/umeditor.min.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/gray/easyui.css" />
    <link rel="stylesheet" type="text/css" href="Script/jquery-easyui-1.4.1/themes/icon.css" />
    <link href="Script/umeditor/dialogs/image/image.css" rel="stylesheet" />
    <script src="Script/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script src="Script/jquery-easyui-1.4.1/jquery.easyui.min.js" type="text/javascript"></script>
    <script src="Script/jquery-easyui-1.4.1/locale/easyui-lang-zh_CN.js" type="text/javascript"></script>
    <script src="Script/umeditor/umeditor.min.js" type="text/javascript"></script>
    <script src="Script/umeditor/umeditor.config.js" type="text/javascript"></script>
    <script src="Script/umeditor/lang/zh-cn/zh-cn.js" type="text/javascript"></script>
    <script src="Script/main.js" type="text/javascript"></script>
    <script type="text/javascript" src="selector_sapi.axd"></script>
    <style type="text/css">
        .edit-title {
            width: 100px;
            text-align: right;
            color: #111;
            font-family: 宋体;
        }
        .toolbar {
            background-color: #dfe1e3;
            margin: 1px 2px;
            padding: 5px 10px;
        }

        span.star, span.star_black {
            background-image: url(img/hamburg16x16/star.png);
            background-repeat: repeat-x;
            background-position-y: center;
            width: 16px;
            height: 20px;
            display: inline-block;
            cursor: pointer;
        }

        span.star_black {
            background-image: url(img/取消收藏.png);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="toolbar">
            <asp:LinkButton ID="LinkButton1" CssClass="easyui-linkbutton" data-options="iconCls:'icon-ok'" runat="server" OnClientClick="return OnSubmit(false);" OnClick="LinkButton1_Click">发送</asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" CssClass="easyui-linkbutton" data-options="iconCls:'icon-save'" runat="server" OnClientClick="return OnSubmit(true);" OnClick="LinkButton2_Click">存草稿</asp:LinkButton>
        </div>
        <div class="edit-content" style="margin: 1px 2px; min-height: 100%;">
            <table style="width: 900px;">
                <tr>
                    <td>
                        <div class="clear10">
                        </div>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="edit-title">主 &nbsp; 题：
                    </td>
                    <td>
                        <asp:TextBox CssClass="easyui-textbox" Height="26px" data-options="prompt:'请输入邮件主题',width:'800px'" Width="800px" ID="txtSubject" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="edit-title">收 件人：
                    </td>
                    <td>
                        <asp:TextBox CssClass="easyui-textbox" Height="26px"
                            data-options="
                                    editable:false,
                                    prompt:'请选择收件人',
                                    buttonText:'选择…',
                                    buttonIcon:'icon-search',
                                    onClickButton:function(){SelUsers();},width:'800px'"
                            Width="800px" ID="txt_UserNames" runat="server"></asp:TextBox>
                        <asp:HiddenField ID="hid_UserNames" Value="" runat="server" />
                        <asp:HiddenField ID="hid_UserIDs" Value="" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="edit-title">等 &nbsp; 级：
                    </td>
                    <td>
                        <span class="star"></span>
                        <span class="star star_black"></span>
                        <span class="star star_black"></span>
                        <span class="star star_black"></span>
                        <asp:HiddenField ID="hid_Stars" Value="1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="edit-title"></td>
                    <td>
                        <uc2:Uploadify ID="Uploadify1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="edit-title">正 &nbsp; 文：
                    </td>
                    <td style="width: 800px;">
                        <script type="text/plain" id="myEditor" style="width: 800px; height: 400px;"><asp:Literal ID="ltr_Content" runat="server"></asp:Literal></script>
                        <asp:HiddenField ID="hid_Content" Value="" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td style="padding: 5px 0px; font-size: 12px; color: gray;">
                        <asp:Label ID="lab_SendName" runat="server" Text="-"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                </tr>
            </table>
            <div class="clear10">
            </div>
            <div class="clear20">
            </div>
        </div>
        <script type="text/javascript">
            //实例化编辑器
            window.UMEDITOR_CONFIG.toolbar = [
                'source | undo redo | bold italic underline strikethrough | superscript subscript | forecolor backcolor removeformat ',
                'insertorderedlist insertunorderedlist selectall | justifyleft justifycenter justifyright justifyjustify',
                '| paragraph fontfamily fontsize',
                ' cleardoc link unlink | emotion image horizontal',
                '| print preview'];
            window.UMEDITOR_CONFIG.imageUrl = "/Server/imgUpload.ashx";             //图片上传提交地址
            window.UMEDITOR_CONFIG.imagePath = "";             //图片地址头部
            var editHeight = $(window).height() - 285;
            window.UMEDITOR_CONFIG.initialFrameHeight = editHeight;
            var um = UM.getEditor('myEditor');
        </script>
        <script type="text/javascript">
            $(function () {
                //星级选择器事件
                $("span.star").click(function (e) {
                    var cnt = $("span.star").index($(this));
                    $("#hid_Stars").val(cnt + 1);
                    $("span.star:lt(" + (cnt + 1) + ")").removeClass("star_black");
                    $("span.star:gt(" + (cnt) + ")").addClass("star_black");
                });
            });
            function SelUsers() {
                var oldUsers = $("#hid_UserIDs").val();
                $.messager.progress({ title: '请等待', msg: '正在加载收件人，当收件人较多时该过程可能需要多一点时间，请稍耐心等待…' });
                var result = selopen(oldUsers, '0-0-1-0');
                if (result != null) {
                    var nameStr = "";
                    for (var i = 0; i < result.Name.length; i++) {
                        nameStr += result.Name[i].split('(')[0];
                        if (i < result.Name.length - 1) nameStr += ",";
                    }
                    $("#txt_UserNames").textbox("setValue", nameStr);
                    $("#hid_UserNames").val(nameStr);
                    $("#hid_UserIDs").val(result.IDStr);
                }
                $.messager.progress('close');
            }
            function OnSubmit(isdraft) {
                if ($("#txtSubject").val() == "") { alert("请输入邮件主题"); return false; }
                if (isdraft == false) {
                    if ($("#hid_UserIDs").val() == "") { alert("请选择收件人"); return false; }
                }
                $.messager.progress({ title: '发送中…', msg: '邮件正在发送请稍等……' });
                ///设置邮件内容
                $("#hid_Content").val(UM.getEditor('myEditor').getContent());
                __doPostBack_Ex(isdraft == false ? "LinkButton1" : "LinkButton2", "");
                return false;
            }
        </script>
    </form>
</body>
</html>
