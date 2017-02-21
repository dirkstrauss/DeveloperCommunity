<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DebugClientSide._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:DropDownList ID="ddlCities" runat="server" onchange="checkSelection()" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true"></asp:DropDownList>
        <asp:Label ID="lblCity" runat="server"></asp:Label>
    </div>
    
    <script type = "text/javascript">
        function checkSelection()
        {
            var dl = document.getElementById("<%=ddlCities.ClientID %>");
            var selectedText = dl.textContent;
            var selectedIndex = dl.selectedIndex;
            
            var label = document.getElementById("<%=lblCity.ClientID %>");
            label.innerText = selectedText;

            if (selectedIndex == 0)
            {
                label.style.color = 'Black';
                label.innerText = "";
            }
            if (selectedIndex == 1) {
                label.style.color = 'Red';
            }
            if (selectedIndex == 2) {
                label.style.color = 'Blue';
            }
            if (selectedIndex == 3) {
                label.style.color = 'Green';
            }
            if (selectedIndex == 4) {
                label.style.color = 'Orange';
            }
        }        
    </script>
</asp:Content>
