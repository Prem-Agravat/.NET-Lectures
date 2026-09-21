<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site1.Master"
AutoEventWireup="true" CodeBehind="Login.aspx.cs"
Inherits="second.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container mt-5" style="max-width:400px;">

    <h2 class="text-center mb-4">Login</h2>

    <div class="mb-3">
        <label>Email</label>
        <asp:TextBox
            ID="txtEmail"
            runat="server"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <div class="mb-3">
        <label>Password</label>
        <asp:TextBox
            ID="txtPassword"
            runat="server"
            TextMode="Password"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <asp:Button
        ID="btnLogin"
        runat="server"
        Text="Login"
        CssClass="btn btn-primary w-100"
        OnClick="btnLogin_Click" />

</div>

</asp:Content>