$('[name="botao_enviar"]').click(
    () => {
        var animal = {
            nome: $('[id="nome"]').val(),
            idade: $('[id="idade"]').val(),
            raca: $('[id="raca"]').val(),
            color: $('[id="color"]').val(),
            imagem: $('[id="imagem"]').val(),
        }

        alert(`- CADASTRO DE ANIMAIS -\nNome: ${animal.nome}
        \nIdade: ${animal.idade}
        \nRaça: ${animal.raca}
        \nColoração: ${animal.color}
        \nImagem: ${animal.imagem} `)
    }
);


    