
// ´Abgreifen von IDs und Elementen und in Variablen speichern

var button = document.getElementById("enter"); 
var input = document.getElementById("userinput");
var ul = document.querySelector("ul"); 


// Funktion bestimmt Länge des Listeneintrags 

function inputLenght() {
	return input.value.length;
}

function addNewListElement() {
	var newli = document.createElement("li");  // newli ist ein neues Listenelement. Dieses wird durch die Methode createElement erstellt
	newli.appendChild(document.createTextNode(input.value)); // Da Textinhalt Child von List Element ist, muss die Methode appendChild verwendet werden
	ul.appendChild(newli); //erst jetzt wird das Element newli mit dem input text der ul list hinzufegügt. Ohne diese Codezeile weiß der Browser nicht, wo das Element angezeigt werden soll.
	input.value = ""; 
}

function addListAfterClick() {
	if (input.value.length > 0) {   // nur Einträge, die nicht Null sind sollen in die Liste aufgenommen werden
		addNewListElement();
	}
}

function addListAfterKeyPress(event) {
	if (input.value.length > 0 && event.keyCode === 13) { 
		addNewListElement();
	}
}

button.addEventListener("click", addListAfterClick);  //Callback Funktion, wird erst getrigggert, wenn Event eintritt (Deshalb Weglassen von Klammern "()")
input.addEventListener("keypress", addListAfterKeyPress);