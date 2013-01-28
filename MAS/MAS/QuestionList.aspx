<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="QuestionList.aspx.cs" Inherits="MAS.QuestionList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
<div style="height:20px;">
    <asp:Button ID="btnAddNew" CssClass="btnstyle floatright" runat="server" 
        Text="Create" onclick="btnAddNew_Click" />
</div>
<div style="margin-top:20px;">
    <asp:GridView ID="gvQuestions" runat="server" CellPadding="0" CellSpacing="0"  
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="#ECE8DF" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#8F8363" Height="35px" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle VerticalAlign="Middle" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
</div>
</asp:Content>
