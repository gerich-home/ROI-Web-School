$(function() {

function getObject (obj, objId) {
var object = $("#" + objId)
.clone()
.removeAttr("id")
.find(".caption")
.text(fileSystem.name)
.end()
return object;
}

function folders (obj){
return getObject(obj, "folder")
}
function files (obj){
return getObject(obj, "file");
}

folders(fileSystem).appendTo("#tree");



























});