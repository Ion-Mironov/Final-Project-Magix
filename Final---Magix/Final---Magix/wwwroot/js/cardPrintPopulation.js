/*var $j = jQuery.noConflict();*/

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
                const img = document.createElement("img");
                const text = document.createElement("span");

                option.value = printOption.Id; // Use the Id property as option value
                option.classList.add("printOptionWrapper");

                img.src = printOption.ImageSmall;
                img.alt = printOption.SetName;
                img.classList.add("printOptionsImage");

                text.classList.add("printOptionText");
                text.innerText = `${printOption.SetName} (${printOption.SetCode})`;

                option.appendChild(img);
                option.appendChild(text);
                printDropdown.appendChild(option);
            });
        })
        .fail(function () {
            // Handle errors if needed
        });
}
