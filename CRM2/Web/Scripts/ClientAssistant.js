document.addEventListener("DOMContentLoaded", function () {

});
$(function () {

    GetAllClients();
    $(".editItem").click(function (event) {
        event.preventDefault();
        var id = $(this).attr("data-item");

        GetClient(id);
    });

    $(".deleteItem").click(function (event) {
        event.preventDefault();

        var id = $(this).attr("data-item");

        DeleteClient(id);
    });

    $("#addClient").click(function (event) {
        event.preventDefault();

        AddClient();
    });


    $("#updateClient").click(function (event) {
        event.preventDefault();

        UpdateClient();
    });

});

function AddClient() {
    var client = {
        FirstName: $("#addFirstName").val(),
        LastName: $("#addLastName").val(),
        DateOfBirth: $("#addDateOfBirth").val()
    };

    $.ajax({
        url: "/api/client/",
        type: "Post",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(client),
        success: function () {
            GetAllClients();
        }
    });
}

function UpdateClient() {
    var client = {
        Id: $("#editId").val(),
        FirstName: $("#editFirstName").val(),
        LastName: $("#editLastName").val(),
        DateOfBirth: $("#editDateOfBirth").val()
    };

    $.ajax({
        url: "/api/client/" + client.Id,
        type: "Put",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(client),
        success: function() {
            GetAllСlients();
        }
    });
}
function DeleteClient(clientId) {

    $.ajax({
        url: "/api/client/" + clientId,
        type: "Delete",
        success: function() {
            GetAllСlients();
        }
    });
}

function GetClient(clientId) {

    $.ajax({
        url: "/api/client/" + clientId,
        type: "Get",
        success: function (client) {
            LoadClient(client);
        }
    });
}

function LoadClient(client) {

    $("#editId").val(client.Id);
    $("#editFirstName").val(client.FirstName);
    $("#editLastName").val(client.LastName);
    $("#editDateOfBirth").val(client.DateOfBirth);

}

function GetAllClients() {

    $.ajax({
        url: "/api/client",
        type: "GET",
        dataType:"json",
        success: function(data) {
            LoadClients(data);
        }
    });
};

function LoadClients(clients) {
    var strResult = "<table><th>Id</th><th>Name</th><th>Price</th><th>Category</th>";
    $.each(clients, function (index, clients) {
        strResult += "<tr><td>" + clients.Id + "</td><td>" + clients.Name + "</td><td>";
        strResult += clients.Price + "</td><td>" + clients.Category + "</td>";
        strResult += "<td><a class='editItem' data-item='" + clients.Id + "'>Edit</a></td>";
        strResult += "<td><a class='deleteItem' data-item='" + clients.Id + "'>Delete</a></td>";
        strResult += "</tr>";
    });
    strResult += "</table>";
    $("tr:odd").css("backgroundColor", "lightgray");
    $("tr:even").css("backgroundColor", "white");
    $("#ClientListBlock").html(strResult);
}
