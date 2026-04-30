let body = document.body;
let firstInput = body.querySelector(".input1");
let secondInput = body.querySelector(".input2");
let output = body.querySelector(".output");

function getValue() {
    let firstInput = body.querySelector(".input1");
    let secondInput = body.querySelector(".input2");
    if (firstInput.value == "" || secondInput.value == "") {
        alert("Please enter a value")
        return false;
    }

    return true;
}

function resetValues() {
    firstInput.value = "";
    secondInput.value = '';
}

function Sum() {
    if (!getValue()) return;
    output.value = Number(firstInput.value) + Number(secondInput.value);
    resetValues();
}

document.querySelector(".plus").addEventListener("click", Sum);

function Sub() {
    if (!getValue()) return;
    output.value = Number(firstInput.value) - Number(secondInput.value);
    resetValues();
}
document.querySelector(".minus").addEventListener("click", Sub);

function Mult() {
    if (!getValue()) return;
    output.value = Number(firstInput.value) * Number(secondInput.value);
    resetValues();
}
document.querySelector(".mult").addEventListener("click", Mult);

function Divide() {
    if (!getValue()) return;
    if (firstInput.value == 0 || secondInput.value == 0) {
        alert("You cannot divide a number with zero")
    } else {
        output.value = (Number(firstInput.value) / Number(secondInput.value)).toFixed(2);
        resetValues();
    }

}
document.querySelector(".divide").addEventListener("click", Divide);
