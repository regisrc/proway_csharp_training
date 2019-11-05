$(document).ready(() => {

    var logado = localStorage.Logado; 
    if(logado != null){
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/menu.html"
        window.location.replace(url);   
    }

    $('#card_div').hide();
    $('#div_principal').hide();
    $('#div_principal').fadeIn(500);
    $('#card_div').show(1000);
   
    
    $('#btn_enviar').click(() => {
        var formul = $('#form_entrada').serializeArray();
        var url = "http://localhost:58691/api/Usuarios/validate";
        var obj = {
            login: formul[0].value,
            senha: formul[1].value
        };

        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(obj),
            success: function(data) { 
                if(data == true){
                    localStorage.setItem('Logado', 'True');  
                    url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/menu.html"
                    window.location.replace(url);
                } else{
                    alert("Não está correto!")
                }
            },
            contentType: "application/json",
            dataType: 'json'
        });

    });

    $('#btn_cadastrar').click(() => {
        url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/cadastroUsuario.html"
        window.location.replace(url);
    });
});