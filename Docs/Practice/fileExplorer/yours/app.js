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
		return getObject(obj, "folder");
	}
	function files (obj){
		return getObject(obj, "file");
	}

	folders(fileSystem).appendTo("#tree");
	var self = $("#tree").find(".folder");
	var children = self.find(".list-group");
	var geliC = self.find(".expander.glyphicon");
	
	function createEl(){
		self.addClass("loading");
		fileSystem.loadChildren().done(function() {
			for(var i = 0; i < fileSystem.children.length; i++) {
				if(fileSystem.children[i].isFolder) {
					$("#folder")
						.clone()
						.removeAttr("id")
						.appendTo(children)
						.find(".caption")
						//.data("file", fileSystem.children[i])
						//later: .data("file").content
						.text(fileSystem.children[i].name);
				}
				else {
					// TODO: add files
					$("#file")
						.clone()
						.removeAttr("id")
						.appendTo(children)
						.find(".caption")
						.text(fileSystem.children[i].name);
				} 
			}
			
		self.removeClass("loading");
		children.slideDown();
		});
	}
	
	$("#tree").on("click", ".folder", function(event){
			event.stopPropagation();
			geliC.toggleClass("glyphicon-minus");
			
			if(!fileSystem.isLoaded) {
				createEl();
				return;
			}	
			
			if(fileSystem.isLoaded) {
				children.slideToggle();
				return;
			}
	});

	$("#tree").on("click", ".file", function(event){
			event.stopPropagation();
			$(".file.active").removeClass("active");
			$(this).closest(".list-group-item").addClass("active");
	});
});