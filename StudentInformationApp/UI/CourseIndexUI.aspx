<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseIndexUI.aspx.cs" Inherits="StudentInformationApp.UI.CourseIndexUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2 class="alert bg-primary text-center">Course List</h2>
    <hr />
    <asp:GridView ID="gridCourses" runat="server" AutoGenerateColumns="False" CellPadding="4" Font-Size="Medium" ForeColor="#333333" GridLines="None" Height="161px" HorizontalAlign="Center" Width="511px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        <Columns>
            <asp:TemplateField HeaderText="Course ID">
                <ItemTemplate>
                    <%#Eval("Id") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Name">
                <ItemTemplate>
                    <%#Eval("Name") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Code">
                <ItemTemplate>
                    <%#Eval("Code") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Course Credit">
                <ItemTemplate>
                    <%#Eval("Credit") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
