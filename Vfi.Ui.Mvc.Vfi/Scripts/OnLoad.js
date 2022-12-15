var onLoading = false;
function OnLoadingData() {
    if (!onLoading) {
        onLoading = true;
        var loadings = document.querySelectorAll('.loadButton');
        for (var i = 0; i < loadings.length; i++) {
            var loading = loadings[i];
            loading.innerHTML = "<span class='t-icon t-refresh t-loading'></span> (Chờ load)";
            loading.classList.add('loading');
        }
    }
}
function OnLoadedData() {
    if (onLoading) {
        var loadings = document.querySelectorAll('.loadButton');
        for (var i = 0; i < loadings.length; i++) {
            var loading = loadings[i];
            if (loading && loading.className.includes("loading")) {
                loading.classList.remove('loading');
                loading.innerHTML = "<span></span>";
            }
        }
        onLoading = false;
    }
}
