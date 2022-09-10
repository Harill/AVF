var onProcessing = false;
function OnProcessingData() {
    if (!onProcessing) {
        onProcessing = true;
        var processings = document.querySelectorAll('.processButton');
        for (var i = 0; i < processings.length; i++) {
            var processing = processings[i];
            processing.innerHTML = "<span class='t-icon t-refresh t-loading'></span> (Chờ xử lý)";
            processing.classList.add('processing');
        }
    }   
}
function OnProcessedData() {
    if (onProcessing) {
        var processings = document.querySelectorAll('.processButton');
        for (var i = 0; i < processings.length; i++) {
            var processing = processings[i];
            if (processing && processing.className.includes("processing")) {
                processing.classList.remove('processing');
                processing.innerHTML = "<span></span>";
            }
        }
        onProcessing = false;
    }
}