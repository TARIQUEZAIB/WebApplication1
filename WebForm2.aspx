<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Required" CssClass="required"></asp:RequiredFieldValidator>
        </div>        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <%--<input type="button" id="mybtn" value="My Button" name="Test"/>--%>
        
    </form>
</body>
</html>
