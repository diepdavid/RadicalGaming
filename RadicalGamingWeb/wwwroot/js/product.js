$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    console.log("Trying to load dataTable");
    dataTable = $('#tblData').DataTable({
         "ajax": { url:'/admin/product/getall' },
        "columns": [
            { data: 'title', "width": "15%" },
            { data: 'price', "width": "15%" },
            { data: 'category.name', "width": "15%" }
        ]
    });
    console.log("Has loaded dataTable", dataTable);
}
