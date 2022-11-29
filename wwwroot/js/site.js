function FinReserva()
{
    var nombre = $("#nombre").val();
    var exhibicion = $("#idExhibicion option:selected").html();
    
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

function BuscarReserva()
{

    var emailbuscar=$("#emailBuscar").val();
    
    $.ajax(
        {
            type:'POST',
            dataType: 'JSON',
            url: '/Home/Reserva',
            data: { email : emailbuscar },

            success:
                function (response)
                {
                    response.forEach(function (element) {
                        $('#ModalTitle').text("Reserva de " + element.nombre + " " + element.apellido );
                        $("#ModalBody").html( "<b> ID de la Reserva </b> : "+ element.idReserva + "<br> <b> Cantidad de entradas </b> : " + element.cantidad + "<br> <b> Precio Final </b> : " + element.precioFinal);
                       
                      });
                    
                }
        
    });
}
