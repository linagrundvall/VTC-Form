<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VTC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Video Transcoder</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:FileUpload ID="UploadedFile"
                runat="server"
                Width="303px" />
            <br />
            <asp:Button ID="UploadButton"
                runat="server"
                OnClick="Upload"
                Text="Upload file" />
            <br />
            <asp:Label ID="FileUploadedLabel"
                runat="server" />
            <br />

            <asp:DropDownList ID="FormatList"
                AutoPostBack="True"
                OnSelectedIndexChanged="Selection_Change"
                runat="server">
                <asp:ListItem Selected="True" Value="Start"> Choose format </asp:ListItem>
                <asp:ListItem Value="Avi"> Avi </asp:ListItem>
                <asp:ListItem Value="Mov"> Mov </asp:ListItem>
                <asp:ListItem Value="Mp4"> Mp4 </asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="ConvertButton"
                runat="server"
                OnClick="Convert"
                Text="Convert" />
            <br />
            <asp:Label ID="FileConvertedLabel" runat="server" />



        </div>
    </div>


</asp:Content>
