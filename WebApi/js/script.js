$(document).ready(
    () => {
        $('input[name="mostrar"]').click(
            () => {
                if (!MascaraCEP($('input[id="cep"]').val())){
                    LimpaCampos()
                    alert("CEP NÃO VÁLIDO!") 
                    throw console.error()  
                }
                else {
                    $.get(`https://viacep.com.br/ws/${$('input[id="cep"]').val()}/json/`, (data, textStatus) => {
                        $('input[id="cep"]').val(data.cep);
                        $('input[id="logradouro"]').val(data.logradouro);
                        $('input[id="complemento"]').val(data.complemento);
                        $('input[id="bairro"]').val(data.bairro);
                        $('input[id="localidade"]').val(data.localidade);
                        $('input[id="gia"]').val(data.gia);
                        $('input[id="ibge"]').val(data.ibge);
                        $('input[id="cep_form"]').val(data.cep);
                        $('input[id="uf"]').val(data.uf);
                    });
                }
            }
        );

        $('input[name="limpar"]').click(
            LimpaCampos()
        );
    },
);

function LimpaCampos(){
    $('input[type="text"]').val("");
}

function MascaraCEP(cep) {
    var cepReplace = cep.replace(/[^\d]/g, "");
    if (cepReplace.length != 8)
        return false;
    return cepReplace;
}