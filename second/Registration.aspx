<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site1.Master"
AutoEventWireup="true" CodeBehind="Registration.aspx.cs"
Inherits="second.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container mt-5" style="max-width:500px;">
    <h2 class="text-center mb-4">Registration</h2>

    <div class="mb-3">
        <label>Full Name</label>
        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label>Mobile</label>
        <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="mb-3">
        <label>Password</label>
        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <div class="mb-3">
        <label>Address</label>
        <br />
        <asp:TextBox ID="txtAddress"
            runat="server"
            TextMode="MultiLine"
            Rows="3"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <asp:Button
        ID="btnRegister"
        runat="server"
        Text="Register"
        CssClass="btn btn-success w-100"
        OnClick="btnRegister_Click" />

</div>

</asp:Content>