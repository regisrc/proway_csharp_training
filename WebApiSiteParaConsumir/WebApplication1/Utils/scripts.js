$(document).ready(() => {

    $('#button_form').click(() => {
        var formCampos = $('#form_principal').serializeArray();
        console.log(formCampos)
        $.get(`http://loxcalhost:60111/api/CalculaIMC?peso=${formCampos[0].value}&altura=${formCampos[1].value}&nome=${formCampos[2].value}`, (data) => {
            alert(data);
        });
    })
});