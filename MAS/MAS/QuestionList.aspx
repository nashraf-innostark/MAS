<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="QuestionList.aspx.cs" Inherits="MAS.QuestionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
<div style="margin-top:20px;">
    <asp:Button ID="btnAddNew" CssClass="btnstyle floatright" runat="server" 
        Text="Create" onclick="btnAddNew_Click" />
</div>
<div style="margin-top:20px;">
    <asp:GridView ID="gvQuestions" runat="server">
    </asp:GridView>
</div>
</asp:Content>
