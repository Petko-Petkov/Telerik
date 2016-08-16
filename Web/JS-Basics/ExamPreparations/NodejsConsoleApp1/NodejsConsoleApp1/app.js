function solve(args) {
    'use strict';
    let rows = +args[0],
        cols = +args[1],
        board = new Array(new Array()),
        boardArray = args.slice(2, rows + 2),
        moves = args.slice(2 + rows),
        figures = {};
    
    for (var row = rows; row > 0; row -= 1) {
        var currentLine = boardArray[rows - row];
        board[row] = currentLine;
        for (var col = 0; col < cols; col++) {
            var lineSymbol = currentLine[col];
            if (lineSymbol === '-') {
                continue;
            }
            var figure = {};
            figure[lineSymbol] = [];
            var colPosition = String.fromCharCode(col + 97);
            
            figures[colPosition + row] = figure;
        }
    }
    
    console.log(figures);
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