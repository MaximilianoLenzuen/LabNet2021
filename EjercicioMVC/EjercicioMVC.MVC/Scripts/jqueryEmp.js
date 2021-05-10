let textName = $("#txtNombre");
let textLastName = $("#txtApellido");
let textDireccion = $("#txtDireccion");
let textCiudad = $("#txtCiudad");
let textEmpID = $("#txtEmpID");

let formButtonCrear = $("#btn-Crear").click(function () {
    if (textName.val() == "" || textLastName.val() == "" || textDireccion.val() == "" || textCiudad.val() == "") {
        alert("Complete todos los campos");
    }
})

let formButtonModificar = $("#btn-Crear").click(function () {
    if (textName.val() == "" || textLastName.val() == "" || textDireccion.val() == "" || textCiudad.val() == "" || textEmpID.val() == "") {
        alert("Complete todos los campos");
    }
})

