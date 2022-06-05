<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VTC._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Video Transcoder</h1>
    </div>

    <div class="row">
        <div class="col-md-4">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="303px" />
                <br />
                <asp:Button ID="UploadButton" runat="server" 
                    OnClick="Upload" Text="Upload file" />
                <br/>
                <asp:Label ID="FileUploadedLabel" runat="server" />
            <br/>
        <asp:Button ID="ConvertButton" runat="server" 
                    OnClick="Convert" Text="Convert" />
        <br/>
        </div>
    </div>


</asp:Content>
