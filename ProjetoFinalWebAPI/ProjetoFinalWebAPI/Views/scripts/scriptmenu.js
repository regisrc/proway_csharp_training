$(document).ready(() => {
    
    var logado = localStorage.Logado; 
    if(logado == null){
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/index.html"
        window.location.replace(url);   
    }

    $('#card_div').hide();
    $('#div_principal').hide();
    $('#div_principal').fadeIn(500);
    $('#card_div').show(1000);
   

    $('#btn_logout').click(() => {
        localStorage.removeItem('Logado'); 
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/index.html"
        window.location.replace(url);   
    });

    $('#btn_list').click(() => {
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/listUsuario.html"
        window.location.replace(url);   
    });
});