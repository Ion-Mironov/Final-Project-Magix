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

    $.post("/TradeIn/ValidateCardName", { cardName: cardName })
        .done(function (response) {
            if (response.isValid) {
                $("#error-message").hide();
            } else {
                $("#error-message").show();
            }
            //Trigger cardPrintPopulation check to allow the script to run to populate the dropdown
            $(document).trigger("validationComplete"); 
        })
        .fail(function () {
            //handle errors here
        });
}

$(document).ready(function () {
    const validateCardNameDebounced = debounce(validateCardName, 2000);

    $("#cardName").on("input", function () {
        validateCardNameDebounced();
        $("#error-message").hide();
    });
});