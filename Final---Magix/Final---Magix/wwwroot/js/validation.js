function debounce(func, delay) {
    let timeoutId;
    return function () {
        clearTimeout(timeoutId);
        timeoutId = setTimeout(() => {
            func.apply(this, arguments);
        }, delay);
    };
}

function validateCardName() {
    const cardName = $("#cardName").val();

    return $.post("/TradeIn/ValidateCardName", { cardName: cardName })
        .then(function (response) {
            return response.isValid;
        })
        .fail(function () {
            return false;
        });
}

$(document).ready(function () {
    const validateCardNameDebounced = debounce(validateCardName, 2000);

    $("#cardName").on("input", function () {
        validateCardNameDebounced().then(function (isValid) {
            if (isValid) {
                $("#error-message-name").hide();
            } else {
                $("#error-message-name").show();
            }
        });
    });
});