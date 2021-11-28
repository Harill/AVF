
Number.prototype.format = function (n, x) {
    var re = '\\d(?=(\\d{' + (x || 3) + '})+' + (n > 0 ? '\\.' : '$') + ')';
    return this.toFixed(Math.max(0, ~~n)).replace(new RegExp(re, 'g'), '$&,');
};

function RefreshGrid(gridName) {
    $('#' + gridName).data("tGrid").ajaxRequest();
}
function RefreshCombobox(name) {
    var cbo = $('#' + name).data("tComboBox");
    cbo.reload();
    cbo.text("");
    cbo.value("");
}
function RefreshDropDownList(name) {
    $('#' + name).data("tDropDownList").reload();
}
function grid_OnRowSelect(e) {
    var grid = $(this).data('tGrid');

    //var $i = grid.$rows().index(e.row);

    //var isMinus = $(this).find("td.t-hierarchy-cell a").eq($i).is(".t-minus");
    var className = e.row.getElementsByTagName("a")[0].className;
    var isMinus = className.search("t-minus");
    if (isMinus !== -1) {
        grid.collapseRow(e.row);
    } else {
        grid.expandRow(e.row);
    }
}

function grid_OnError(args) {

    var btn = document.querySelector('#twoToneButton');
    if (btn && btn.className.includes("loading")) {
        btn.classList.remove('loading');
        btn.innerHTML = "<span></span>";
    }
    if (args.textStatus == "modelstateerror" && args.modelState) {
        var message = "Errors:\n";
        $.each(args.modelState, function (key, value) {
            if ('errors' in value) {
                $.each(value.errors, function () {
                    message += this + "\n";
                });
            }
        });
        args.preventDefault();
        alert(message);
    }
}