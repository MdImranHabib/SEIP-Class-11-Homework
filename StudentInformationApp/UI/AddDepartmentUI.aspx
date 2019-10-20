<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddDepartmentUI.aspx.cs" Inherits="StudentInformationApp.UI.AddDepartmentUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="container">
    <h2 class="alert bg-primary text-center">Add New Department</h2>
    <hr />
    <label id="lblShow" runat="server" class="col-md-offset-4 text-center text-success"></label>
    <br />
    <br />
    <div class="row">
        <div class="col-md-8 col-md-offset-2">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-md-4 control-label">Name :</label>
                    <input id="inputName" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="form-group">
                    <label class="col-md-4 control-label">Department Code :</label>
                    <input id="inputCode" runat="server" class="col-md-6 form-control" />
                </div>
                <div class="col-md-offset-4">
                    <asp:Button ID="btnSave" runat="server" BackColor="#009933" ForeColor="White" OnClick="btnSave_Click" Text="Save" BorderColor="#33CC33" Height="28px" Width="66px" />
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>
