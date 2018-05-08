// Write your JavaScript code.
$(".dropdown-menu a").click(function() {
    $("#selected").text($(this).text());
});