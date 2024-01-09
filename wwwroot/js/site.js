// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




function showModal(className) {
    var div = document.getElementById(className);
    div.className = "d-block";
}

function hideModal(className) {
    var div = document.getElementById(className);
    div.className = "d-none";
}