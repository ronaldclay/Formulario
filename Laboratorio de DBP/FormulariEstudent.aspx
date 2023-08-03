<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormulariEstudent.aspx.cs" Inherits="Laboratorio_de_DBP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
    <script type="text/javascript" defer="defer" src="Scripts/Lab1/app.js"></script>
    <script src="./Scripts/jquery-3.4.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1>REGISTRO DE ALUMNOS</h1>
            <div class="row">
                <div class="col-md-2">
                    <label for="nombre">Nombre</label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox class="form-control" type="text" ID="Nombre" runat="server" placeholder="Nombre"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-2">
                    <label for="apellido">Apellido</label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox class="form-control" type="text" ID="Apellido" placeholder="Apellido" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3" style="display: none" id="divServidor">
                    <p id="contenidoServidor" class="form-control text-white" ></p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <asp:Label for="Sexo" runat="server">Sexo</asp:Label>
                </div>
                <div class="col-md-6">
                    <asp:Label runat="server">Masculino</asp:Label>
                    <asp:RadioButton ID="botonMasculino" runat="server" GroupName="Sexo"></asp:RadioButton>
                    <asp:Label runat="server">Feminino</asp:Label>
                    <asp:RadioButton ID="botonFemenino" runat="server" GroupName="Sexo"></asp:RadioButton>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-2">
                    <label for="email">Email</label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox class="form-control" type="text" ID="Email" placeholder="coreo@unsa.edu.pe" runat="server"></asp:TextBox>
                </div>
            </div>
            <br />

            <div class="row">
                <div class="col-md-2">
                    <label for="direccion">Direccion</label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox class="form-control" type="text" ID="Direccion" placeholder="Av/Numero de calle" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-1">
                    <label for="ciudad">Ciudad</label>
                </div>
                <div class="col-md-3">
                    <asp:DropDownList class="form-select" ID="ListaCiudad" runat="server"></asp:DropDownList>
                </div>
            </div>
            <br />

            <div class="row">
                <!-- Textarea -->
                <div class="col-9">
                    <textarea runat="server" class="form-control" id="Mensaje" placeholder="Requirimiento"></textarea>
                </div>
            </div>
            <br />
            <div class="text-center">
                <!-- Limpiar -->
                <asp:Button UseSubmitBehavior="false" runat="server" class="btn btn-warning" value="button" ID="botonLimpar" Text="Limpiar" OnClientClick="limpiar()"></asp:Button>
                <!-- enviar -->
                <asp:Button UseSubmitBehavior="true" data-bs-toggle="modal" data-bs-target="#exampleModal" ID="botonEnviar" runat="server" Text="Enviar" OnClientClick="var E = enviar(); return E;" class="btn btn-primary" OnClick="ButtonEnviar_Click"></asp:Button>

            </div>
            <div class="text-info">
                <asp:Label ID="Mostrar" runat="server" Text=""></asp:Label>
            </div>


        </div>
        <!-- Modal -->  
        <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content">
                    <div class="modal-body" id="nkf">
                    </div>
                    <div class="modal-footer">
                        <button onclick="closeuwu()" type="button" class="btn btn-danger" data-bs-dismiss="modal">Cerrar</button>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
