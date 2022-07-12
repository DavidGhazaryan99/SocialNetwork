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

    let signingUser = document.getElementById('SingnInUser').value;
    let friendUser = document.getElementById('friendUser').innerText;

    let userImg = document.getElementById('userImg').src;
    let friendUserImg = document.getElementById('friendUserImg').src;

    let container = document.createElement('div');
    let image = document.createElement('img');

    if (message.userName == signingUser)
    {
        container.className = "chat-message-right pb-4";
        image.src = userImg;
    }
    else
    {
        image.src = friendUserImg;
        container.className = "chat-message-left pb-4";
    }
    //container.className = isCurrentUserMessage ? "chat-message-right pb-4" : "chat-message-left pb-4";
    //image.src = "data:image/png;base64, @Model.UserView.ProfilePicture";

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
    senderName.innerHTML += message.userName;
    flex.appendChild(senderName);
    flex.innerHTML+=message.text;
    let div = document.createElement('div');

    div.appendChild(image);
    div.appendChild(when2);

    container.appendChild(div);
    container.appendChild(flex);

    chat.appendChild(container);
}