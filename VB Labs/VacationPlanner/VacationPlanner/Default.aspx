<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="VacationPlanner._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Plan Your Vacation!</h1>
        <p class="lead">Choose from our most popular vacation destinations!<table style="width: 161%; height: 286px;">
            <tr>
                <td style="height: 29px; width: 600px">
                    <asp:Image ID="picMain" runat="server" EnableTheming="True" ImageUrl="~/Resources/hawaii_vacation.jpg" style="margin-right: 0px" Width="550px" />
                </td>
                <td style="height: 29px; width: 37px"></td>
                <td style="height: 29px">
                    <asp:RadioButtonList ID="radVacations" runat="server" Width="112px">
                        <asp:ListItem>Hawaii</asp:ListItem>
                        <asp:ListItem>Japan</asp:ListItem>
                        <asp:ListItem>Mexico</asp:ListItem>
                        <asp:ListItem>Paris</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td style="width: 600px">&nbsp;</td>
                <td style="width: 37px">
                    <asp:Label ID="lblGuests" runat="server" Text="Guests:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGuests" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvGuests" runat="server" ControlToValidate="txtGuests" ErrorMessage="Enter Guests" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="height: 29px; width: 600px"></td>
                <td style="width: 37px; height: 29px">Total:</td>
                <td style="height: 29px">
                    <asp:Label ID="lblTotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 29px; width: 600px">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                </td>
                <td style="width: 37px; height: 29px"></td>
                <td style="height: 29px">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" />
                </td>
            </tr>
            </table>
        </p>
    </div>

    </asp:Content>
