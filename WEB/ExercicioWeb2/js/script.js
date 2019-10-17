$('[id="botao_enviar"]').click(
    function () {
        var url = 'https://economia.awesomeapi.com.br/USD-BRL';
        try {
            $.getJSON(url, function (data) {
                var valorUsuario = ($('[id="valor_real"]').val());
                var valor = (valorUsuario.replace(/\./g, '').replace(/,/g, '.').replace('R$', '') / data[0]["bid"]).toFixed(3);
                var valorEmDolar = Number.parseFloat(valor).toLocaleString('en-US');
                $('[id="valor_dolar"]').val(valorEmDolar);
                gravaNoArray(valorEmDolar);
            })
        } catch (error) {
            $('[id="valor_dolar"]').val('Erro');
        }
    }
);

function inicializaBarraLateral(arrayElementos) {
    if (arrayElementos != null)
        $(arrayElementos.valores).each(function (element) {
            appendOnParagraph(arrayElementos.valores[element]);
        });
}

function appendOnParagraph(valor) {
    var text = $("<p></p>").text("$" + valor);
    $("#conteudo_barra_lateral").append(text);
}

function gravaNoArray(valor) {
    var session = {}
    var restoredSession = JSON.parse(localStorage.getItem("valoresMonetarios"));
    if (restoredSession == null)
        session = {
            'valores': []
        };
    else
        session = restoredSession;
    session.valores.push(valor);
    localStorage.setItem("valoresMonetarios", JSON.stringify(session))
    appendOnParagraph(valor);
}

document.addEventListener("keydown", keyDownTextField, false);

function keyDownTextField(e) {
    if (e.keyCode == 13)
        $('[id=botao_enviar]').click();
};

$(document).ready((function () {
    $(".money_mask_real").maskMoney({
        allowNegative: true,
        thousands: '.',
        decimal: ','
    });

    inicializaBarraLateral(JSON.parse(localStorage.getItem("valoresMonetarios")))
}));