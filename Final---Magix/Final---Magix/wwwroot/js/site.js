function openTooltip(id) {
	var tooltip = document.getElementById(id);
	tooltip.style.display = "block";
	tooltip.classList.add('display-block'); // Add this line
}


function closeTooltip(id) {
	document.getElementById(id).style.display = "none";
}

window.onclick = function (event) {
	if (!event.target.matches('.tooltip-icon')) {
		var tooltips = document.getElementsByClassName('tooltip-modal');
		for (var i = 0; i < tooltips.length; i++) {
			tooltips[i].style.display = 'none';
		}
	}
};
