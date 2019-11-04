$(document).ready(
    () => {
        $('#Button1').click(() => {
            
            $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", (data) => {
                $.each(data, (key, value) => {
                    var text = $(
                        `<div class=" m-2">
                        <p>
                            <a class="btn btn-primary" data-target="#collapse${key}" data-toggle="collapse" href="#collapseExample${key}"
                                role="button" aria-expanded="false" aria-controls="collapseExample">
                                ${value.bairro}
                            </a>
                        </p>
                        <div class="collapse" id="collapse${key}">
                            <div class="card">
                                <div class="card-header">
                                    <h1 class="text-primary">CEP ${value.cep}</h1>
                                </div>
                                <div class="card-body">
                                <div class="row">
                                    <div class="col-md-3">
                                    <h5 class="text-info">Bairro:</h5>
                                    <h4 class="text-dark">${value.bairro}</h4>
                                    </div>
                                    <div class="col-md-3">
                                    <h5 class="text-info">Logradouro:</h5>
                                    <h4 class="text-dark">${value.logradouro}</h4>
                                    </div>
                                    <div class="col-md-3">
                                    <h5 class="text-info">Localidade:</h5>
                                    <h4 class="text-dark">${value.localidade}</h4>
                                    </div>
                                    </div>
                                </div>
                            </div>
                            </div>
                    </div>`
                    );
                    $("#row_principal")
                        .append(text);
                })

            });
        })
    });