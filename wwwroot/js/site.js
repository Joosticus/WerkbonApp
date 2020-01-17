$(function () {
    // Copy dataUrl to input fields
    var canvas = document.querySelector('#signature');
    var pad = new SignaturePad(canvas);

    var canvasSecond = document.querySelector('#signatureSecond');
    var padSecond = new SignaturePad(canvasSecond);

    // On accept/save button put dataUrl in input fields
    $('#accept').click(function () {
        var data = pad.toDataURL();
        $('#SignatureDataUrl').val(data);
        var dataSecond = padSecond.toDataURL();
        $('#SignatureDataUrlSecond').val(dataSecond);
        pad.off();
    });
});
$(document).ready(function () {
    // Export werkbon table to excel
    $("#exportbutton").click(function () {
        $("#exportTable").table2excel({
            name: "Werkbon Data",
            filename: "Export werkbon data",
            fileext: ".xls"
        });
    });

    // Kenteken field to uppercase on keyup
    $("#kenteken").keyup(function () {
        $(this).val($(this).val().toUpperCase());
    });

    $(".datepicker").flatpickr({
        dateFormat: "d-m-Y",
        weekNumbers: true,
        locale: "nl"
    });
});

// OnClick printen button open print window
function printen() {
    window.print();
}

