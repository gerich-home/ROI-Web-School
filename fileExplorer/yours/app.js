jQuery(document).ready(function ($) {
	var name = fileSystem.name;

	var root = $("#folder")
		.clone()
		.removeAttr("id")
		.appendTo("#tree")
		.find(".caption")
		.text(name)
		.end()
		
		.click(function(event) {
			event.stopPropagation();
			
			var self = $(this);
			var children = self.find(".list-group");
			
			if(fileSystem.isLoaded) {
				children.slideToggle();
				return;
			}
			
			self.addClass("loading");
			self.find("span").removeClass("expander glyphicon glyphicon-plus");
			
			fileSystem.loadChildren().done(function() {
				for(var i = 0; i < fileSystem.children.length; i++) {
					if(fileSystem.children[i].isFolder) {
						$("#folder")
							.clone()
							.removeAttr("id")
							.appendTo(children)
							.find(".caption")
							.data("file", fileSystem.children[i])
							.text(fileSystem.children[i].name);
					} else {
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
				self.addClass("expander glyphicon glyphicon-minus");
				
			});
			
		$("#folder").click(function(){
			for(var i = 0; i < fileSystem.children.length; i++) {
				if(fileSystem.children[i].isFolder) {
						$("#folder")
							.clone()
							.removeAttr("id")
							.appendTo(children)
							.find(".caption")
							.data("file", fileSystem.children[i])
							.text(fileSystem.children[i].name);
					}
				 else {
					         $("#file")
							.appendTo(children)
							.find(".caption")
							.text(fileSystem.children[i].name);
				}
				}
		});		
		$("#file").click(function(){
					document.getElementById(".content").text($('#file').text(children.content));
					$("#file")
							.find(".content")
							.appendTo("#panel-body")
							.text(fileSystem.children[i].content);
						//.append('<p>'+.data("file").text(fileSystem.data.content)+'</p>'); 
		});
		});
		
	//.data("file").content
	// TODO: add files
});