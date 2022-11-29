function FinReserva()
{
    var nombre = $("#nombre").val();
    var exhibicion = $("#exhibicion").val();
    $("#idExhibicion").attr("value", exhibicion);
    if (exhibicion == 2) exhibicion = "Maravillas Tropicales"
    if (exhibicion == 4) exhibicion = "Paseo Por El Pacifico"
    if (exhibicion == 6) exhibicion = "Visitando El Artico"
    var cantidad = $("#cantidad").val();
    var email = $("#email").val();
    var precioFinal = calcularPrecio(cantidad, exhibicion)
    $('#ModalTitle').text("Reserva de " + nombre);
    $('#ModalBody').html(nombre + ", gracias por tu reserva para '" + exhibicion + "'!" + "<br> <br>" + "Tu(s) " + cantidad + " entradas las encontrarás en tu inbox de " + email + "." + "<br> Precio final: " + precioFinal);
    $('#PrecioFinal').attr("value", precioFinal)
}

function calcularPrecio(cantEntradas, idE){
    var precioEntrada
    if (idE = 2) precioEntrada = 150
    if (idE = 4) precioEntrada = 150
    if (idE = 8) precioEntrada = 200
    return precioEntrada * cantEntradas
}

function BuscarReserva(IdS)
{
    $.ajax(
        {
            type:'POST',
            dataType: 'JSON',
            url: 'Reserva',
            data: { Id : IdS },

            success:
                function (response)
                {
                    $('#ModalTitle').text("Reserva N° " + IdS);
                    let exhibicion
                    if (response.idExhibicion == 2) exhibicion = "Maravillas Tropicales"
                    if (response.idExhibicion == 6) exhibicion = "Visitando El Artico"
                    if (response.idExhibicion == 4) exhibicion = "Paseo Por El Pacifico"
                    let ModalBody = `
                    ${response.nombre} ${response.apellido}, acá esta tu reserva para: <b>${exhibicion}</b>!
                    <br><br>Cantidad de entradas: ${response.cantidad}
                    <br>Precio final: ${response.precioFinal}
                    <br>Encontra tus entradas en tu inbox de: ${response.email}
                    `
                    $('#ModalBody').html(ModalBody);
                }
        
    });
}
