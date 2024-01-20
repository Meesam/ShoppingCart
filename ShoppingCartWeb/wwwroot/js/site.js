// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

localStorage.theme = 'dark'
$("#chkLocalStorage").on("click", function () {
    localStorage.theme === 'light' ? 'dark' : "light"
    if (localStorage.theme === 'dark' || (!('theme' in localStorage) && window.matchMedia('(prefers-color-scheme: dark)').matches)) {
        document.documentElement.classList.add('dark')
        localStorage.theme = 'light'
    } else {
        document.documentElement.classList.remove('dark')
        localStorage.theme = 'dark'
    }
});
