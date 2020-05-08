<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormEmployee.aspx.cs" Inherits="Lab1_final.Gui.WebFormEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style10 {
            height: 76px;
        }
        .auto-style12 {
            width: 193px;
            height: 76px;
        }
        .auto-style13 {
            height: 61px;
        }
        .auto-style15 {
            width: 380px;
            height: 61px;
            font-size: larger;
            color: #3366FF;
        }
        .auto-style16 {
            position: relative;
            left: 9px;
            top: 4px;
            width: 184px;
        }
        .auto-style17 {
            height: 61px;
            width: 136px;
        }
        .auto-style20 {
            height: 76px;
            width: 136px;
        }
        .auto-style21 {
            position: relative;
            left: 11px;
            top: 3px;
            width: 88px;
        }
        .auto-style24 {
            height: 70px;
        }
        .auto-style25 {
            height: 43px;
        }
        .auto-style32 {
            height: 76px;
            width: 144px;
        }
        .auto-style33 {
            height: 43px;
            color: #3399FF;
        }
        .auto-style34 {
            width: 218px;
            height: 76px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style17"></td>
                <td class="auto-style15" colspan="2">
                    Search Appartments :</td>
                <td class="auto-style13" colspan="2"></td>
                <td class="auto-style13"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="LabelSearchBy" runat="server" Text="Search By :" ForeColor="Black"></asp:Label>
                </td>
                <td class="auto-style34">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style16" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Please Choose:</asp:ListItem>
                        <asp:ListItem>AppartmentId</asp:ListItem>
                        <asp:ListItem>NumberOfRoom</asp:ListItem>
                        <asp:ListItem>NumberOfBath</asp:ListItem>
                        <asp:ListItem>NumberOfParking</asp:ListItem>
                        <asp:ListItem>FloorNum</asp:ListItem>
                        <asp:ListItem>PricePerMonth</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;</td>
                <td class="auto-style12">
                    &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="&lt;=" Visible="False"></asp:Label>
                    <asp:TextBox ID="TextBoxSearch" runat="server" CssClass="auto-style21"></asp:TextBox>
                </td>
                <td class="auto-style32">
                    <asp:Button ID="ButtonSearch" runat="server" Text="Search" Width="95px" OnClick="ButtonSearch_Click"/>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="ButtonReturn" runat="server" OnClick="ButtonReturn_Click" Text="Return Back" Width="99px" />
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style10"></td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style33">
                    Appartments List :</td>
                <td class="auto-style25"></td>
            </tr>
            <tr>
                <td class="auto-style24">
                    <asp:GridView ID="GridViewEmployee" runat="server" Width="1087px">
                    </asp:GridView>
                </td>
                <td class="auto-style24"></td>
            </tr>
        </table>
    </form>
</body>
</html>
