$(function () {
    var canvas = document.querySelector('#signature');
    var pad = new SignaturePad(canvas);

    var canvasSecond = document.querySelector('#signatureSecond');
    var padSecond = new SignaturePad(canvasSecond);
    $('#accept').click(function () {
        var data = pad.toDataURL();
        $('#SignatureDataUrl').val(data);
        var dataSecond = padSecond.toDataURL();
        $('#SignatureDataUrlSecond').val(dataSecond);
        pad.off();
    });
});