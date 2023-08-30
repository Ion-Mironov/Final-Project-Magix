<script>
    $(document).ready(function() {
        $("#confirm-tradein-button").click(function (e) {
            e.preventDefault(); // Prevent the default form submission

            $.ajax({
                type: "POST",
                url: $(this).parent("form").attr("action"), // Get the form's action URL
                success: function () {
                    // Redirect to the inventory index page after successful increment
                    window.location.href = "@Url.Action("Index", "Inventory")";
                },
                error: function () {
                    // Handle errors if necessary
                }
            });
        });
    });
</script>


