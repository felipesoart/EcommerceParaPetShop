<%@ Page Title="" Language="C#" MasterPageFile="~/adm/MasterAdm.Master" AutoEventWireup="true" CodeBehind="usuarioForm.aspx.cs" Inherits="PetShopDoBairro.adm.usuarioForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">




    <div class="card shadow">
        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Cadastro do Usuário</h6>
        </div>
        <div class="card-body">
            <div class="form-group">
                <label>Nome</label>
                <asp:TextBox runat="server" class="form-control" ID="txtNome" />
            </div>
       <div class="form-group">
                <label>CPF/CNPJ</label>
                <asp:TextBox runat="server" class="form-control" ID="txtCPFCNPJ" />
            </div>
          <div class="form-group">
                <label>Tipo de pessoa</label>
                <asp:TextBox runat="server" class="form-control" ID="txtTipoPessoa" />
            </div>
           <div class="form-group">
                <label>E-mail</label>
                <asp:TextBox runat="server" type="email" class="form-control" ID="txtEmail" placeholder="nome@exemplo.com" />
            </div>
            <div class="form-group">
                <label>Senha</label>
                <asp:TextBox runat="server" TextMode="Password" class="form-control" ID="txtSenha" />
            </div>
            <div class="form-group">               
                <asp:CheckBox runat="server" ID="ckbAtivo"/>
                <label>Ativo</label>
            </div>
            <div class="form-group">
                <asp:Button runat="server" ID="btnSalvar" Text="Salvar" class="btn btn-primary" OnClick="btnSalvar_Click"/>
            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceScript" runat="server">
</asp:Content>
