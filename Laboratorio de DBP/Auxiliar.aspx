<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="Laboratorio_de_DBP.Auxiliar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Cookies Alumno</title>
    <script defer type="text/javascript" src="/Scripts/Forms/formStudent.js"></script>
    <script defer src="/Scripts/bootstrap.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class=" mt-4 mb-2 row">
                <div class="col">
                    <asp:Label ID="Usuario" runat="server" Text="Usuario" CssClass="form-label"></asp:Label>
                </div>
            </div>
            <div class="mb-2 row">
                <div class="col">
                    <asp:Label ID="Nombre" runat="server" Text="Nombre" CssClass="form-label"></asp:Label>
                </div>
            </div>
            <div class="mb-2 row">
                <div class="col">
                    <asp:Label ID="Apellido" runat="server" Text="Apellido" CssClass="form-label"></asp:Label>
                </div>
            </div>
            
            <div class="mb-2">
                <asp:Button ID="ButtonCookie" class="btn btn-dark" UseSubmitBehavior="false" runat="server" Text="Mostrar Cookie" OnClick="ButtonCookie_Click"/>
            </div>
            <div class="mb-2 row">
                <div class="col-md-6">
                    <asp:TextBox ID="Cookie" runat="server" Rows="4" class="form-control" placeholder="Requerimiento"></asp:TextBox>
                </div>
            </div>
        </div>

    </form>
</body>
</html>