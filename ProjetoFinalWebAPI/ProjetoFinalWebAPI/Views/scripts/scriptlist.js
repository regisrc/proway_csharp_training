$(document).ready(() => {

    var logado = localStorage.Logado; 
    if(logado == null){
        var url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/menu.html"
        window.location.replace(url);   
    }

    $('#card_div').hide();
    $('#div_principal').hide();
    $('#div_principal').fadeIn(500);
    $('#card_div').show(1000);
   
    var url = "http://localhost:58691/api/Usuarios";

    $.get(url, (data) => {
                var a;
                for (let index = 0; index < data.length; index++) { 
                    a = a + 
                        `<tr><th>${data[index].id}</th>
                        <td>${data[index].nome}</td>
                        <td>${data[index].email}</td>
                        <td>${data[index].login}</td>
                        <td><a href="#">Alterar</a></td></tr>
                        `;
                }
                $('#table_principal').append(
                    `<thead><th>ID</th>
                    <th>Nome</th>
                    <th>Email</th>
                    <th>Login</th></thead>
                    <tbody>${a}</tbody>
                    `);
    });
    

    $('#btn_voltar').click(() => {
        url = "file:///C:/Users/hbsis/source/repos/F34R1337/TreinamentoCSharpProWay/ProjetoFinalWebAPI/ProjetoFinalWebAPI/Views/menu.html"
        window.location.replace(url);
    });
});