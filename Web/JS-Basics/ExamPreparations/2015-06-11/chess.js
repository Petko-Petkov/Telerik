function solve(args) {
    'use strict';
    let rows = +args[0],
        cols = +args[1],
        board = new Array(new Array()),
        boardArray = args.slice(2, rows + 2),
        moves = args.slice(2 + rows + 1),
        figures = {};

    for (var row = rows; row > 0; row-=1) {
        var currentLine = boardArray[rows - row];
        board[row] = currentLine;
        for (var col = 0; col < cols; col++) {
            var lineSymbol = currentLine[col];
            if (lineSymbol ===  '-') {
                continue;
            }
            var figure = {},
                colPosition = String.fromCharCode(col + 97);
            figure[lineSymbol] = [];

            figures[colPosition + row] = figure;
        }
    }

    for (var key in figures) {
        if (figures.hasOwnProperty(key)) {
            var figure = figures[key];
            for (var el in figure) {
                if (figure.hasOwnProperty(el)) {
                    var arr = figure[el];
                    arr.push(getPossibleMoves(key, el));
                }
            }
        }
    }

    function getPossibleMoves(coords, figure) {
        switch (figure) {
            case 'R':
                return getRookMoves(coords);
            case 'B':
                return getBishopMoves(coords);
            default:
                return getQueenMoves(coords);
        }
    }

    function getBishopMoves(coords) {
        var possibleMoves = [],
            currentRow = +coords[1],
            currentCol = coords[0].charCodeAt() - 97,
            currentLine;
        
        for (var row = currentRow + 1, col = currentCol + 1; row <= rows && col < cols; row+=1, col+=1) {
            currentLine = board[row];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + row);
            } else {
                break;
            }
        }

        for (var row = currentRow + 1, col = currentCol - 1; row <= rows && col >= 0; row+=1, col-=1) {
            currentLine = board[row];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + row);
            } else {
                break;
            }
        }

        for (var row = currentRow - 1, col = currentCol - 1; row >=0 && col >= 0; row-=1, col-=1) {
            currentLine = board[row];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + row);
            } else {
                break;
            }
        }

        for (var row = currentRow - 1, col = currentCol + 1; row >=0 && col < cols; row-=1, col+=1) {
            currentLine = board[row];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + row);
            } else {
                break;
            }
        }

        return possibleMoves;
    }

    function getQueenMoves(coords) {
        var possibleMoves = getRookMoves(coords),
            bishopMoves = getBishopMoves(coords);
            possibleMoves = possibleMoves.concat(bishopMoves);

        return possibleMoves;
    }

    function getRookMoves(coords) {
        var possibleMoves = [],
            currentRow = +coords[1],
            currentCol = coords[0].charCodeAt() - 97,
            currentLine;
        
        for (var i = currentRow + 1; i <= rows; i+=1) {
            currentLine = board[i];
            if(currentLine[currentCol] === '-') {
                possibleMoves.push(coords[0] + i);
            } else {
                break;
            }
        }

        for (var i = currentRow - 1; i >= 0 ; i-=1) {
            currentLine = board[i];
            if(currentLine[currentCol] === '-') {
                possibleMoves.push(coords[0] + i);
            } else {
                break;
            }
        }

        for (var col = currentCol - 1; col >= 0; col-=1) {
            currentLine = board[currentRow];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + currentRow);
            } else {
                 break;
            }
        }

        for (var col = currentCol + 1; col < cols; col+=1) {
            currentLine = board[currentRow];

            if(currentLine[col] === '-') {
                possibleMoves.push(String.fromCharCode(col + 97) + currentRow);
            } else {
                break
            }
        }

        return possibleMoves;
    }

    for (var key in moves) {
        if (moves.hasOwnProperty(key)) {
            var element = moves[key];
            var arr = element.split(' ');
            var from = arr[0],
                to = arr[1];

            checkIfValid(from, to);
        }
    }

    function checkIfValid(from, to) {
        var keys = Object.keys(figures),
            match = false;
        
        for (var key in keys) {
            if (keys.hasOwnProperty(key)) {
                var element = keys[key];
                if (element == from) {
                    match = true;
                    break;
                }
            }
        }

        if (!match) {
            console.log('no');
            return;
        }

        var figure = figures[from];
        var figureKeys = Object.keys(figure);
        var currKey = figureKeys[0];
        var arr = figure[currKey];

        for (var key in arr) {
            if (arr.hasOwnProperty(key)) {
                var element = arr[key];
                
                for (var j in element) {
                    if (element.hasOwnProperty(j)) {
                        var current = element[j];
                        
                        if (current === to) {
                            console.log('yes');
                            return;
                        }
                    }
                }
            }
        }

        console.log('no');
    }

    //console.log(figures);
}

solve([
    '3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'
]);