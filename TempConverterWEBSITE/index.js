const but1 = document.getElementById("celsiustoFahrenheit");
const but2 = document.getElementById("fahrenheitCelsiusto");
const inputTemp = document.getElementById("tempInput");
const result = document.getElementById("result");
let temp = 15; 


function ConvertTemp() {
    if (but1.checked) {
        temp = Number(inputTemp.value) * 9/5 + 32;
        result.textContent = temp.toFixed(1) + " °F";
    }
    else if (but2.checked) {
        temp = (Number(inputTemp.value) - 32) * 5/9;
       result.textContent = temp.toFixed(1) + " °C";
    }
    else{
        result.textContent = "Please select a conversion option.";
    }
}