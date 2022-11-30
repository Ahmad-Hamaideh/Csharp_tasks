<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="calculator.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .ButtonStyle
        {
            width=60px;
            hight= 40px ;
            margin = 20px ; 
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txt"  ReadOnly="true" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" CssClass=".ButtonStyle" runat="server" Text="7" OnClick ="btnF_Click"/>
            <asp:Button ID="Button2" runat="server" Text="8" OnClick ="btnF_Click"/>
            <asp:Button ID="Button3" runat="server" Text="9" OnClick ="btnF_Click"/>
        </div>
        <div>
            <asp:Button ID="Button4" runat="server" Text="4" OnClick ="btnF_Click" />
            <asp:Button ID="Button5" runat="server" Text="5" OnClick ="btnF_Click"/>
            <asp:Button ID="Button6" runat="server" Text="6" OnClick ="btnF_Click"/>
        </div>
        <div>
            <asp:Button ID="Button7" runat="server" Text="1" OnClick ="btnF_Click"/>
            <asp:Button ID="Button8" runat="server" Text="2" OnClick ="btnF_Click"/>
            <asp:Button ID="Button9" runat="server" Text="3" OnClick ="btnF_Click" />
        </div>
        <div>
            <asp:Button ID="Button10" runat="server" Text="0" OnClick ="btnF_Click" />
        </div>
        <div>
            <asp:Button ID="add" runat="server" Text="+" OnClick="add_Click" />  <asp:Button ID="Button12" runat="server" Text="-" OnClick="add_Click" /><br />
            <asp:Button ID="Button13" runat="server" Text="/"  OnClick="add_Click"/>   <asp:Button ID="Button14" runat="server" Text="*" OnClick="add_Click"/>
        </div>
        <div>
            <asp:Button ID="sum" runat="server" Text="="  OnClick="sum_Click"/>
            <asp:TextBox ID="hidd" Visible="false" runat="server"></asp:TextBox>
        <asp:TextBox ID="hidd2" Visible="false" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
