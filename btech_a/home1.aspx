<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="home1.aspx.cs" Inherits="btech_a.home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;<strong>Registration Page</strong></p>
    <p>
        Name:
        <asp:TextBox ID="NAMETXT" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NAMETXT" ErrorMessage="ENTER NAME" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    </p>
    <p>
        email:
        <asp:TextBox ID="EMAILTXT" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EMAILTXT" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EMAILTXT" ErrorMessage="EMAIL IS INVALID" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>
        Password:
        <asp:TextBox ID="PASSTXT" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="PASSTXT" ErrorMessage="ENTER PASSWORD" ForeColor="#FF3300"></asp:RequiredFieldValidator>
    </p>
    <p>
        Confrim Password:
        <asp:TextBox ID="CPASSTXT" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="CPASSTXT" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PASSTXT" ControlToValidate="CPASSTXT" ErrorMessage="PASSWORD DOES NOT MATCH" ForeColor="#FF3300"></asp:CompareValidator>
    </p>
    <p>
        city:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>MORBI</asp:ListItem>
            <asp:ListItem>RJKT</asp:ListItem>
            <asp:ListItem>JUNAGADH</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Contact:
        <asp:TextBox ID="CONTACT_TXT" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="CONTACT_TXT" ErrorMessage="*" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="CONTACT_TXT" ErrorMessage="contact must 10 digit" ForeColor="#FF3300" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
    </p>
    <p>
        <asp:Button ID="REGISTER_BTN" runat="server" Text="REGISTER" OnClick="REGISTER_BTN_Click" />
&nbsp;<asp:Button ID="CANCEL_BTN" runat="server" Text="CANCEL" />
    </p>
</asp:Content>
