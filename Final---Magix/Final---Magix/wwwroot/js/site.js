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


//I want to make it so when one clicks on the card name list inside the create view. As they type out a cards name a drop down appeasr displaying every card that matches their search. 
//*//
<script>
	$(function() {
		$("#cardNameInput").autocomplete({
			source: function (request, response) {
				$.ajax({
					url: '/TradeIn/GetMatchingCardNames',  // Change this URL to the correct action
					dataType: 'json',
					data: {
						term: request.term
					},
					success: function (data) {
						response(data);
					}
				});
			},
			minLength: 2 // Minimum characters before triggering autocomplete
		});
    });
</script>
//*//
