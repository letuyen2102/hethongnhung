//DataTable
$(document).ready(function () {
    $("#degree_table").DataTable({
        responsive: true,
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        data: [
            {
                id: "MBP21522778",
                name: "System Architect",
                creator: "Administrator",
                createAt: "2011/04/25",
                editor: "Edinburgh",
                editAt: "2023/04/25",
            },
            {
                id: "MBP21522778",
                name: "System Architect",
                creator: "Administrator",
                createAt: "2011/04/25",
                editor: "Edinburgh",
                editAt: "2023/04/25",
            },
            {
                id: "MBP21522778",
                name: "System Architect",
                creator: "Administrator",
                createAt: "2011/04/25",
                editor: "Edinburgh",
                editAt: "2023/04/25",
            },
            {
                id: "MBP21522778",
                name: "System Architect",
                creator: "Administrator",
                createAt: "2011/04/25",
                editor: "Edinburgh",
                editAt: "2023/04/25",
            }
        ],
        columns: [
            { data: "id" },
            { data: "name" },
            { data: "creator" },
            { data: "createAt" },
            { data: "editor" },
            { data: "editAt" },
            {
                data: "id",
                render: function (data) {
                    return `
                        <div class="d-flex align-items-center justify-content-evenly">
                            <button type="button" class="btn btn-warning"><i class="bi bi-pencil-square text-white"></i></button>
                            <button type="button" class="btn btn-primary"><i class="bi bi-trash-fill text-white"></i></button>
                        </div>
                    `
                }
            }

        ],
    });
});