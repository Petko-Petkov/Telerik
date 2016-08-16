function solve(args) {
    'use strict';
    let modelLength = +args[0],
        htmlLength = +args[modelLength + 1],
        model = generateModel(modelLength, args),
        inSection = false,
        inIf = true,
        inForeach = false,
        propKey = '',
        sectionModel = {},
        result = '',
        collection = '',
        iterator = '',
        toIterate = [];
    
    for (var index = modelLength + 2; index < args.length; index++) {
        var line = args[index];

        if (line.indexOf('}') > -1) {
            if (inForeach) {
                iterate();
            }
            inIf = true;
            inSection = false;
            inForeach = false;
            propKey = ' ';
            continue;
        }

        if (!inIf) {
            continue;
        }

        if (inForeach) {
            toIterate.push(line);
            continue;
        }

        if (line.trim().indexOf('@section') > -1) {
            var lineStr = line.split(' ');
            inSection = true;
            propKey = lineStr[1];
            sectionModel[propKey] = [];
            continue;
        }

        if (inSection) {
            sectionModel[propKey].push(line);
            continue;
        }

        if (line.indexOf('@renderSection') > -1) {
            var renderer =  line.split("\"");
            renderSection(renderer[1]);
            continue;
        }

        if (line.indexOf('@if') > -1) {
            var boolKey = line.split('(')[1];
            var endIndex = boolKey.indexOf(')');
            boolKey = boolKey.substring(0, endIndex);
            var boolValue = model[boolKey];
            if (boolValue == 'true') {
                inIf = true;
            } else {
                inIf = false;
            }
            continue;
        }

        if (line.indexOf('@foreach') > -1) {
            var rx = (/(\w+)\s+(\w+)\s+(\w+)\s+(\w+)/g);
            var match = rx.exec(line);
            collection = match[4];
            iterator = match[2];
            inForeach = true;
            continue;
        }

        if (line.indexOf('@@') > -1) {
            line = line.replace('@@', '@');
            console.log(line);
            continue;
        }

        if (line.indexOf('@') > -1) {
            let variable = line.split('@')[1]; 
            let p = variable.indexOf('<'),
                q = variable.indexOf(' ');
            var len = 0;
            if (p > -1 && q > -1) {
                len = Math.min(p, q);
            } else if (p > -1) {
                len = p; 
            } else if (q > -1){
                len = q;
            } else {
                len = variable.length - 1;
            }
            var modelIndex = variable.substring(0, len).trim();
            var toReplace = model[modelIndex];
            line = line.replace('@' + modelIndex.trim(), toReplace);
        }

        console.log(line);
    }

    function renderSection(renderKey) {
        for (var index = 0; index < sectionModel[renderKey].length; index++) {
            var element = sectionModel[renderKey][index];
            console.log(element);
        }
    }

    function iterate() {
        for (var j = 0; j < model[collection].length; j+=1) {
            for (var i = 0; i < toIterate.length; i+=1) {
                var line = toIterate[i];

                if (line.indexOf('@@') > -1) {
                    line = line.replace('@@', '@');
                } else if (line.indexOf('@') > -1) {
                    var rx = /\@\w+/g;
                    var matches = line.match(rx);
                    var match = matches[0] == '@' + iterator ? model[collection][i] : model[matches[0].substring(1)];
                    line = line.replace(matches[0], match);
                }

                console.log(line);
            }
        }
    }

    function generateModel(length, params) {
        var obj = {};

        for (var index = 1; index <= length; index++) {
            var line = params[index];
            var lineArr = line.split(':');
            var key = lineArr[0], 
                value = lineArr[1];

            if (value.indexOf(',') > -1) {
                value = value.split(',');
            }

            obj[key] = value;
        }

        return obj;
    }
}

solve([
 '6',
'title:Telerik Academy',
'showSubtitle:true',
'subTitle:Free training',
'showMarks:false',
'marks:3,4,5,6',
'students:Pesho,Gosho,Ivan',
'42',
'@section menu {',
'<ul id="menu">',
'    <li>Home</li>',
'    <li>About us</li>',
'</ul>',
'}',
'@section footer {',
'<footer>',
'    Copyright Telerik Academy 2014',
'</footer>',
'}',
'<!DOCTYPE html>',
'<html>',
'<head>',
'    <title>Telerik Academy</title>',
'</head>',
'<body>',
'    @renderSection("menu")',
'',
'    <h1>@title</h1>',
'    @if (showSubtitle) {',
'        <h2>@subTitle</h2>',
'        <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
'    }',
'',
'    <ul>',
'        @foreach (var student in students) {',
'            <li>',
'                @student ',
'            </li>',
'            <li>Multiline @title</li>',
'        }',
'    </ul>',
'    @if (showMarks) {',
'        <div>',
'            @marks ',
'        </div>',
'    }',
'',
'    @renderSection("footer")',
'</body>',
'</html>'
]);