<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="JurgoWeb.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/bootstrap-theme.css" rel="stylesheet" />

  <div class="row">
  <div class="col-md-12">
      <h2>Bienvenido para ingresar al juego favor de ingresar tus datos</h2>
  <br />    
        
 <form class="form-horizontal">
  <div class="form-group">
    <label for="inputEmail3" class="col-sm-2 control-label">Nombre</label>
    <div class="col-sm-10">
      <asp:TextBox ID="NombreTextBox" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
  </div>
  <div class="form-group">
    <label for="inputPassword3" class="col-sm-2 control-label">Departamento</label>
    <div class="col-sm-10">
      <asp:TextBox ID="DepartamentoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
  </div>
</form>
  </div>
 <div class="row">
  <div class="col-xs-12">
      <div id="botonC" style="padding-left: 40%; padding-top:1%; padding-bottom: 2%;" >
          <asp:Button ID="IniciarButton"  runat="server" Text="JUGAR"  CssClass="btn btn-warning" Height="80px" Width="200px" />
      </div>
  </div>
</div>


</div>

</asp:Content>
