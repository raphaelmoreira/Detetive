(function (detetive, $, undefined) {

    detetive.Index = function () {

        var idiomas = {};

        return {
            modelResposta: [],
            inicializarJogo: function (model) {
                this.modelResposta = model;
                $("#btIniciar").show("fast").on("click", this.btIniciar_Click);
                $(".opcoes").hide("fast");
            },
            btIniciar_Click: function () {
                $("#btIniciar").hide("fast");
                $("#divOpcoes, #divOpSuspeitos").show("fast");
                $("#divResultado").hide("fast");
                $("#btTentarDeNovo").hide("fast");
            },
            btSuspeito_Click: function (codigo) {
                this.modelResposta.IdSuspeito = codigo;
                $("#divOpSuspeitos").hide("fast");
                $("#divOpLocais").show("fast");
            },
            btLocal_Click: function (codigo) {
                this.modelResposta.IdLocal = codigo;
                $("#divOpLocais").hide("fast");
                $("#divOpArmas").show("fast");
            },
            btArma_Click: function (codigo) {
                this.modelResposta.IdArma = codigo;
                $("#divOpArmas").hide("fast");
                $("#divProcessandoInformacao").show("fast");

                this.processarRespostas();
            },
            btTentarDeNovo_Click: function () {
                $("#divResultado").hide("fast");
                $("#btTentarDeNovo").hide();

                this.btIniciar_Click();
            },
            processarRespostas: function () {
                var that = this;
                var resposta = this.modelResposta;

                setTimeout(function () {
                    $.ajax({
                        method: "post",
                        url: "api/HomeApi",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        data: JSON.stringify(resposta)
                    }).done(function (data) {
                        if (data.acertou)
                            that.processarAcertou(data.mensagem);
                        else
                            that.processarErrou(data.mensagem);
                    }).fail(function (xhr, textStatus, errorThrown) {
                        that.processarErro(textStatus);
                    }).always(function () {
                        $("#divProcessandoInformacao").hide("fast");
                        $("#divResultado").show("fast");
                    });
                }, 3000);                
            },
            processarAcertou: function (mensagem) {
                $("#divResultado div[role=alert]").removeAttr("class").addClass("alert alert-success");
                $("#lblResultado").text(mensagem);
                this.modelResposta.IdArma = 0;
                this.modelResposta.IdLocal = 0;
                this.modelResposta.IdSuspeito = 0;

                var that = this;
                $.ajax({
                    method: "get",
                    url: "api/HomeApi/0"
                }).done(function (data) {
                    that.inicializarJogo(that.modelResposta);
                }).fail(function (xhr, textStatus, errorThrown) {
                    that.processarErro(textStatus);
                });                
            },
            processarErrou: function (mensagem) {
                $("#divResultado div[role=alert]").removeAttr("class").addClass("alert alert-danger");
                $("#lblResultado").text(mensagem);
                $("#btTentarDeNovo").show();
            },
            processarErro: function (mensagem) {
                $("#divResultado div[role=alert]").removeAttr("class").addClass("alert alert-dark");
                $("#lblResultado").text(mensagem);
            },
            carregarIdiomas: function (idioma) {
                idiomas = idioma;
            }
        }
    }()
})(window.detetive = window.detetive || { _isNamespace: true }, jQuery);