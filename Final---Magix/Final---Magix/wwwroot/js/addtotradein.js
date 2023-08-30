const cardSetInput = document.getElementById("cardSet");
const cardConditionInput = document.getElementById("cardCondition");
const cardFoilInput = document.getElementById("foil");
const cardQuantityInput = document.getElementById("cardQuantity");
const cardNameInput = document.getElementById("cardName");
const tradeInObjects = []; // Initialize empty array to hold ⌠tradeInObjects⌡
const tradeInList = document.querySelector(".tradein-list ul");
const totalPriceSpan = document.getElementById("total-price");
const formEntire = document.querySelector(".tradein-form-wrapper");
const addToTradeInButton = document.getElementById("add-to-tradein-button");

// Add event listener to ⌠Add to Trade-In⌡ button
addToTradeInButton.addEventListener("click", handleAddToTradeIn);

function handleAddToTradeIn() {
	const cardName = cardNameInput.value;
	const cardSet = cardSetInput.value;
	const cardCondition = cardConditionInput.value;
	const cardFoil = cardFoilInput.value;
	const cardQuantity = parseInt(cardQuantityInput.value);

	// Validate the card name
	validateCardName().then(function (isValidCardName) {
		if (!isValidCardName) {
			return; // Stops if validation failed
		}
		
	// Fetch matching card data //

		// Validate set
		validateCardSet(cardSet);

		// Validate condition
		validateCardCondition(cardCondition);

		// Validate card foil
		validateCardFoil(cardFoil);

		// Validate quantity
		validateCardQuantity(cardQuantity);

		fetchMatchingCardData(cardName).then(function (matchingCardData) {

			// Create the ⌠cardModels⌡ objects
			const cardModels = matchingCardData.matchingCardNames.map(match => {
				return {
					cardId: match.id,
					cardName: match.name,
					cardSet: cardSet,
					cardCondition: cardCondition,
					cardFoil: cardFoil,
					cardQuantity: cardQuantity,
					cardPrice: match.price,
					cardImage: match.ImageNormal
				};
			});

			// Create a similar ⌠cardModels⌡ object using controller method
			// Call the method here ↓


			// Add ⌠cardModels⌡ to the ⌠tradeInObjects⌡ array
			tradeInObjects.push(...cardModels);

			// Update the UI
			updateTradeInList();
			updateTotalPrice();
			formEntire.reset();
		});
	});
}

function fetchMatchingCardData(cardName) {
	return fetch(`/TradeIn/GetMatchingCards?cardName=${encodeURIComponent(cardName)}`)
		.then(response => response.json())
		.catch(error => {console.error('Error fetching matching card data: ', error)});
}

function validateCardSet(cardSet) {
	if (cardSet === "") {
		$("#error-message-set").show();
		return;
	}
}

function validateCardCondition(cardCondition) {
	if (cardCondition === "") {
		$("#error-message-condition").show();
		return;
	}
}

function validateCardFoil(cardFoil) {
	if (cardFoil === "") {
		$("#error-message-foil").show();
		return;
	}
}

function validateCardQuantity(cardQuantity) {
	if (cardQuantity === "" || isNaN(cardQuantity) || cardQuantity <= 0) {
		$("#error-message-qty").show();
		return;
	}
}

function updateTradeInList() {
	tradeInList.innerHTML = "";
	tradeInObjects.forEach(obj => {
		const listItem = document.createElement("li");
		listItem.textContent = `${obj.cardName} - ${obj.cardSet} - ${obj.cardCondition} - Foil: ${obj.cardFoil == "true" ? "Yes" : "No"} - Qty: ${obj.cardQuantity} - Price: ${obj.cardPrice}`;
		tradeInList.appendChild(listItem);
	});
}

function calculateObjectTotalPrice(cardModel) {				// Need to figure out this function's logic.
	return cardModel.cardPrice * cardModel.cardQuantity;	// We have access to cardPrice, I think... Let's use that.
}

function updateTotalPrice() {
	const totalPrice = tradeInObjects.reduce((total, obj) => {
		return total + calculateObjectTotalPrice(obj);
	}, 0);
	totalPriceSpan.textContent = totalPrice.toFixed(2);		// Updates/converts the TOTAL price <span> element text to be in $0.XX format
}

export default tradeInObjects;
