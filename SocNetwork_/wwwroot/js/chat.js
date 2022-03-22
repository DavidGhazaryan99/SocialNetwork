class Message {
    constructor(username, text, when) {
        this.userName = username;
        this.text = text;
        this.when = when;
    }
}

// userName is declared in razor page.
const username = userName;
const textInput = document.getElementById('messageText');
const whenInput = document.getElementById('when');
const chat = document.getElementById('messagesList');
const messagesQueue = [];

document.getElementById('submitButton').addEventListener('click', () => {
    var currentdate = new Date();
    when.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
});

function clearInputField() {
    messagesQueue.push(textInput.value);
    textInput.value = "";
}

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() === "") return;

    let when = new Date();
    let message = new Message(username, text, when);
    sendMessageToHub(message);
}

function addMessageToChat(message) {
    let isCurrentUserMessage = message.userName === username;

    let container = document.createElement('div');
    container.className = isCurrentUserMessage ? "chat-message-right pb-4" : "chat-message-left pb-4";

    let image = document.createElement('img');
    image.src = "https://bootdey.com/img/Content/avatar/avatar1.png";
    image.className = "rounded-circle mr-1";
    image.width = "40";
    image.height = "40";

    let when2 = document.createElement('div');
    when2.className = "text-muted small text-nowrap mt-2";
    var currentdate = new Date();
    when2.innerHTML = (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    let flex = document.createElement('div');
    flex.className = "flex-shrink-1 bg-light rounded py-2 px-3 mr-3";
    let senderName = document.createElement('div');
    senderName.className = "font-weight-bold mb-1";
    senderName.innerHTML = message.userName;
    flex.appendChild(senderName);
    flex.innerHTML=message.text;
    let div = document.createElement('div');




    //let sender = document.createElement('p');
    //sender.className = "sender";
    //sender.innerHTML = message.userName;
    //let text = document.createElement('p');
    //text.innerHTML = message.text;



    //let when = document.createElement('span');
    //when.className = isCurrentUserMessage ? "time-left" : "time-right";
    //var currentdate = new Date();
    //when.innerHTML =
    //    (currentdate.getMonth() + 1) + "/"
    //    + currentdate.getDate() + "/"
    //    + currentdate.getFullYear() + " "
    //    + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    div.appendChild(image);
    div.appendChild(when2);

   

    chat.appendChild(div);
    chat.appendChild(flex);




    //container.appendChild(sender);
    //container.appendChild(text);
    //container.appendChild(when);
    //chat.appendChild(container);
}