<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="QuizPlants.Views.EditPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Edit Plant</h1>
            <div>
                <asp:Label ID="NameLbl" runat="server" Text="Plant Name : "></asp:Label>
                <asp:TextBox ID="NameTb" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="TypeLbl" runat="server" Text="Plant Type : "></asp:Label>
                <asp:DropDownList ID="TypeDDL" runat="server">
                    <asp:ListItem Text="Monokotil" Value="Monokotil" />
                    <asp:ListItem Text="Dikotil" Value="Dikotil" />
                </asp:DropDownList>
            </div>
            <div>
                <asp:Label ID="OriginLbl" runat="server" Text="Plant Origin : "></asp:Label>
                <asp:TextBox ID="OriginTb" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="EditBtn" runat="server" Text="Edit Plant" OnClick="EditBtn_Click" />
            </div>
            <asp:Label ID="ErrorMsg" runat="server" Text=" " ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
