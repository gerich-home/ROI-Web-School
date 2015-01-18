document.addEventListener("DOMContentLoaded", function() {
    $("ul").hide();
    $("h3 span").click(function(){
        $(this).parent().next().slideToggle();
    });
    $("li").click(function () {
        //var contactType = $("li").value();
    });
});
$(function () {

    GetAllContacts();
    $(".editItem").click(function (event) {
        event.preventDefault();
        var id = $(this).attr("data-item");

        GetContact(id);
    });

    $(".deleteItem").click(function (event) {
        event.preventDefault();

        var id = $(this).attr("data-item");

        DeleteContact(id);
    });

    $("#addContact").click(function (event) {
        event.preventDefault();

        AddContact();
    });


    $("#updateContact").click(function (event) {
        event.preventDefault();

        UpdateContact();
    });
}); 


function AddContact() {
    var contact = {
        PhoneType: $(contactType).val(),
        PhoneNr: $("#addPhoneNr").val()
    };

    $.ajax({
        url: "/api/contact/",
        type: "Post",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(contact),
        success: function () {
            GetAllContacts();
        }
    });
}

function UpdateContact() {
    var contact = {
        Id: $("#editId").val(),
        ClientId: $("#editClientId").val(),
        PhoneType: $("#editPhoneType").val(),
        PhoneNr: $("#editPhoneNr").val()
    };

    $.ajax({
        url: "/api/contact/" + contact.Id,
        type: "Put",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(contact),
        success: function () {
            GetAllContacts();
        }
    });
}
function DeleteContact(contactId) {//в таблице этой функции нет!

    $.ajax({
        url: "/api/contact/" + contactId,
        type: "Delete",
        success: function () {
            GetAllContacts();
        }
    });
}

function GetContact(contactId) {

    $.ajax({
        url: "/api/contact/" + contactId,
        type: "Get",
        success: function (contact) {
            LoadContact(contact);
        }
    });
}

function LoadContact(contact) {

    $("#editId").val(contact.Id);
    $("#editClientId").val(contact.ClientId);
    $("#editPhoneType").val(contact.PhoneType);
    $("#editPhoneNr").val(contact.PhoneNr);

}

function GetAllContacts() {

    $.ajax({
        url: "/api/contact",
        type: "GET",
        dataType: "json",
        success: function (data) {
            LoadContacts(data);
        }
    });
};

function LoadContacts(contacts) {//здесь использую knockout! 
    var strResult = "<table><th>PhoneType</th><th>PhoneNr</th>";
    $.each(contacts, function (index, contact) {
        strResult += "<tr><td>" + contact.PhoneType + "</td><td>" + contact.PhoneNr + "</td>";
        strResult += "<td><a class='editItem' data-item='" + contact.ClientId + "'>Edit</a></td>";
        strResult += "<td><a class='deleteItem' data-item='" + contact.ClientId + "'>Delete</a></td>";
        strResult += "</tr>";
    });
    strResult += "</table>";
    $("tr:odd").css("backgroundColor", "lightgray");
    $("tr:even").css("backgroundColor", "white");
    $("#ContactListBlock").html(strResult);
}