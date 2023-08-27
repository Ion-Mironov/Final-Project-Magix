$(document).ready(function () {
    // Listen for changes in the card name input field
    $("#cardName").on("input", function () {
        const cardName = $(this).val();
        populatePrintDropdown(cardName); // Call the function to populate the dropdown
    });
});

function populatePrintDropdown(cardName) {
    const printDropdown = document.getElementById("cardPrint");
    printDropdown.innerHTML = ""; // Clear existing options

    // Make an AJAX request to get matching print options
    $.get(`/TradeIn/GetMatchingPrints?cardName=${cardName}`)
        .done(function (response) {
            response.forEach(function (printOption) {
                const option = document.createElement("option");
                option.value = printOption.Id; // Use the Id property as option value
                option.textContent = `${printOption.ImageSmall} - ${printOption.SetName} (${printOption.SetCode})`;

                printDropdown.appendChild(option);
            });
        })
        .fail(function () {
            // Handle errors if needed
        });
}
