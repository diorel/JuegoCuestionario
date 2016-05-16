<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JurgoWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h2>Bienvenido ponte a prueba con tus conocimientos  y sorpréndete   <span class="glyphicon glyphicon-education" aria-hidden="true"></span> </h2>
  <br />  

  <asp:Panel runat="server" ID="RegistroPanel" CssClass="row">
  <div class="col-md-12">
        
  <div class="form-group">
    <label for="inputEmail3" class="col-sm-2 control-label">Nombre</label>
    <div class="col-sm-10">
      <asp:TextBox ID="NombreTextBox" runat="server" CssClass="form-control"></asp:TextBox>

    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
        ControlToValidate="NombreTextBox"
        ErrorMessage="El nombre es requerido"
        ForeColor="Red">
    </asp:RequiredFieldValidator>

    </div>
  </div>
  <div class="form-group">
    <label for="inputPassword3" class="col-sm-2 control-label">Departamento</label>
    <div class="col-sm-10">
      <asp:TextBox ID="DepartamentoTextBox" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
  </div>
  </div>
 <div class="row">
  <div class="col-xs-12">
      <div id="botonC" style="padding-left: 40%; padding-top:1%; padding-bottom: 2%;" >
          <asp:Button ID="IniciarButton"  runat="server" Text="JUGAR"  CssClass="btn btn-warning" Height="80px" Width="200px" OnClick="IniciarButton_Click" > </asp:Button>
      </div>
  </div>
</div>

</asp:Panel>

    <asp:Panel runat="server" ID="PreguntaPanel">
        <div style="color:#B18904; font-size:x-large">
        <h4>Pregunta #<asp:Label runat="server" ID="IndiceLabel"  />
        </h4>
            </div>
        <hr />
        <div style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif">
        <asp:Label runat="server" ID="PreguntaLabel" />
        </div>
        <hr />
        <div class="text-center">
            <asp:Button runat="server" ID="VerdaderButton" Text="Verdadero" CommandArgument="True" CssClass="btn btn-primary" CommandName="RESPONDER" OnCommand="Responder" />
            &nbsp;&nbsp;
            <asp:Button runat="server" ID="FalsoButton" Text="Falso" CommandArgument="False" CssClass="btn btn-success" CommandName="RESPONDER" OnCommand="Responder" Height="36px" Width="90px" />
        </div>
    </asp:Panel>

     <asp:Panel runat="server" ID="ResultadoPanel">
       <h1> Tus resultados fueron</h1>
         <table>
             <tr>
                 <td><asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label></td>
                  <td><asp:Label ID="NombreLabel" runat="server" /></td>
             
             </tr>
             <tr>
                 <td><asp:Label ID="Label2" runat="server" Text="Tu calificacion fue:"></asp:Label></td>
                 <td><asp:Label ID="ResultadoLabel" runat="server" /></td>
             </tr>
             <tr>
                 <td><asp:Label ID="Label3" runat="server" Text="Fecha:"></asp:Label></td>
                 <td><asp:Label ID="InicoLabel" runat="server" Text="Label"></asp:Label></td>   
             </tr>
             <tr>
                
                     <asp:Panel ID="Panel1" runat="server" Visible="false">
                         <td>muy bien buen resultado
                             <img src="img/1463260251_emoticon.png" />
                         </td>
                     </asp:Panel>
                     <asp:Panel ID="Panel2" runat="server" Visible="false">
                         <td>puff tienes que esudiar
                             <img src="img/1463260178_bad_smile.png" />
                         </td>
                     </asp:Panel>
                     <td>
                         <button class="btn btn-primary btn-block" type="button">
                             Salir
                         </button>
                     </td>
        
             </tr>
         </table>
         <div style="padding-left:40%; padding-right:30%" >
             

         </div>
           
    </asp:Panel>


</asp:Content>
