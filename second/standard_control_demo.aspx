<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="standard_control_demo.aspx.cs" Inherits="second.standard_control_demo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:FileUpload ID="FileUpload2" runat="server" />

    <br /><br />

    <asp:Button
        ID="Button1"
        runat="server"
        Text="Upload"
        OnClick="Button1_Click" />

    <br /><br />

    <asp:Label ID="Label1" runat="server"></asp:Label>
</asp:Content>
