
function validatePassword() {

    var pass = document.getElementById("password");
    //const validityState = pass.validity;
    var message = "Password must be at least 6 characters";
    pass.setCustomValidity(pass.value.length < 6 ? message : "");
    pass.reportValidity();
}

function confirmPassword() {

    var pass = document.getElementById("password");
    var confirmPass = document.getElementById("password2");
    var message = "Passwords doesn't match";

    confirmPass.setCustomValidity(pass.value != confirmPass.value ? message : "");
    confirmPass.reportValidity();
    return message;
}
