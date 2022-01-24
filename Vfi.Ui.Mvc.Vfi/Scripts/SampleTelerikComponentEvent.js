// grid
// add parameter to get data
function grid_OnDataBinding(e) {
    var customerId = $("#Customer").data('tComboBox').value();
    if (customerId === "") {
        customerId = 0;
    }
    e.data = $.extend(e.data, {
        customerId: customerId,
    });
}



// combobox - dropdownlist
// add parameter to get data
function cbo_OnDataBinding(e) {
    var classifiedId = $('#MaterialClassifiedName').data('tDropDownList').value();
    if (classifiedId == "") classifiedId = 0;
    e.data = $.extend({}, e.data, { classifiedId: classifiedId });
}
// bind data by data
function cbo_OnChange() {
    var warehouseIssue = $("#WarehouseIssueName").data('tDropDownList').value();
    $.ajax({
        type: 'post',
        data: {
            warehouseId: warehouseIssue
        },
        dataType: 'json',
        url: '@Url.Action("SelectComboBoxWarehouseRotateById", "Warehouse", new { area = "Inv" })',
        timeout: 20000,
        success: function (data) {
            $("#WarehouseReceiptName").data('tDropDownList').dataBind(data);
            RefreshGrid("gridProductInventory");
            RefreshGrid("gridProductInventoryDetail");
        }
    });
}