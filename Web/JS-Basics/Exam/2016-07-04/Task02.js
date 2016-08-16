function solve(args) {
    'use strict';
    let rowsCols = args[0].split(' ').map(Number),
        debrisArray = args[1].split(';'),
        movesLength = +args[2];

    let rows = rowsCols[0],
        cols = rowsCols[1],
        koce = new Array(cols),
        cuki = new Array(cols),
        board = fillDebris();
    
    var koceTanks = {
        0: true,
        1: true,
        2: true,
        3: true
    }


    var cukiTanks = {
        4: true,
        5: true,
        6: true,
        7: true
    }

    for (var i = 3; i < movesLength + 3; i++) {
        var commandsStr = args[i].split(' ');

        executeCommand(commandsStr);
    }

    function executeCommand(params) {
        if (params.length == 3) {
            shoot(params);
        } else {
            moveTank(params);
        }
    }

    function shoot(params) {
        var tankId = +params[1],
            direction = params[2];

        var currentPosition = getPosition(tankId);

        if (direction == 'u') {
            for (var row = currentPosition.row - 1; row >= 0; row-=1) {
                var element = board[row][currentPosition.col];
                if(element) {
                    if (!isNaN(element)) {
                        koceTanks[element] = false;
                        cukiTanks[element] = false;
                        console.log('Tank ' + element + ' is gg');
                        checkForGG();
                    }
                    clearPosition({row: row, col: currentPosition.col});
                    return;
                }
            }
        } else if( direction == 'd') {
            for (var row = currentPosition.row + 1; row < rows; row+=1) {
                var element = board[row][currentPosition.col];
                if(element) {
                    if (!isNaN(element)) {
                        koceTanks[element] = false;
                        cukiTanks[element] = false;
                        console.log('Tank ' + element + ' is gg');
                        checkForGG();
                    }
                    clearPosition({row: row, col: currentPosition.col});
                    return;
                }
            }
        } else if (direction == 'l') {
            for (var col = currentPosition.col - 1; col <= 0; col--) {
                var element = board[currentPosition.row][col];
                if (element) {
                    if (!isNaN(element)) {
                        koceTanks[element] = false;
                        cukiTanks[element] = false;
                        console.log('Tank ' + element + ' is gg');
                        checkForGG();
                    }
                    clearPosition({row: currentPosition.row, col: col});
                    return;
                }   
            }
        } else if (direction == 'r') {
            for (var col = currentPosition.col + 1; col > cols; col++) {
                var element = board[currentPosition.row][col];
                if (element) {
                    if (!isNaN(element)) {
                        koceTanks[element] = false;
                        cukiTanks[element] = false;
                        console.log('Tank ' + element + ' is gg');
                        checkForGG();
                    }
                    clearPosition({row: currentPosition.row, col: col});
                    return;
                }   
            }
        }         
    }

    function checkForGG() {
        var defeated = true;

        for (var key in koceTanks) {
            if (koceTanks.hasOwnProperty(key)) {
                var element = koceTanks[key];
                if (element) {
                    defeated = false;
                }
            }
        }

        if (defeated) {
            console.log('Koce is gg')
            return;
        }

        for (var key in cukiTanks) {
            if (cukiTanks.hasOwnProperty(key)) {
                var element = cukiTanks[key];
                if (element) {
                    defeated = false;
                }
            }
        }

        if (defeated) {
            console.log('Cuki is gg')
            return;
        }
    }

    function moveTank(params) {
        let id = +params[1],
            moves = +params[2],
            direction = params[3];
        
        var currentPosition = getPosition(id);
        
        if (direction == 'u') {
            for (var row = currentPosition.row - 1; row >= currentPosition.row - moves || 0; row-=1) {
                var element = board[row][currentPosition.col];
                if(element) {
                    clearPosition(currentPosition);
                    setPosition(row + 1, currentPosition.col, id);
                    return;
                }
            }
            clearPosition(currentPosition);
            setPosition(row + 1, currentPosition.col, id);
        } else if( direction == 'd') {
            for (var row = currentPosition.row + 1; row < currentPosition.row + moves || rows; row+=1) {
                var element = board[row][currentPosition.col];
                if(element) {
                    clearPosition(currentPosition);
                    setPosition(row - 1, currentPosition.col, id);
                    return;
                }
            }
            clearPosition(currentPosition);
            setPosition(row - 1, currentPosition.col, id);
        } else if (direction == 'l') {
            for (var col = currentPosition.col - 1; col < currentPosition.col - moves || 0; col--) {
                var element = board[currentPosition.row][col];
                if (element) {
                    clearPosition(currentPosition);
                    setPosition(col + 1, currentPosition.row, id);
                    return;
                }   
            }

            clearPosition(currentPosition);
            setPosition(col + 1, currentPosition.row, id);
        } else if (direction == 'r') {
            for (var col = currentPosition.col + 1; col > currentPosition.col + moves || cols; col++) {
                var element = board[currentPosition.row][col];
                if (element) {
                    clearPosition(currentPosition);
                    setPosition(col + 1, currentPosition.row, id);
                    return;
                }   
            }

            clearPosition(currentPosition);
            setPosition(col + 1, currentPosition.row, id);
        }         
    }

    function setPosition(row, col, id) {
        board[row][col] = id;
    }

    function clearPosition(position) {
        board[position.row][position.col] = '';
    }

    function getPosition(id) {
        for (var row = 0; row < rows; row++) {
            for (var col = 0; col < cols; col++) {
                var element = board[row][col];
                if (element == id) {
                    return {row: row, col: col};
                }
            }             
        }
    }

    function fillDebris() {
        let arr = [],
            last = 4;

        for (var index = 0; index < cols; index++) {
            if (index < 4) {
                koce[index] = index;
            }
        }

        for (var index = cols - 1; index >= 0; index--) {
            if (index >= cols - 4) {
                cuki[index] = last;
                last += 1;
            }
        }
        
        for (var row = 0; row < rows; row++) {
            arr[row] = new Array(cols);
        }

        arr[0] = koce,
        arr[rows - 1] = cuki;
        
        for (var i = 0; i < debrisArray.length; i+=1) {
            var debrisCoord = debrisArray[i].split(' ').map(Number);

            arr[debrisCoord[0]][debrisCoord[1]] = 'd';
        }

        return arr;
    } 


    console.log(board)
}

solve([
    '5 5',
    '2 0;2 1;2 2;2 3;2 4',
    '13',
    'mv 7 2 l',
    'x 7 u',
    'x 0 d',
    'x 6 u',
    'x 5 u',
    'x 2 d',
    'x 3 d',
    'mv 4 1 u',
    'mv 4 4 l',
    'mv 1 1 l',
    'x 4 u',
    'mv 4 2 r',
    'x 2 d'
]);