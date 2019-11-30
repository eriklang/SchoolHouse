

var dataTable;

$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/student/GetAll",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "firstName", "width": "25%" },
            { "data": "lastName", "width": "25%" },
            { "data": "dob", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/student/Upsert/${data}" class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-edit'></i> Edit
                                </a>
                                &nbsp;
                                <a onclick=Delete("/Admin/student/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                                    <i class='far fa-trash-alt'></i> Delete
                                </a>
                            </div>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No records found."
        },
        "width": "100%"
    });
}