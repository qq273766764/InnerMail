<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageLoading.ascx.cs" Inherits="WebMail2.Ctrs.PageLoading" %>
<div id="loading-span" style="width: 100%; height: 2000px; position: absolute; z-index: 1000; background-color: white; left: 0px; top: 0px;">
    <div style="text-align: center;">
        <div style="height: 40px;"></div>
        <img alt="正在加载…" src="img/loading1.gif" />
        <div style="height: 10px;"></div>
        <div style="font-size: 12px; color:gray;">页面加载中……</div>
    </div>
</div>
<script type="text/javascript">
    $(function () {
        $("#loading-span").hide();
    });
</script>
 