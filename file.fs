
function sum(a, b) {
    return a + b;
}

console.log(sum(5, 3));

function subtract(a, b) {
    return a - b;
}

console.log(subtract(5, 3));

function multiply(a, b) {
    return a * b;
}

console.log(multiply(5, 3));

function divide(a, b) {
    if (b === 0) {
        return "Нөлге бөлуге болмайды!";
    }
    return a / b;
}

console.log(divide(6, 3));
console.log(divide(6, 0));
