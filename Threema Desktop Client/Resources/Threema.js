var check = document.getElementById("welcome").firstElementChild.firstElementChild.getAttribute("ng-if");
if (check.toString() == "(ctrl.state === 'connecting' || ctrl.state === 'waiting') && ctrl.mode === 'scan'") {
} else if (check.toString() == "ctrl.state === 'connecting' && ctrl.mode === 'unlock'") {
	var element = document.querySelector('[ng-model="ctrl.password"]'); 
	element.value = "password_";

	var event = document.createEvent("HTMLEvents");
	event.initEvent("change", false, true);
	element.dispatchEvent(event);
	document.getElementsByClassName("md-raised md-primary md-button md-ink-ripple")[0].click();
}