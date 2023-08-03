<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="Laboratorio_de_DBP.Auxiliar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title>Cookies Alumno</title>

    <script src="/Scripts/bootstrap.js"></script>
    <script src="./Scripts/jquery-3.4.1.js" defer></script>
    <script type="text/javascript" defer>
        function ButtonMostrar() {

            let cookies = document.cookie.split(';');
            let valor1, valor2;
            for (let i = 0; i < cookies.length; i++) {
                let cookie = cookies[i].trim();
                if (cookie.startsWith('sexo=')) {
                    valor1 = cookie.substring('sexo='.length);
                } else if (cookie.startsWith('ciudad=')) {
                    valor2 = cookie.substring('ciudad='.length);
                }
            }
            document.getElementById("areaCookie").value = "UserInfo:\n Sexo: " + valor1 + "\nCiudad: " + valor2;
            return false;

            
        }

        function callAjax() {
            let send = $('#TextBoxCookie').val();

            $.ajax({
                url: 'Auxiliar.aspx/getInformacion',
                type: 'POST',
                async: true,
                data: '{ valor: "' + send + '" }',
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: exito
            });
            return false;
        }
        function exito(data) {
            var returnS = data.d;
            $('#TextBoxAjax').val(data.d);
            $('#TextBoxAjax').css("visibility", "visible");
            return false;
        }
    </script>
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
                <asp:Button ID="ButtonCookie" class="btn btn-dark" runat="server" Text="Mostrar Cookie" OnClientClick="return ButtonMostrar();" />
            </div>
            <div class="mb-2">
                <asp:Button ID="Button1" class="btn btn-dark" runat="server" Text="Cerrar Sesion" OnClick="ButtonCerrar" />
            </div>
            <div class="mb-2 row">
                <div class="col-md-6">
                    <asp:TextBox ID="areaCookie" runat="server" TextMode="MultiLine" Rows="4" class="form-control" placeholder="Requerimiento"></asp:TextBox>
                </div>
            </div>
            <div class="row mt-3">
                <div class="cols-sm-2">
                    <asp:Button ID="ButtonAjax" runat="server" Text="Ajax"
                        OnClientClick="return callAjax();" class="btn btn-success btn-lg" />
                </div>
            </div>
            <div class="row">
                <div class="form-group row mt-3">
                    <div class="col-sm-9">
                        <div class="form-floating row mt-3">
                            <asp:TextBox ID="TextBoxAjax" runat="server" class="form-control"
                                Style="visibility: hidden"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
