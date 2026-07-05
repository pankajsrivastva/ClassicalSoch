document.addEventListener('DOMContentLoaded', function () {
    const loader = document.getElementById('page-loader');
    if (loader) {
        loader.style.display = 'flex';
        window.addEventListener('load', () => setTimeout(() => loader.style.display = 'none', 600));
    }

    const backToTop = document.querySelector('.back-to-top');
    if (backToTop) {
        window.addEventListener('scroll', function () {
            backToTop.style.display = window.scrollY > 300 ? 'flex' : 'none';
        });
    }
});
