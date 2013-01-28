<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientProfile.aspx.cs" Inherits="MAS.PatientProfile" MasterPageFile="MasterPage.Master" %>

<asp:Content runat="server" ID="hcontent" ContentPlaceHolderID="HeadContent"></asp:Content>
<asp:Content runat="server" ID="bodycontent" ContentPlaceHolderID="BodyContent">
    
    <asp:Label runat="server" ID="lblFirstName" Text="First Name"></asp:Label>
    <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblLastName" Text="Last Name"></asp:Label>
    <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblAddress" Text="Address"></asp:Label>
    <asp:TextBox runat="server" ID="txtAddress"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblZip" Text="Zip Code"></asp:Label>
    <asp:TextBox runat="server" ID="txtZipCode"></asp:TextBox>
    
    
    <asp:Label runat="server" ID="lblCity" Text="City"></asp:Label>
    <asp:TextBox runat="server" ID="txtCity"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblCountry" Text="Country"></asp:Label>
    <asp:TextBox runat="server" ID="txtCountry"></asp:TextBox>
    
    
    <asp:Label runat="server" ID="lblHomePhone" Text="Home Phone"></asp:Label>
    <asp:TextBox runat="server" ID="txtHomePhone"></asp:TextBox>
    
    <asp:Label runat="server" ID="lbl" Text="Gender"></asp:Label>
    <asp:DropDownList runat="server" ID="ddlGender">
       <asp:ListItem Value="1">Male</asp:ListItem>
       <asp:ListItem Value="2">Female</asp:ListItem>
    </asp:DropDownList>
    
     <asp:Label runat="server" ID="lblWorkPhone" Text="Home Phone"></asp:Label>
    <asp:TextBox runat="server" ID="txtWorkPhone"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblSSN" Text="Social Security No."></asp:Label>
    <asp:TextBox runat="server" ID="txtSSN"></asp:TextBox>

    <asp:Label runat="server" ID="lblOther" Text="Other"></asp:Label>
    <asp:TextBox runat="server" ID="txtOther"></asp:TextBox>
    

    <asp:Label runat="server" ID="lblMaritalStatus" Text="Gender"></asp:Label>
    <asp:DropDownList runat="server" ID="ddlMaritalStatus">
       <asp:ListItem Value="1">Single</asp:ListItem>
       <asp:ListItem Value="2">Married</asp:ListItem>
    </asp:DropDownList>
    
     <asp:Label runat="server" ID="lblEmail" Text="Email"></asp:Label>
    <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>

    <asp:Label runat="server" ID="lblDOB" Text="Date of Birth"></asp:Label>
    <asp:TextBox runat="server" ID="txtDOB"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblPassword" Text="Password"></asp:Label>
    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
    
    <asp:Label runat="server" ID="lblPasswordConfirm" Text="Confirm Password"></asp:Label>
    <asp:TextBox runat="server" ID="txtPasswordConfirm" TextMode="Password"></asp:TextBox>
    

    <asp:Button runat="server" ID="btnSave" OnClick="BtnSaveClick"/>
</asp:Content>
