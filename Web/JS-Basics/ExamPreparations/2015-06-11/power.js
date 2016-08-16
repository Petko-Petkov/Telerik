function solve(params) {
    'use strict';
    let nk = params[0].split(' ').map(Number),
        n = nk[0],
        k = nk[1],
        numbers = params[1].split(' ').map(Number),
        elements = [],
        result = 0;
        
    for (var i = 0; i < k; i++) {
        for (var index = 0; index < n; index++) {
            let element = numbers[index],
                newElement;
            
            if (index === 0) {
                newElement = getValue(element, numbers[n - 1], numbers[index + 1])
                elements.push(newElement);
            } else if (index === n - 1) {
                newElement = getValue(element, numbers[0], numbers[index - 1]);
                elements.push(newElement);
            } else {
                newElement = getValue(element, numbers[index - 1], numbers[index + 1]);
                elements.push(newElement);
            }     
        }

        numbers = elements;
        elements = [];
    }     

    function getValue(element, left, right) {
        if(element === 0) {
            return Math.abs(left - right);
        } else if(element === 1) {
            return left + right;
        } else if (element % 2 === 0) {
            return Math.max(left, right);
        } else {
            return Math.min(left, right);
        }
    }

    for (var num in numbers) {
        if (numbers.hasOwnProperty(num)) {
            var element = numbers[num];
            result += element;
        }
    }

    console.log(result);
}