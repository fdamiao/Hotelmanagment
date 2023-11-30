// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready( function () {
    $('#myTable').DataTable({
        fixedColumns: true, responsive: true,
        buttons: [
            'copy', 'excel', 'pdf']
    });
} );
$(document).ready(function() {
    $('.Selectingle').select2();
});