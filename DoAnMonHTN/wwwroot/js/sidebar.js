var checkUrl = (urlString) => {
    console.log(window.location.pathname)
    var currentUrl = new URL(window.location.href);

    var url = new URL(urlString);
    let n = currentUrl.pathname.search(url.pathname)
    if (currentUrl.pathname == url.pathname) {
        let n = currentUrl.pathname.search(url.pathname)
        return true
    }
    return false
}
var links = document.querySelectorAll('.list-option a')
console.log(location.pathname)
for (var i = 0; i < links.length; i++) {
    if (checkUrl(links[i].href)) {
        links[i].classList.add('bg-primary')
    }
}