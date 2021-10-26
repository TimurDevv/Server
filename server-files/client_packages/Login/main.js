var loginBrowser = mp.browsers.new('package://Login/Login.html');

setTimeout(function() {
    mp.gui.cursor.show(true, true);
	
mp.events.add('loginInformationToServer', (username, password) => {

    mp.events.callRemote('OnPlayerLoginAttempt', username, password);

});

mp.events.add('registerInformationToServer', (username, password) => {

    mp.events.callRemote('OnPlayerRegisterAttempt', username, password);

});

mp.events.add('LoginResult', (result) => {

    if (result == 1) {

        
        loginBrowser.destroy();
        mp.gui.cursor.show(false, false);

        mp.gui.chat.push("You have successfully logged in.");

    }

    else {

       
        mp.gui.chat.push('Incorrect password or username.');

    }

});

}, 50);
