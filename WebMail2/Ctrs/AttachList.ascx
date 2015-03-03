<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AttachList.ascx.cs" Inherits="WebMail2.Ctrs.AttachList" %>
<%@ Import Namespace="System.Linq" %>
<style type="text/css">
    ul.file-list {
        padding: 0px;
        margin: 0px;
    }

        ul.file-list li {
            width: 210px;
            float: left;
            display: inline-block;
            padding: 0px 8px 0px 25px;
            margin:0px 5px 0px 0px;
            background-image: url(img/hamburg16x16/attibutes.png);
            background-repeat: no-repeat;
            background-position: 6px center;
            border: 1px solid rgb(243,244,245);
        }

            ul.file-list li a {
                width: 140px;
                display: inline-block;
            }

            ul.file-list li:Hover {
                background-color: rgb(237, 237, 237);
                border: 1px solid #c8cfda;
            }

        ul.file-list span {
            float: right;
        }
</style>
<ul class="file-list">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <li><span><%#WebMail2.Codes.CodeHelper.ShowSize(Convert.ToDouble( Eval("FileSize"))) %></span>
                <a title="<%#Eval("FileName")%>" class="shortString" href='<%#GetDownLoadLink(Eval("ID").ToString(),Eval("FilePath").ToString()) %>'><%#Eval("FileName")%></a>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
