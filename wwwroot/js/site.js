// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Cadastrar()
{
    let parametros = {
        Nome: $("#nome").val(),
        Email: $("#email").val(),
        Mensagem: $("#mensagem").val()
    }
    
    $.post('/Home/Cadastrar',parametros)

    .done(
        function(data)
        {
            if (data.status=="OK") 
            {
                $("#frm").after("<h3>Dado cadastrado com sucesso!</h3>");
                $("#frm").hide();
            } 
            else
            {
                $("#frm").after("<h3>"+data.mensagem+"</h3>");
            }
        }
    ) 
    
    .fail(
    function()
    {
        alert("Ocorreu algo errado!");
    }
    );

}

$(document).ready(
    function()
    {
        $("#frmCadastro").submit
        (
            function(e)
            {
                e.preventDefault();
                Cadastrar();
            }
        );
    }
);
