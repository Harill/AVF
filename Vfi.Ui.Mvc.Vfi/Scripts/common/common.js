// domready
$(document).ready(function () {

    // loading 
    $('.t-overlay').hide();

    jQuery.ajaxSetup({
        beforeSend: function () {
            // $('#loading-dialog').show().delay(200);
            //$('.t-overlay').show().delay(200);
        },
        complete: function () {
            //$('#loading-dialog').hide();
            $('.t-overlay').hide();
        },
        success: function () {
            //$('#loading-dialog').hide();
            $('.t-overlay').hide();
        }
    });

    //    $("#loading-dialog").ajaxStop(function () {
    //        $(this).hide();
    //        
    //    });
    $(".t-overlay").ajaxStop(function () {
        //$(this).hide();
    });
    // loading 

    // close Grid Popup
    $(document).keydown(function (e) {
        if (e.keyCode == 27) { // esc
            var windowLogin = $("#Window").data('tWindow');
            // if not windowLogin, window will remove
            if (windowLogin == null) {
                var applicationFormShipWindow = $("#ApplicationFormShipWindow").data("tWindow");
                var applicationFormCargoWindow = $("#ApplicationFormCargoWindow").data("tWindow");

                var estCompensationShipWindow = $("#EstCompensationShipWindow").data("tWindow");
                var estCompensationCargoWindow = $("#EstCompensationCargoWindow").data("tWindow");

                var quickCustomerWindow = $("#QuickCustomerWindow").data("tWindow");
                var quickShipWindow = $("#QuickShipWindow").data("tWindow");
                var quickDepartmentWindow = $("#QuickDepartmentWindow").data("tWindow");
                var quickCargoTypeWindow = $("#QuickCargoTypeWindow").data("tWindow");
                var quickCargoWindow = $("#QuickCargoWindow").data("tWindow");
                
                if (applicationFormShipWindow != null) {
                    applicationFormShipWindow.close();
                }
                else if (applicationFormCargoWindow != null) {
                    applicationFormCargoWindow.close();
                }
                else if (estCompensationShipWindow != null) {
                    estCompensationShipWindow.close();
                }
                else if (estCompensationCargoWindow != null) {
                    estCompensationCargoWindow.close();
                }
                else if (quickCustomerWindow != null || quickShipWindow != null || quickDepartmentWindow != null || quickCargoTypeWindow != null || quickCargoWindow != null) {

                    if ($("#QuickCustomerWindow").is(':visible'))
                        quickCustomerWindow.close();
                    if ($("#QuickShipWindow").is(':visible'))
                        quickShipWindow.close();
                    if ($("#QuickDepartmentWindow").is(':visible'))
                        quickDepartmentWindow.close();
                    if ($("#QuickCargoTypeWindow").is(':visible'))
                        quickCargoTypeWindow.close();
                    if ($("#QuickCargoWindow").is(':visible'))
                        quickCargoWindow.close();
                }
                else {
                    // remove overlay
                    $('.t-overlay').hide();
                    // remove window
                    //$('#GridMajorPopUp').remove();
                    //$('.t-window').remove();
                    //$('.t-window').hide();
                    //$('.t-window').data('tWindow').close();
                    $('.t-window').remove();
                }
            }
        }
    });


});               // close tag - domready

// validate
function validateBeforeCreateForm(value, msg) {
    if (value == "" || value === null) {
        //alert(msg);
        return false;
    }
    else return true;
}

// Function Show
function runEffectShow(target, typeEffect) {
    // get effect type from 
    var selectedEffect = typeEffect;

    // most effect types need no options passed by default
    var options = {};
    // some effects have required parameters
    if (selectedEffect === "scale") {
        options = { percent: 100 };
    } else if (selectedEffect === "size") {
        options = { to: { width: 280, height: 185} };
    }

    // run the effect
    $(target).show(selectedEffect, options, 500);
};
// Function Hide
function runEffectHide(target, typeEffect) {
    // get effect type from 
    var selectedEffect = typeEffect;

    // most effect types need no options passed by default
    var options = {};
    // some effects have required parameters
    if (selectedEffect === "scale") {
        options = { percent: 0 };
    } else if (selectedEffect === "size") {
        options = { to: { width: 200, height: 60} };
    }

    // run the effect
    $(target).hide(selectedEffect, options, 1000);
};

// formatDateClientTemplate
function formatDateClientTemplate(d) {
    return $.telerik.formatString("{0:dd/MM/yyyy}", d);
}


//// dialog confirm windows
var dialogConfirm;
function confirmDialogWindow(target) {

    dialogConfirm = $.telerik.window.create({
        title: "Confirmation",
        html: "Are you sure you wish to continue?<br /><br />" +
		"<div align='center'>" +
        "   <button id='btnConfirmYes' class='t-button' onclick=window.confirmResult($('#resultTarget').val());dialogConfirm.close();  >" +
        "       <span class='t-icon t-insert'></span>" +
        "       Continute" +
        "   </button>" +

		"   <button class='t-button' onclick=dialogConfirm.close();>" +
        "       <span class='t-icon t-cancel'></span>" +
        "       Cancel" +
        "   </button>" +

        "   <input type='hidden' id='resultTarget' value='" + target + "' />" +


        "</div>",

        modal: true,
        resizable: false,
        draggable: true,
        visible: false,
        onClose: function (e) {
            e.preventDefault();
            $(this).data('tWindow').destroy();
        }
    }).data('tWindow').open().center();
}
function abc(value) {
    alert(value);
}
//// dialog confirm windows

//// dialog windows
var dialog;
function dialogWindow(msg) {

    dialog = $.telerik.window.create({
        title: "Information",
        html: msg + "<br /><br />" +
		"<div align='center' style='min-width: 150px;'>" +

        //"   <button id='btnInfo' class='t-button' onclick=$('.t-window').hide();$('.t-overlay').hide();>" +
        "   <button id='btnInfo' class='t-button' onclick=dialog.close() >" +
        "       <span class='t-icon t-insert'></span>" +
        "       Continue" +
        "   </button>" +

        "</div>",
        modal: true,
        resizable: false,
        draggable: false,
        visible: false,
        onClose: function (e) {
            $(this).data('tWindow').center();
        }
    }).data('tWindow').open().center();
}
//// dialog windows

///////////////////////////////////////////

