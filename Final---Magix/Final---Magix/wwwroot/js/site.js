/* ↓↓ Code for the modal tooltips on the Trade-In page ↓↓ */

function openTooltip(id) {										// Open the corresponding modal depending on which one is clicked on
	var tooltips = document.getElementsByClassName('tooltip-modal');
	for (var i = 0; i < tooltips.length; i++) {
		tooltips[i].style.display = 'none';
	}

	var tooltip = document.getElementById(id);
	var icon = document.querySelector('.tooltip-icon[onclick="openTooltip(\'' + id + '\')"]');
	var rect = icon.getBoundingClientRect();

	tooltip.style.left = rect.left + 'px';
	tooltip.style.top = rect.top + rect.height + 'px';			// Adjust this value to position the tooltip

	tooltip.style.display = "block";
	tooltip.classList.add('display-block');
}

function closeTooltip(id) {										// Close the modal
	document.getElementById(id).style.display = "none";
}

function closeAllTooltips() {									// Close ALL modals if mouse is clicked outside of the modal
	var tooltips = document.getElementsByClassName('tooltip-modal');
	for (var i = 0; i < tooltips.length; i++) {
		tooltips[i].style.display = 'none';
	}
}

window.onclick = function (event) {								// Close modal if mouse is clicked outside of the modal
	if (!event.target.matches('.tooltip-icon')) {
		closeAllTooltips();
	}
};

window.addEventListener('scroll', closeAllTooltips);			// Close the modal if mouse scrollwheel is used
/* ↑↑ Code for the modal tooltips on the Trade-In page ↑↑ */
