<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true" CodeBehind="home.aspx.cs"
    Inherits="second.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Script Manager -->
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <!-- Update Panel -->
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <!-- Ad Rotator -->
            <asp:AdRotator
                ID="AdRotator1"
                runat="server"
                AdvertisementFile="~/XMLFile1.xml"
                Width="1000px"
                Height="500px" />

            <!-- Timer -->
            <asp:Timer
                ID="Timer1"
                runat="server"
                Interval="200"
                OnTick="Timer1_Tick">
            </asp:Timer>

        </ContentTemplate>

        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>

    </asp:UpdatePanel>

</asp:Content>