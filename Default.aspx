<%@ Page Title="stencylxd's works" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestWebsite._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="myName" runat="server" Text="Label" Font-Size="XX-Large" Font-Bold="true">stencylxd</asp:Label><br /><br />
    <asp:Label ID="desc1" runat="server" Font-Size="Medium" Text="Label">Hello! I am stencylxd, a computer programmer.</asp:Label><br />
    <asp:Label ID="desc2" runat="server" Font-Size="Medium" Text="Label">I make things in Ruby, C# (which this website is made in), and some other langs.</asp:Label><br />
    <asp:Label ID="desc3" runat="server" Font-Size="Medium" Text="Label">Below you can find links to my works and maybe some pinned software.</asp:Label><br />
    <br /><asp:Button ID="sc1" runat="server" Text="My Github" ToolTip="My github, where most source code is stored." onClick="sc1_Click"/>
    <asp:Button ID="sc2" runat="server" Text="My YouTube Channel" ToolTip="My garbage YouTube channel." onClick="sc2_Click"/>
</asp:Content>