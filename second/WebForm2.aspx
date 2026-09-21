<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="second.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 389px;
            width: 527px;
            margin-left: 407px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="name" runat="server" Text="name"></asp:Label>
            <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametxt" ErrorMessage="name is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="password" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordtxt" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="confrimpassword" runat="server" Text="confrimpassword"></asp:Label>
            <asp:TextBox ID="confrimpasswordtxt" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordtxt" ControlToValidate="confrimpasswordtxt" ErrorMessage="password does not match" ForeColor="Red"></asp:CompareValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="email" runat="server" Text="email"></asp:Label>
            <asp:TextBox ID="emailtxt" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtxt" ErrorMessage="invalid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="contact_number" runat="server" Text="contact number"></asp:Label>
            <asp:TextBox ID="phonenumbertxt" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="phonenumbertxt" ErrorMessage="invalid number" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="registration" runat="server" Text="Registration Button" />
        </div>
    </form>
</body>
</html>
