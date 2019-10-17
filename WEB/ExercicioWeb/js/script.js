$('[name="botao_enviar"]').click(
    function() {
        $('[id="for_user_read"]').text($('[name="nome"]').val() ? "Seja bem vindo(a) " + $('[name="nome"]').val() : "Escreva algo no input!");
    }
);

document.addEventListener("keydown", keyDownTextField, false);

function keyDownTextField(e) {
      if(e.keyCode == 13) 
        $('[id=botao_fechar_modal]').click();
}