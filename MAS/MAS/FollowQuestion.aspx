<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="FollowQuestion.aspx.cs" Inherits="MAS.FollowQuestion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" runat="server">
    <div class="marginleft50">
        <div style="margin-left:12px;">
            <div class="lbldiv floatleft">
                <asp:Label ID="lblsubject" CssClass="lblstyle" runat="server" Text="Subject"></asp:Label>
            </div>
            <div>
                <asp:TextBox runat="server" CssClass="longtxtbxstyle" ID="txtbxsubject"></asp:TextBox>
            </div>
        </div>
        <div>
            <asp:GridView ID="gvComments" runat="server" CellPadding="0" CellSpacing="0" ForeColor="#333333"
                GridLines="None" ShowHeader="false" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="lbldiv floatleft">
                                <asp:Label ID="lblusername" CssClass="lblstyle" runat="server" Text="User Name"></asp:Label>
                            </div>
                            <div>
<%--                            <div class="divcommentstyle" id="divcomment" runat="server"> asfsadf asf saf sdf sad fsdf</div>
--%>                             <asp:TextBox runat="server" Enabled="false" CssClass="chattxtstyle" ID="txtareaquestion" TextMode="MultiLine">
                                </asp:TextBox></div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <%--  <AlternatingRowStyle BackColor="#ECE8DF" />--%>
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
        <div style="margin-left:12px;margin-top:-13px">
            <div class="lbldiv floatleft">
                <asp:Label ID="lblusername" CssClass="lblstyle" runat="server" Text="User Name"></asp:Label>
            </div>
            <asp:TextBox runat="server" CssClass="chattxtstyle" ID="txtareacomment"  TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="commentRequiredFieldValidator" runat="server" 
                Text="*" ForeColor="Red" ControlToValidate="txtareacomment"></asp:RequiredFieldValidator>
        </div>
        <div style="padding:12px;">
            <asp:Button ID="btnCancel" CssClass="btnstyle floatright" runat="server" Text="Cancel" CausesValidation="false"
                OnClick="btnCancel_Click" />
            <asp:Button ID="btnSend" CssClass="btnstyle floatright" runat="server" Text="Send" CausesValidation="true"
                OnClick="btnSend_Click" />
        </div>
    </div>
</asp:Content>
