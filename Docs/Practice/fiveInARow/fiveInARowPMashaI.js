//пока как то так
var fieldWidth  = 32;
var fieldHeight = 32;

function createEmptyRow() {
	var a = [];
	for(var column = 0; column < fieldWidth; column++) {
		a.push(null);
	}
	
	return a;
}

var a = [];
for(var row = 0; row < fieldHeight; row++) {
	a.push(createEmptyRow());
}

document.addEventListener("DOMContentLoaded", function() {
	var gameMenu = document.getElementById("gameMenu");
	gameMenu.parentNode.removeChild(gameMenu);
	
	var field = document.getElementById("field");
	for(var row = 0; row < fieldHeight; row++) {
		var rowElement = document.createElement("div");
		rowElement.className = "row";
		field.appendChild(rowElement);
		
		for(var column = 0; column < fieldWidth; column++) {
			var cell = document.createElement("div");
			cell.className = "cell";
			rowElement.appendChild(cell);
			
			cell.addEventListener("click", function() {
				var classes = this.className.split(" ");
				var player = document.getElementById("player");
				var playerO = document.getElementsByName("player o");
				var playerX = document.getElementsByName("player x");
				//просто, что бы показывал пока :)
				if(classes.indexOf("o") < 0){
					classes.push("o");
				} 
				//установить время для переключения игроков
				/*switch(player){
				case playerO:
				if(classes.indexOf("o") < 0){
					classes.push("o");
				} 
				break;
				case playerX:
				if(classes.indexOf("x") < 0) {
					classes.push("x");
				}
				break;*/
				this.className = classes.join(" ");
			});
			
			
		}
	}
	
	document.getElementById("game").className = "";
});
