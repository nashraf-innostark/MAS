<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FollowQuestion.aspx.cs" Inherits="MAS.FollowQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="marginleft50">
    <div>
        <div class="lbldiv floatleft">
            <asp:Label ID="lblsubject" CssClass="lblstyle" runat="server" Text="Subject"></asp:Label>
        </div>
        <div>
            <asp:TextBox runat="server" CssClass="longtxtbxstyle" ID="txtbxsubject"></asp:TextBox>
        </div>
    </div>
    <div>
        <div class="lbldiv floatleft">
        <asp:Label ID="lblusername" CssClass="lblstyle" runat="server" Text="User Name"></asp:Label>
        </div><asp:TextBox runat="server" CssClass="txtareastyle" ID="txtareaquestion" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div class="padding10" style="padding-right:205px;">
        <asp:Button ID="btnCancel" CssClass="btnstyle floatright" runat="server" Text="Cancel"
            OnClick="btnCancel_Click" />
        <asp:Button ID="btnSend" CssClass="btnstyle floatright" runat="server" 
            Text="Send" onclick="btnSend_Click" />
    </div>
    </div>
</asp:Content>
