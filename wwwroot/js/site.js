function FinReserva()
{
    var nombre = $("#nombre").val();
    var exhibicion = $("#exhibicion").val();
    var cantidad = $("#cantidad").val();
    var email = $("#email").val();
    $('#ModalTitle').text("Reserva de " + nombre);
    $('#ModalBody').html(nombre + ", gracias por tu reserva para " + exhibicion + "!" + "<br> <br>" + "Tu(s) " + cantidad + " entradas las encontrarás en tu inbox de " + email + ".");
}