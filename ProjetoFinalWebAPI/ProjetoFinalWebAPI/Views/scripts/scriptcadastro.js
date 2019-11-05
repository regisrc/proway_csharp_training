$(document).ready(() => {
    
    var logado = localStorage.Logado; 
    if(logado != null){
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/index.html"
        window.location.replace(url);   
    }

    $('#card_div').hide();
    $('#div_principal').hide();
    $('#div_principal').fadeIn(500);
    $('#card_div').show(1000);
   

    $('#btn_enviar').click(() => {
        var formul = $('#form_entrada').serializeArray();
        var url = "http://localhost:58691/api/Usuarios";
        var obj = {
            login: formul[0].value,
            senha: formul[1].value,
            nome: formul[2].value,
            email: formul[3].value,
        };

        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(obj),
            success: function(data) { 
                    url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/index.html"
                    window.location.replace(url);
            },
            contentType: "application/json",
            dataType: 'json'
        });
    });
    
    $('#btn_voltar').click(() => {
        localStorage.removeItem('Logado'); 
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/index.html"
        window.location.replace(url);   
    });
    
});