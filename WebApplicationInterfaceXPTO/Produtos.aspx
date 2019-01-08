<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="WebApplicationInterfaceXPTO.Produtos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="divTable">
        <div class="divTableBody">
            <div class="divTableRow">
                <div class="divTableCell">

                    <asp:FileUpload ID="fileUploadProdutos" Width="120px" onchange="this.form.submit()" runat="server" />
                </div>
                <div class="divTableCell">
                    
                    
                    <asp:Button ID="btnSalvarProdutos" runat="server" Text="Salvar Produtos" OnClick="btnSalvarProdutos_Click" />
                </div>
            </div>
            
            <div class="divTableRow" style="">
                <asp:GridView ID="gvProdutos" runat="server"></asp:GridView>
                
            </div>
        </div>
    </div>

</asp:Content>
