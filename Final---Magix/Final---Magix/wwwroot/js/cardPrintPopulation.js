$(document).ready(function () {
    let isValidationComplete = true; //Flag to track validation status
    let debounceTimeout;

    //Listen for validation completion event triggers from validation.js
    $(document).on("validationComplete", function () {
        isValidationComplete = true;
    });

    // Listen for changes in the card name input field
    $("#cardName").on("input", function () {
        const cardName = $(this).val();
        clearTimeout(debounceTimeout); //clear previous timeout

        //set a new timeout to trigger the function after a delay
        debounceTimeout = setTimeout(function () {
            if (isValidationComplete) {
                populatePrintDropdown(cardName); // Call the function to populate the dropdown
                isValidationComplete = false; //Reset flag to initial state
            }
        }, 2000); //Wait 2 seconds after validation is complete to populate the Print dropdown
    });
});

function populatePrintDropdown(cardName) {
    const printDropdown = document.getElementById("cardPrint");
    printDropdown.innerHTML = ""; // Clear existing options
    console.log("Populating dropdown with: ", cardName);

    //Log the API url to make sure it is good
    const apiURL = `/TradeIn/GetMatchingPrints`;
    console.log("API URL: ", apiURL);

    // Make an AJAX request to get matching print options
    $.get(apiURL, { cardName: cardName })
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
        .fail(function (e) {
            console.log(e)
        });
}
