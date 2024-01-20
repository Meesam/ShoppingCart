/** @type {import('tailwindcss').Config} */
module.exports = {
    darkMode: 'class',
    content: ["./Views/**/*.{cshtml,razor}", "./wwwroot/js/**/*.js", "./Area/**/*.{cshtml,razor}"],
    theme: {
        extend: {},
    },
    plugins: [],
}

