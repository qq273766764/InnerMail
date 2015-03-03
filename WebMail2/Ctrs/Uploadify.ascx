<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Uploadify.ascx.cs" Inherits="WebMail2.Ctrs.Uploadify" %>

<asp:HiddenField ID="hid_files" runat="server" />
<input onclick="alert('加载上传控件失败！您的浏览器不支持Flash，请更换浏览器或联系管理员'); return false;" type="file" name="file_upload" id="file_upload" />
<link href="Script/uploadify/uploadify.css" rel="stylesheet" />
<script src="../Script/uploadify/jquery.uploadify.js"></script>
<style type="text/css">
    .uploadify-queue-item .cancel a {
        background: url('img/clear.png') 0 0 no-repeat;
    }

    .uploadify-queue-item .data {
        float: right;
    }
</style>
<script type="text/javascript">
    $(function () {
        $("#file_upload").uploadify({
            //指定swf文件
            swf: 'Script/uploadify/uploadify.swf',
            //后台处理的页面
            uploader: '/Server/FileUpload.ashx',
            //按钮显示的文字
            buttonText: '选择附件',
            //显示的高度和宽度，默认 height 30；width 120
            height: 20,
            width: 100,
            //上传文件的类型  默认为所有文件    'All Files'  ;  '*.*'
            //在浏览窗口底部的文件类型下拉菜单中显示的文本
            fileTypeDesc: '所有文件',
            //允许上传的文件后缀
            fileTypeExts: '<%=FileExts%>',
            //发送给后台的其他参数通过formData指定
            //'formData': { 'someKey': 'someValue', 'someOtherKey': 1 },
            //上传文件页面中，你想要用来作为文件队列的元素的id, 默认为false  自动生成,  不带#
            //queueID: 'fileQueue',
            //选择文件后自动上传
            auto: true,
            //设置为true将允许多文件上传
            multi: true,
            transparent: true,
            fileSizeLimit: 200 * 1024, // 200MB
            removeCompleted: false,
            removeTimeout: 10000,
            onUploadComplete: function (file) { },
            onUploadSuccess: function (file, data, response) {
                var ServerFile = eval("[" + data + "]")[0];
                var files = [];
                if ($("#<%= hid_files.ClientID %>").val() != "") {
                    files = eval($("#<%= hid_files.ClientID %>").val());
                }
                var filedata = new Object();
                filedata.ID = 0;
                filedata.IsDel = false;
                filedata.FileId = file.id;
                filedata.FileName = file.name;
                filedata.FilePath = ServerFile.url;
                filedata.FileSize = file.size;
                files.push(filedata);
                $("#<%= hid_files.ClientID %>").val(JSON.stringify(files));
                $("div#uploadify_" + file.id).find(".data").text("上传成功");
                $("div#uploadify_" + file.id).find(".uploadify-progress-bar").width("100%");
            },
            onUploadProgress: function (file, bytesUploaded, bytesTotal, totalBytesUploaded, totalBytesTotal) {
                var percent = Math.round(totalBytesUploaded / totalBytesTotal * 100);
                $("div#uploadify_" + file.id).find(".data").text("已上传" + percent + "%");
                $("div#uploadify_" + file.id).find(".uploadify-progress-bar").width(percent + "%");
            },
            //批量上传成功触发事件
            onUploadError: function (file, errorCode, errorMsg) {
                alert("上传错误,errorCode:" + errorCode + ",errorMsg:" + errorMsg);
            },
            onCancel: function (file) {
                CancelFile(file.Id, 0);
            },
            itemTemplate: "<div class='uploadify-queue-item' id='uploadify_${fileID}'>" +
                        "<div class='cancel'><a href=\"javascript:CancelFile('${fileID}','uploadify_${fileID}',1)\">X</a></div>" +
                        "<span class='fileName'>${fileName} (${fileSize})</span><span class='data'>上传中…</span>" +
                        "<div class='uploadify-progress'><div class='uploadify-progress-bar' style='width:10%;'></div></div>" +
                        "</div>",
            onInit: function (instance) {
                //绑定现有文件
                var files = eval($("#<%= hid_files.ClientID %>").val());
                if (files == null || files == undefined) { return; }
                for (var i = 0; i < files.length; i++) {
                    var file = files[i];
                    $(instance.queue).append(
                        "<div class='uploadify-queue-item' id='uploadify_old_" + file.FileId + "'>" +
                        "<div class='cancel'><a href=\"javascript:CancelFile('" + file.FileId + "','uploadify_old_" + file.FileId + "',1)\">X</a></div>" +
                        "<span class='fileName'>" + file.FileName + " (" + file.FileSizeString + ")</span><span class='data'></span>" +
                        "<div class='uploadify-progress'><div class='uploadify-progress-bar' style='width: 100%;'></div></div>" +
                        "</div>");
                }
            }
        });
    });
</script>
<script type="text/javascript">
    function CancelFile(id, containid, hide) {
        var files = eval($("#<%= hid_files.ClientID %>").val());
        if (files != null && files != undefined) {
            for (var i = 0; i < files.length; i++) {
                var file = files[i];
                if (file.FileId == id) {
                    file.IsDel = true;
                    break;
                }
            }
            $("#<%= hid_files.ClientID %>").val(JSON.stringify(files));
            if (hide == 1) { $("#" + containid).fadeOut(); }
        }
        $('#file_upload').uploadify('cancel', id);
    }
</script>
