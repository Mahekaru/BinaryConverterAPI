var uri = 'api/Binary';

function toBinary() {
    var myText = $('#myText').val();
    $.getJSON(uri + '/1?value=' + myText)
        .done(function (data) {
            $('#myBinary').val(data);
        });
}

function toText() {
    var myText = $('#myBinary').val();
    $.getJSON(uri + '/2?value=' + myText)
        .done(function (data) {
            $('#myText').val(data);
        });
}