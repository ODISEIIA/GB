'use strict'
function addition(a, b) {
    return a + b;
}

function substract(a, b){
    return a - b;
}

function division(a, b){
    return a / b;
}

function multiplication(a, b){
    return a * b;
}



function mathOperation(arg1, arg2, operation){
    switch (operation) {
        case "sum":
             return addition(arg1, arg2);
          
        case "sub":
            return substract(arg1, arg2);
           
        case "div":
            return division(arg1, arg2);
            
        case "mult":
            return multiplication(arg1, arg2);
    }
}
console.log(mathOperation(6,7,"sum"));
console.log(mathOperation(6,7,"sub"));
console.log(mathOperation(6,7,"div"));
console.log(mathOperation(6,7,"mult"));