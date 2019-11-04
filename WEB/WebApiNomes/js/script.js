$('[name="botao_enviar"]').click(
  function () {
    var url = 'http://localhost:50963/api/Clientes';
    try {
      $.getJSON(url, (data) => {
        console.log(data)
      })
    } catch (error) {
      $('[id="valor_dolar"]').val('Erro');
    }
  }
);