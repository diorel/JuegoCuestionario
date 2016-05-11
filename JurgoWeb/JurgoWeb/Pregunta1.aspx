<%@ Page Title="" Language="C#" MasterPageFile="~/Maqueta.Master" AutoEventWireup="true" CodeBehind="Pregunta1.aspx.cs" Inherits="JurgoWeb.Pregunta1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="css/bootstrap-theme.css" rel="stylesheet" />

   <div class="row">
     <div class="col-md-12"><h1> En Agentia somos especialistas en Servicios de Outsourcing </h1></div>
     <div class="col-md-6"><asp:button runat="server" text="Verdadero" /></div>
     <div class="col-md-6"><asp:button runat="server" text="Falso" /></div>
   </div>  
</asp:Content>
