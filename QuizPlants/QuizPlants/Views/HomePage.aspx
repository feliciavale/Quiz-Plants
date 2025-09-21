<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="QuizPlants.Views.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home Page</h1>
            <div>
                <asp:GridView ID="PlantsGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="PlantsGV_RowDeleting" OnRowEditing="PlantsGV_RowEditing">
                    <Columns>
                        <asp:BoundField DataField="PlantId" HeaderText="Plant ID" SortExpression="PlantId" />
                        <asp:BoundField DataField="PlantName" HeaderText="Plant Name" SortExpression="PlantName" />
                        <asp:BoundField DataField="PlantType" HeaderText="Plant Type" SortExpression="PlantType" />
                        <asp:BoundField DataField="PlantOrigin" HeaderText="Plant Origin" SortExpression="PlantOrigin" />
                        <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
                    </Columns>
                </asp:GridView>
            </div> <br />
            <asp:Button ID="InsertBtn" runat="server" Text="Insert New Plant" OnClick="InsertBtn_Click" />
        </div>
    </form>
</body>
</html>
