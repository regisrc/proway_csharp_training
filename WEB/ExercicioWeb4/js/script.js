var animas = []

$('[name="botao_enviar"]').click(
    () => {
        var animal = {
            nome: $('[id="nome"]').val(),
            idade: $('[id="idade"]').val(),
            raca: $('[id="raca"]').val(),
            color: $('[id="color"]').val(),
            imagem: $('[id="imagem"]').val(),
        }

        animas.push(animal)
        console.log(animas)

        alert(`- CADASTRO DE ANIMAIS -\nNome: ${animal.nome}
        \nIdade: ${animal.idade}
        \nRaça: ${animal.raca}
        \nColoração: ${animal.color}
        \nImagem: ${animal.imagem} `)
    }
);

$('[name="botao_mostrar"]').click(
     () => {
        myMove()
    }
);  

var audio = new Audio('http://ahandfulof.me/fail/ferrari-f1.mp3');

function myMove() {

    audio.play()
    var elem = document.getElementById("imagem1111");
    elem.style.left = '0';
    var pos = 0;
    var id = setInterval(frame, 1);
    function frame() {
      if (pos == 1000) {
        clearInterval(id);
      } else {
        pos++;
        elem.style.left = pos + 'px';
      }
    }
  }