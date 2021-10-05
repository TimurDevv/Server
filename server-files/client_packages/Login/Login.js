$('#loginButton').click(() => {

    mp.trigger('loginInformationToServer', $('#loginUsernameText').val(), $('#loginPasswordText').val());
});

$('#registerButton').click(() => {

    mp.trigger('registerInformationToServer', $('#registerUsernameText').val(), $('#registerPasswordText').val());
});