const words = [
    { word: "Училище", hint: "Място за обучение" },
    { word: "Очила", hint: "Носени на лицето за подобряване на зрението" },
    { word: "Програма", hint: "Компютърен софтуер" },
    { word: "Компютър", hint: "Електронно устройство за обработка на данни" },
    { word: "Картоф", hint: "Зеленчук, използван за приготвяне на пържени картофи" },
    { word: "Тиква", hint: "Оранжев зеленчук, използван за приготвяне на пай" },
    { word: "Земя", hint: "Планетата, на която живеем" },
    { word: "Интернет", hint: "Глобална мрежа за комуникация" },
    { word: "Алгоритъм", hint: "Последователност от стъпки за решаване на проблем" },
    { word: "Чорап", hint: "Текстилно изделие, което се обува на крака" },
    { word: "Спанак", hint: "Зеленолистен зеленчук, богат на желязо" },
    { word: "Свещ", hint: "Източник на светлина, направен от восък" }
];

let timerInterval, timeLeft = 60, timerPaused = false, currentWord, points = 0;
let countGuessedWords = 0;  
function getRandomWord() {
    if (!words.length) return showPopup();
    const randomIndex = Math.floor(Math.random() * words.length);
    return words.splice(randomIndex, 1)[0];
}

function shuffleArray(array) {
    for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
}

function displayWord(wordKeyAndValuePair, showHint = false) {
    currentWord = wordKeyAndValuePair;
    const { word, hint } = wordKeyAndValuePair;
    const blanksContainer = document.getElementById('blanks');
    const lettersContainer = document.getElementById('letters');
    blanksContainer.innerHTML = '';
    lettersContainer.innerHTML = '';
    document.getElementById('message').textContent = '';
    document.getElementById('retryButton').style.display = 'none';
    document.getElementById('hintButton').style.display = 'block'; 
    word.split('').forEach(() => {
        const blank = document.createElement('span');
        blank.className = 'blank';
        blanksContainer.appendChild(blank);
    });

    const letters = word.split('');
    shuffleArray(letters);
    letters.forEach(letter => {
        const letterElement = document.createElement('div');
        letterElement.className = 'letter';
        letterElement.textContent = letter;
        letterElement.onclick = () => moveLetter(letterElement, word);
        lettersContainer.appendChild(letterElement);
    });

    if (showHint) {
        document.getElementById('hintMessage').textContent = hint;
        document.getElementById('hintPopup').style.display = 'block';
        document.getElementById('hintButton').style.display = 'none';
    }

    resetTimer();
}

function resetTimer() {
    clearInterval(timerInterval); 
    timerInterval = setInterval(updateTimer, 1000);
    updateTimer(); 
}

function moveLetter(letterElement, word) {
    const blanks = document.querySelectorAll('.blank');
    for (let blank of blanks) {
        if (!blank.textContent) {
            blank.textContent = letterElement.textContent;
            letterElement.style.visibility = 'hidden';
            checkWord(word);
            break;
        }
    }
}

function checkWord(word) {
    const guessedWord = Array.from(document.querySelectorAll('.blank')).map(blank => blank.textContent).join('');
    if (guessedWord === word) {
        points += 10;
        timeLeft += 5;
        updatePoints();
        triggerConfetti();
        countGuessedWords++;
        clearInterval(timerInterval); 
        document.getElementById('hintButton').style.display = 'none'; 
        setTimeout(() => {
            displayWord(getRandomWord(), false);
        }, 2000);
    } else if (guessedWord.length === word.length) {
        clearInterval(timerInterval); 
        document.getElementById('retryButton').style.display = 'block';
        document.getElementById('hintButton').style.display = 'none'; 

       
    }
}

function updateTimer() {
    const timerElement = document.getElementById('timer');
    if (timeLeft <= 0) {
        clearInterval(timerInterval);
        timerElement.textContent = "00:00";
        return showPopup();
    }
    timerElement.style.color = timeLeft <= 10 ? 'red' : 'black';
    timerElement.textContent = `${String(Math.floor(timeLeft / 60)).padStart(2, '0')}:${String(timeLeft % 60).padStart(2, '0')}`;
    timeLeft--;
}

function showPopup() {
    document.getElementById('popupMessage').textContent = `Страхотно, ти позна ${countGuessedWords} думи!`;
    document.getElementById('popup').style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
    document.body.style.pointerEvents = 'none';
    document.getElementById('popup').style.pointerEvents = 'auto';
}

function updatePoints() {
    document.getElementById('points').textContent = `Points: ${points}`;
}

function triggerConfetti() {
    confetti({ particleCount: 100, spread: 70, origin: { y: 0.6 } });
}

function showHint() {
    clearInterval(timerInterval);
    timerPaused = true;
    document.getElementById('hintMessage').textContent = currentWord.hint;
    document.getElementById('hintPopup').style.display = 'block';
    points -= 5;
    updatePoints();
}

function hideHint() {
    document.getElementById('hintPopup').style.display = 'none';
    if (timerPaused) {
        timerPaused = false;
        resetTimer(); 
    }
    document.getElementById('hintButton').style.display = 'block';
}

window.onload = function () {
    currentWord = getRandomWord();
    displayWord(currentWord, false);
    resetTimer();
    document.getElementById('retryButton').onclick = () => {
        clearInterval(timerInterval); 
        timeLeft = 60; 
        displayWord(currentWord, false); 
        resetTimer(); 
    };

    const playAgainBtn = document.getElementById('playAgainButton');
    const mainMenuBtn = document.getElementById('mainMenuButton');
    if (playAgainBtn) playAgainBtn.onclick = () => location.reload();
    if (mainMenuBtn) mainMenuBtn.onclick = () => window.location.href = 'startPage.html';
};
