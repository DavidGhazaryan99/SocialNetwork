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
            document.getElementById("CommentList").append
                (`
                    <li class="comment">
                        <a class="pull-left" href='@Url.Action("UserViewPage", "Search", new ${id = data.commentigUserId})'>
                            <img class="avatar" src="data:image/png;base64,${data.profilePicture}" alt="avatar">
                        </a>
                        <div class="comment-body">
                            <div class="comment-heading">
                                <h4 class="user">${data.firstName} ${data.lastName}</h4 >
                                <h5 class="time">${data.dataTime}</h5>
                            </div>
                            <p>${data.comment}</p>
                        </div>
                    </li>
                `)

        },
        error: function (ex) {
            var r = jQuery.parseJSON(response.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);
        }
    });
}