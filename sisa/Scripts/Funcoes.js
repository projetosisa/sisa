function ExibirMsg(msg) {
    $('body').append("<div class='container'><div id='msgtmp' class='alert alert-warning' role='alert' style='cursor:pointer;'><span class='glyphicon glyphicon-exclamation-sign' aria-hidden='true'></span><span class='sr-only'>Atenção:</span>&nbsp;" + msg + "</div></div>").slideDown(800);
    setTimeout(function () {
        $('#msgtmp').remove();
    }, 3000);
    $("#msgtmp").click(function () {
        $('#msgtmp').remove();
    });
}