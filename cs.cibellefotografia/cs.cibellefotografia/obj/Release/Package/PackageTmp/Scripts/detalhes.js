
var imgs = ["../../img/capa/capaCasal.jpg", "../../img/capa/capaCriancaBanco.jpg", "../../img/capa/capaPegadas.jpg",
    "../../img/capa/capaCriancaIgreja.jpg", "../../img/capa/capaPorDoSol.jpg"];

setInterval(function () {
    $("#hero").fadeOut(1000, function () {
        $(this).css({ 'background-image': 'url(' + imgs.shift() + ')' }).fadeIn();
    });
    if (imgs.length == 0) {
        imgs = ["../../img/capa/capaCasal.jpg", "../../img/capa/capaCriancaBanco.jpg", "../../img/capa/capaPegadas.jpg",
            "../../img/capa/capaCriancaIgreja.jpg", "../../img/capa/capaPorDoSol.jpg"];

    }
}, 10000);
