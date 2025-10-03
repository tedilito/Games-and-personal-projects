document.addEventListener('DOMContentLoaded', (event) => {
    const rulesButton = document.querySelector('.rulesButton');
    const rulesPopup = document.getElementById('rulesPopup');
    const closeButton = document.querySelector('.close');

    rulesButton.addEventListener('click', () => {
        rulesPopup.style.display = 'block';
    });

    closeButton.addEventListener('click', () => {
        rulesPopup.style.display = 'none';
    });

    window.addEventListener('click', (event) => {
        if (event.target == rulesPopup) {
            rulesPopup.style.display = 'none';
        }
    });
});