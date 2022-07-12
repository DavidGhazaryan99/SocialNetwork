function AddLike(id) {
    $.ajax({
        type: 'POST',
        url: 'Home/AddLike',
        data: { id },
        success: function (data) {
            document.getElementById(id).innerHTML = data;
        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
}

function AddComment(id) {
    var comment = document.getElementById("inputComment").value;
    $.ajax({
        type: 'POST',
        url: 'Home/AddComment',
        data: { id, comment },
        success: function (data) {
            const divPostFooter = document.getElementById('PostFooter');
            const CommentList = document.getElementById(id);
            const textInput = document.getElementById('inputComment');
            const messagesQueue = [];

            messagesQueue.push(textInput.value);
            textInput.value = "";

            let li = document.createElement('li');
            li.className = "comment";

            let a = document.createElement('a');
            a.className = "pull-left";
            a.href = '@Url.Action("UserViewPage", "Search", new ${id ='+ data.commentigUserId + '})';

            let img = document.createElement('img');
            img.className = "img-circle avatar";
            img.src = "data: image / png; base64,"+ data.profilePicture;
            img.alt = "avatar";

            let div = document.createElement('div');
            div.className = "comment-body";

            let divComHeading = document.createElement('div');
            divComHeading.className = "comment-heading";

            let h4 = document.createElement('h4');
            h4.className = "user";
            h4.innerHTML = data.firstName + " " + data.lastName;

            let h5 = document.createElement('h5');
            h5.className = "time";
            h5.innerHTML = data.dataTime;

            let p = document.createElement('p');
            p.innerHTML = data.comment;

            a.appendChild(img);

            divComHeading.appendChild(h4);
            divComHeading.appendChild(h5);

            div.appendChild(divComHeading);
            div.appendChild(p);

            li.appendChild(a);
            li.appendChild(div);

            CommentList.appendChild(li);



            //document.getElementById("CommentList").append
            //    (`
            //        <li class="comment">
            //            <a class="pull-left" href='@Url.Action("UserViewPage", "Search", new ${id = data.commentigUserId})'>
            //                <img class="avatar" src="data:image/png;base64,${data.profilePicture}" alt="avatar">
            //            </a>
            //            <div class="comment-body">
            //                <div class="comment-heading">
            //                    <h4 class="user">${data.firstName} ${data.lastName}</h4 >
            //                    <h5 class="time">${data.dataTime}</h5>
            //                </div>
            //                <p>${data.comment}</p>
            //            </div>
            //        </li>
            //    `)

        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
}