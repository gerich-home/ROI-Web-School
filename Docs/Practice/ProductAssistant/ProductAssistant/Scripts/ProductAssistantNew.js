$(function() {

    GetAllProducts();
    $(document).on("click", ".editItem", function (event) {
        event.preventDefault();
        var id = $(this).attr("data-item");
        $("#addProductBlock").css("display", "none");
        $("#editProduct").css("display", "block");
        GetProduct(id);
    });

    $(document).on("click", ".deleteItem", function(event) {
        event.preventDefault();

        var id = $(this).attr("data-item");

        DeleteProduct(id);
    });

    $("#addProduct").click(function (event) {
        event.preventDefault();
        AddProduct();
    });


    $("#updateProduct").click(function(event) {
        event.preventDefault();
        $("#addProductBlock").css("display", "none");
        $("#editProduct").css("display", "block");
        UpdateProduct();
    });

});

function AddProduct() {
    var product = {
        //Id: $("#addId").val(),//надо взять id последнего+1
        Name: $("#addName").val(),
        Price: $("#addPrice").val(),
        Category: $("#addCategory").val()
    };

    $.ajax({
        url: "/api/product/",
        type: "Post",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(product),
        success: function () {
            GetAllProducts();
        }
    });
}

function UpdateProduct() {
    var product = {
        Id: $("#editId").val(),
        Name: $("#editName").val(),
        Price: $("#editPrice").val(),
        Category: $("#editCategory").val()
    };

    $.ajax({
        url: "/api/product/" + product.Id,
        type: "Put",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(product),
        success: function() {
            GetAllProducts();
        }
    });
}
function DeleteProduct(productId) {

    $.ajax({
        url: "/api/product/" + productId,
        type: "Delete",
        success: function() {
            GetAllProducts();
        }
    });
}

function GetProduct(productId) {

    $.ajax({
        url: "/api/product/" + productId,
        type: "Get",
        success: function(product) {
            LoadProduct(product);
        }
    });
}

function LoadProduct(product) {

    $("#editId").val(product.Id);
    $("#editName").val(product.Name);
    $("#editPrice").val(product.Price);
    $("#editCategory").val(product.Category);

}

function GetAllProducts() {

    $("#editProduct").css("display", "none");
    $("#addProductBlock").css("display", "block");
    $("#addProductBlock").css("type", "resert");
    $.ajax({
        url: "/api/product",
        type: "GET",
        dataType:"json",
        success: function(data) {
            LoadProducts(data);
        }
    });
};

function LoadProducts(products) {
    var strResult = "<table><th>Id</th><th>Name</th><th>Price</th><th>Category</th>";
    $.each(products, function(index, product) {
        strResult += "<tr><td>" + product.Id + "</td><td>" + product.Name + "</td><td>";
        strResult += product.Price + "</td><td>" + product.Category + "</td>";
        strResult += "<td><a class='editItem' data-item='" + product.Id + "'>Edit</a></td>";
        strResult += "<td><a class='deleteItem' data-item='" + product.Id + "'>Delete</a></td>";
        strResult += "</tr>";
    });
    strResult += "</table>";

    $("#ProductListBlock").html(strResult);
}
