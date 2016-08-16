function solve(args) {
    'use strict';

    let inputArray = args[0].split(' ').map(Number),
        currentMax = Number.MIN_VALUE,
        outputMax = Number.MIN_VALUE,
        currentArray = [],
        currentLeftHeight = inputArray[0],
        currentRightHeight = Number.MIN_VALUE,
        currentLeftIndex = 0,
        currentIndex = 1,
        currentElement,
        prevElement,
        nextElement;
    
    

    function sumArray(array) {
        var sum = 0;

        for (var i = 0; i < array.length; i++) {
            var element = array[i];
            sum += element;
        }

        return sum;
    }

    while (currentIndex < inputArray.length) {
        while (currentIndex < inputArray.length){
            currentElement = inputArray[currentIndex],
            prevElement = inputArray[currentIndex - 1];

            if (prevElement < currentElement) {
                break;    
            }
            currentIndex++;
        }

        while (currentIndex < inputArray.length) {
            currentElement = inputArray[currentIndex],
            nextElement = inputArray[currentIndex + 1];

            if (currentElement > nextElement || !nextElement) {
                currentIndex++;
                currentArray = inputArray.slice(currentLeftIndex, currentIndex);
                currentLeftIndex = currentIndex - 1;
                currentMax = sumArray(currentArray);
            
                if (currentMax > outputMax) {
                    outputMax = currentMax;
                }
                break;    
            }

            currentIndex++;
        }
    }

    console.log(outputMax);
}

solve([
     "5 1 7 6 5 6 4 2 3 8"
]);