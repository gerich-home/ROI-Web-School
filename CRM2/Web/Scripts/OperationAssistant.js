
$(document).ready(function () { });
$(function () {

    GetAllOperations();
    $(document).on("click", ".editItem", function (event) {
        event.preventDefault();
        var id = $(this).attr("data-item");

        GetOperation(id);
    });

    $(document).on("click", ".deleteItem", function (event) {
        event.preventDefault();

        var id = $(this).attr("data-item");

        DeleteOperation(id);
    });

    $("#addOperation").click(function (event) {
        event.preventDefault();

        AddOperation();
    });


    $("#updateOperation").click(function (event) {
        event.preventDefault();

        UpdateOperation();
    });

});

function AddOperation() {
    var operation = {
        Date: $("#addDate").val(),
        Type: $("#addType").val(),
        Callback: $("#addCallback").val(),
        Amount: $("#addAmount").val(),
        Comment: $("#addComment").val()
    };

    $.ajax({
        url: "/api/operation/",
        type: "Post",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(operation),
        success: function () {
            GetAllOperations();
        }
    });
}

function UpdateOperation() {
    var operation = {
        Id: $("#editId").val(),
        ClientId: $("#editClientId").val(),
        Date: $("#editDate").val(),
        Type: $("#editType").val(),
        Callback: $("#editCallback").val(),
        Amount: $("#editAmount").val(),
        Comment: $("#editComment").val()
    };

    $.ajax({
        url: "/api/operation/" + operation.Id,
        type: "Put",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(operation),
        success: function () {
            GetAllOperations();
        }
    });
}
function DeleteOperation(operationId) {//в таблице этой функции нет!

    $.ajax({
        url: "/api/operation/" + operationId,
        type: "Delete",
        success: function () {
            GetAllOperations();
        }
    });
}

function GetOperation(operationId) {

    $.ajax({
        url: "/api/operation/" + operationId,
        type: "Get",
        success: function (operation) {
            LoadOperation(operation);
        }
    });
}

function LoadOperation(operation) {

    $("#editId").val(operation.Id);
    $("#editClientId").val(operation.ClientId);
    $("#editDate").val(operation.Date);
    $("#editType").val(operation.Type);
    $("#editCallback").val(operation.Callback);
    $("#editAmount").val(operation.Amount);
    $("#editComment").val(operation.Comment)


}

function GetAllOperations() {

    $.ajax({
        url: "/api/operation",
        type: "GET",
        dataType: "json",
        success: function (data) {
            LoadOperations(data);
        }
    });
};

function LoadOperations(operations) {//здесь использую knockout! 
    var strResult = "<table><th>Id</th><th>Name</th><th>Price</th><th>Category</th>";
    $.each(operations, function (index, operations) {
        strResult += "<tr><td>" + operations.Id + "</td><td>" + operations.Name + "</td><td>";
        strResult += operations.Price + "</td><td>" + operations.Category + "</td>";
        strResult += "<td><a class='editItem' data-item='" + operations.Id + "'>Edit</a></td>";
        strResult += "<td><a class='deleteItem' data-item='" + operations.Id + "'>Delete</a></td>";
        strResult += "</tr>";
    });
    strResult += "</table>";

    $("#OperationListBlock").html(strResult);
}