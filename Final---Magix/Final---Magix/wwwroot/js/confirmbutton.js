import tradeInObjects from './addtotradein.js';

const confirmTradeInButton = document.getElementById("confirm-tradein-button");

confirmTradeInButton.addEventListener("click", CreateTradeIn);

function CreateTradeIn() {
    UpdateStoreInventory(tradeInObjects);
}

function UpdateStoreInventory(tradeInObjects) {
    $.post("/Inventory/UpdateInventory", tradeInObjects, function (data) {
        if (data.success) {
            console.log(data.message);
        } else {
            console.error(data.message);
        }
    });
}