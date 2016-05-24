<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JurgoWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="color:#0C6937">
            <h2 >Bienvenido pon a prueba con tus conocimientos  y sorpréndete   <span class="glyphicon glyphicon-education" aria-hidden="true"></span> </h2>
    </div>
  <br />  
  <asp:Panel runat="server" ID="RegistroPanel" CssClass="row">
  <div class="col-md-12">
        
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
        <div style="color:#F27920; font-size:x-large">
        <h2>Pregunta #<asp:Label runat="server" ID="IndiceLabel"  />
        </h2>
            </div>
        <hr />
        <div style="font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 25px;" >
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
      <div style="color:#F27920">
          <h1> Tu puntaje fue </h1>
          </div>
         <table>
             <tr>
                 <td><asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label></td>
                  <td><asp:Label ID="NombreLabel" runat="server" /></td>
                 <td></td>
                 <td></td>
                 <td>
                     

                 </td>
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
                         <td>Muy bien buen resultado felicidades
                             <img src="img/1463260251_emoticon.png" />
                         </td>
                     </asp:Panel>
                     <asp:Panel ID="Panel2" runat="server" Visible="false">
                         <td>Puff tienes que estudiar!!!
                             <img src="img/1463260178_bad_smile.png" />
                         </td>
                     </asp:Panel>
                
                     <td>
                        
                         &nbsp;
                     <%--     <button class="btn btn-warning btn-block"  type="button" onclick="window.print()" value="Imprimir">
                              imprimir
                              <span class="glyphicon glyphicon-print" aria-hidden="true"></span> 
                               </button>--%>

                 <button class="btn btn-success btn-block" type="button" onclick=" window.location.href='http://www.agentia.com.mx/' ">
                     Salir
                     <span class="glyphicon glyphicon-arrow-right" aria-hidden="true"></span>
                 </button>
             </td>

             </tr>
             <tr>
                 <td>

                 </td>
             </tr>
         </table>
         <table>
         </table>

         <h4>Tus resultados</h4>

         <div style=" background-color: #F4F4F4">

         
         <asp:Repeater ID="ResultadosRepeater" runat="server">
             <ItemTemplate>
                 <div class= '<%#Eval("Resultado")%>'>
                     <strong><%#Eval("ID") %>.-&nbsp;<%#Eval("Pregunta") %></strong><br /><span>Respuesta correcta:&nbsp;<%#Eval("Correcta") %></span>&nbsp;|&nbsp;
                     <span>Tu respuesta:&nbsp;<%#Eval("Respuesta") %></span></div>
             </ItemTemplate>
             <SeparatorTemplate>
                 <br />
             </SeparatorTemplate>
         </asp:Repeater>
             </div>
         <div style="padding-left:40%; padding-right:30%" >
         </div>
           
    </asp:Panel>


</asp:Content>
