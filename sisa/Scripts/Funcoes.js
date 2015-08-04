function ExibirMsg(msg) {
    $('body').append("<div class='container'><div id='msgtmp' class='alert alert-warning' role='alert' style='cursor:pointer;'><span class='glyphicon glyphicon-exclamation-sign' aria-hidden='true'></span><span class='sr-only'>Atenção:</span>&nbsp;" + msg + "</div></div>").slideDown(800);
    setTimeout(function () {
        $('#msgtmp').remove();
    }, 3000);
    $("#msgtmp").click(function () {
        $('#msgtmp').remove();
    });
}

function Calendario(campo) {

    var v_campo = $("#" + campo);

    v_campo.datepicker({
        dateFormat: 'dd/mm/yy',
        dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado', 'Domingo'],
        dayNamesMin: ['D', 'S', 'T', 'Q', 'Q', 'S', 'S', 'D'],
        dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
        monthNames: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
        monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
        nextText: 'Próximo',
        prevText: 'Anterior',
        buttonText: 'Selecionar data',
        showOtherMonths: "true",
        selectOtherMonths: "true"
    });
    
    v_campo.blur(function () {
        if (v_campo.val().length > 10) {
            v_campo.focus();
            v_campo.css('border-color', 'red');
            return false;
        } else {
            v_campo.css('border-color', 'green');
        }
        //if (v_campo.val() == '') {
        //    //v_campo.attr('placeholder', '* digite aqui campo obrigatório');
        //    v_campo.css('border-color', 'red');
        //}
        //else {
        //    v_campo.css('border-color', 'green');
        //}
    });
}


function validar(campo, msg) {
    var cmp = $('#' + campo);
    $('form').submit(function () {
        if (cmp.val() == '') {
            $('form').append("<div class='divcentro'>" + msg + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<i id='btn_fechar' class='fa fa-close'></i></div>").slideDown(8800);
            cmp.css('border-color', 'red');
            //alert(msg);
            $("#btn_fechar").click(function () {
                $('.divcentro').remove();
                cmp.focus();
            });

            return false;
        }
    });
}

function tam(campo, tam) {
    var tmp = $('#' + campo).val().length;
    var v_campo = $('#' + campo);

    if (tmp > 5) {
        $('#msg').html('Maior que ' + tam).slideDown(1000);
        this.find('#' + campo).focus();
        $('#' + campo).css('color', 'white');
        $('#' + campo).css('background-color', 'red');
    } else {
        $('#msg').slideUp(500);
    }
    $('#' + campo).focus();
}

function ntam(campo, tam, sonum, naonulo) {
    //Deixa o usuário digitar somente o tamanho passado por parametro 'tam'
    var tmp = $('#' + campo).val().length;
    var v_campo = $('#' + campo);

    if (naonulo) {
        if (v_campo.val() == '') {
            //v_campo.attr('placeholder', '* digite aqui campo obrigatório');
            v_campo.css('border-color', 'red');
        }
    }


    if (sonum) {
        sonumeros(v_campo); //Se 'true' Somente numeros são permitidos para este campo
    }
    v_campo.keypress(function () {
        if (v_campo.val().length === tam) {
            v_campo.focus();
            return false;
        } else {
            //...
        }
        if (v_campo.val() == '') {
            //v_campo.attr('placeholder', '* digite aqui campo obrigatório');
            v_campo.css('border-color', 'red');
        }
        else {
            v_campo.css('border-color', 'green');
        }
    });
}

//ntam('nome', 10, false);

function sonumeros(campo) {
    campo.keypress(function (event) {
        var tecla = (window.event) ? event.keyCode : event.which;
        if ((tecla > 47 && tecla < 58)) return true;
        else {
            if (tecla != 8) return false;
            else return true;
        }
    });
}

function MsgModal(titulo, texto) {
    
    bootbox.dialog({
        message: texto,
        title: titulo,
        buttons: {
            success: {
                label: "Fechar",
                className: "btn-success",
                callback: function () {


                }   
            },
        }
    });
}


/*$('#nome').keydown(function(event){
    if(event.which===13){
        alert($('#nome').val());
        if($('#nome').val().length>5){
            alert('marior que 5');
        }
    }
});*/