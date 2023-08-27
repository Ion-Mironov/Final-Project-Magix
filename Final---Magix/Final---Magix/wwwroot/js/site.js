function openTooltip(id) {
	var tooltips = document.getElementsByClassName('tooltip-modal');
	for (var i = 0; i < tooltips.length; i++) {
		tooltips[i].style.display = 'none';
	}

	var tooltip = document.getElementById(id);
	var icon = document.querySelector('.tooltip-icon[onclick="openTooltip(\'' + id + '\')"]');
	var rect = icon.getBoundingClientRect();

	tooltip.style.left = rect.left + 'px';
	tooltip.style.top = rect.top + rect.height + 'px'; // Adjust this value to position the tooltip

	tooltip.style.display = "block";
	tooltip.classList.add('display-block');
}

function closeTooltip(id) {
	document.getElementById(id).style.display = "none";
}

function closeAllTooltips() {
	var tooltips = document.getElementsByClassName('tooltip-modal');
	for (var i = 0; i < tooltips.length; i++) {
		tooltips[i].style.display = 'none';
	}
}

window.onclick = function (event) {
	if (!event.target.matches('.tooltip-icon')) {
		closeAllTooltips();
	}
};

window.addEventListener('scroll', closeAllTooltips);



//*//
