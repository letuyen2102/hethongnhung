//DataTable
$(document).ready(function () {
    $("#room_table").DataTable({
        responsive: true,
        dom: 'lBfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        lengthMenu: [10, 25, 50, 100],
    });
});