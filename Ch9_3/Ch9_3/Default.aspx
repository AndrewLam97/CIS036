<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Ch9_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Golf Tee Times</h1>
        <p class="lead">Tee Time Signup</p>
        <p>Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </p>
        <p>Tee Time:<asp:DropDownList ID="lstTimes" runat="server">
            <asp:ListItem>8AM-9AM</asp:ListItem>
            <asp:ListItem>9AM-10AM</asp:ListItem>
            <asp:ListItem>10AM-11AM</asp:ListItem>
            <asp:ListItem>11AM-Noon</asp:ListItem>
            <asp:ListItem>Noon-1PM</asp:ListItem>
            <asp:ListItem>1PM-2PM</asp:ListItem>
            <asp:ListItem>2PM-3PM</asp:ListItem>
            <asp:ListItem>3PM-4PM</asp:ListItem>
            <asp:ListItem>4PM-5PM</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </p>
        <p>Date:<asp:Calendar ID="calDate" runat="server"></asp:Calendar>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
