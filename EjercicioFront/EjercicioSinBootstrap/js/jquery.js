let textName = $("#txtNombre");
let textLastName = $("#txtApellido");
let textAge = $("#txtEdad");

let formButtonSubmit = $("#btn-submit").click(function(){
    if(textName.val() == "" || textLastName.val() == ""){
        alert("Complete los campos nombre y apellido");
    }else{
        alert("Contacto agregado");
    }
})

let formButtonClear = $("#btn-clear").click(function(){
    textName.val("");
    textLastName.val("");
    textAge.val("");
})
