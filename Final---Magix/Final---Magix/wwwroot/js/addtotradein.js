const cardSetInput = document.getElementById("cardSet");
const cardConditionInput = document.getElementById("cardCondition");
const cardFoilInput = document.getElementById("foil");
const cardQuantityInput = document.getElementById("cardQuantity");
const cardNameInput = document.getElementById("cardName");
const tradeInObjects = []; //init empty array to hold tradein objects
const tradeInList = document.querySelector(".tradein-list ul");
const totalPriceSpan = document.getElementById("total-price");
const formEntire = document.querySelector(".tradein-form-wrapper");

const addToTradeInButton = document.getElementById("add-to-tradein-button");
//add event listener to Add To Tradein Button
addToTradeInButton.addEventListener("click", handleAddToTradeIn);

function handleAddToTradeIn() {
    const cardName = cardNameInput.value;
    const cardSet = cardSetInput.value;
    const cardCondition = cardConditionInput.value;
    const cardFoil = cardFoilInput.value;
    const cardQuantity = parseInt(cardQuantityInput.value);

    //validate card name
    validateCardName().then(function (isValidCardName) {
        if (!isValidCardName) {
            return; //stops if validation failed
        }
        //fetch matching card data
        //validate set
        validateCardSet(cardSet);
        //validate condition
        validateCardCondition(cardCondition);
        //validate card foil
        validateCardFoil(cardFoil);
        //validate quantity
        validateCardQuantity(cardQuantity);
        fetchMatchingCardData(cardName).then(function (matchingCardData) {
            //Create the CardModel objects
            const cardModels = matchingCardData.matchingCardNames.map(match => {
                return {
                    cardName: match.name,
                    cardSet: cardSet,
                    cardCondition: cardCondition,
                    cardFoil: cardFoil,
                    cardQuantity: cardQuantity,
                    cardPrice: match.price,
                };
            });
            //Add cardmodels to tradeinobjects array
            tradeInObjects.push(...cardModels);
            //update UI
            updateTradeInList();
            updateTotalPrice();
            formEntire.reset();
        });
    });
}
function fetchMatchingCardData(cardName) {
    return fetch(`/TradeIn/GetMatchingCards?cardName=${encodeURIComponent(cardName)}`)
        .then(response => response.json())
        .catch(error => {
            console.error('Error fetching matching card data: ', error);
        });
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
function findExistingObject(cardName, cardSet, cardCondition, cardFoil) {
    return tradeInObjects.find(obj =>
        obj.cardName === cardName &&
        obj.cardSet === cardSet &&
        obj.cardCondition === cardCondition &&
        obj.cardFoil === cardFoil
    );
}
function updateTradeInList() {
    tradeInList.innerHTML = "";

    tradeInObjects.forEach(obj => {
        const listItem = document.createElement("li");
        listItem.textContent = `${obj.cardName} - ${obj.cardSet} - ${obj.cardCondition} - Foil: ${obj.cardFoil ? "Yes" : "No"} - Qty: ${obj.cardQuantity} - Price: ${obj.cardPrice}`;
        tradeInList.appendChild(listItem);
    });
}
function calculateObjectTotalPrice(cardModel) {
    //Need to figure out this function's logic
    //We have access to cardPrice I think... Lets use that
    return cardModel.cardPrice * cardModel.cardQuantity;
    
}
function updateTotalPrice() {
    const totalPrice = tradeInObjects.reduce((total, obj) => {
        return total + calculateObjectTotalPrice(obj);
    }, 0);
    totalPriceSpan.textContent = totalPrice.toFixed(2); //updates TOTAL price span element text to be in $0.XX format
}