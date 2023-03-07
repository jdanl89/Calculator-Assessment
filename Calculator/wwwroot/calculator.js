function calculate(operator) {
    var operand1 = document.getElementById("number1").value;
    var operand2 = document.getElementById("number2").value;
    var url;

    switch (operator) {
        case 0:
            url = `https://localhost:44388/calculator/add?a=${operand1}&b=${operand2}`;
        break;
        case 1:
            url = `https://localhost:44388/calculator/subtract?a=${operand1}&b=${operand2}`;
        break;
        case 2:
            url = `https://localhost:44388/calculator/multiply?a=${operand1}&b=${operand2}`;
        break;
        case 3:
            url = `https://localhost:44388/calculator/divide?a=${operand1}&b=${operand2}`;
        break;
    }

    fetch(url)
        .then(res => res.text())
        .then(data => document.getElementById("result").innerHTML = data)
        .catch(error => console.error(error));
}