<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Pessoas.aspx.cs" Inherits="WebApplicationInterfaceXPTO.Pessoas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="divTable">
        <div class="divTableBody">
            <div class="divTableRow">
                <div class="divTableCell"><asp:FileUpload ID="fileUploadPessoas" Width="120px" onchange="this.form.submit()" runat="server" /></div>
                <div class="divTableCell">
                    <asp:Button ID="btnSalvarArquivoPessoas" runat="server" Text="Salvar Arquivo" OnClick="btnSalvarArquivoPessoas_Click" />
                    

                </div>
            </div>
            
            <div class="divTableRow" style="">
                <div class="divTableCell"><asp:GridView ID="gvPessoas" runat="server"></asp:GridView></div>
                
            </div>
        </div>
    </div>
  


</asp:Content>
