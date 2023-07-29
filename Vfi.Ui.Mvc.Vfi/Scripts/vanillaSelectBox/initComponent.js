
var selectBox2 = null;
function empty(id) {
    if (selectBox2 != null) {
        selectBox2.empty();
    }
}
function init(id) {
    var select2 = document.getElementById(id);                
    selectBox2 = new vanillaSelectBox(
        ("#" + id),
        {
            "disableSelectAll": true,
            "maxHeight": 200,
            "itemsSeparator": ", ",
            "search": true,
            "translations": { "all": "All", "items": "items", "selectAll": "Check All", "clearAll": "Clear All" }
        });
            
}

function getResultString(id) {
    var select2 = document.getElementById(id);
    return select2.getResult().join(', ');
}