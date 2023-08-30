import tradeInObjects from './addtotradein.js';

const confirmTradeInButton = document.getElementById("confirm-tradein-button");

confirmTradeInButton.addEventListener("click", CreateTradeIn);

function CreateTradeIn() {
    $.post("/TradeIn/CreateTradeIn", { cards: tradeInObjects }, function (data) {
        const tradeInId = data.tradeInId;

        tradeInObjects.length = 0;
        UpdateStoreInventory(tradeInId);
    });
}

function UpdateStoreInventory(tradeInId) {
    $.post("/Inventory/UpdateInventory", { tradeInId: tradeInId }, function (data) {
        if (data.success) {
            console.log(data.message);
        } else {
            console.error(data.message);
        }
    });
}