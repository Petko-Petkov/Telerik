function createElement (type, attrs, styles, html) {
    var i, 
        el = document.createElement(type);

    if (attrs) {
        for (i in attrs) {
            if (attrs.hasOwnProperty(i)) {
                el[i] = attrs[i];
            }
        }
    }

    if (styles) {
        for (s in styles) {
            if (styles.hasOwnProperty(s)) {
                el.style[s] = styles[s];
            }
        }
    }

    

    return el;
}

function setValue(el, val) {
    var action = el.tagName === 'INPUT' ? 'value' : 'innerHTML';
    return el[action] = val; 
}

function getValue(el) {
    var action = el.tagName === 'INPUT' ? 'value' : 'innerHTML';
    return el[action];
}

createElement('DIV', {id: 'wrapper', class: 'wrapper'}, {color: 'red', display: 'inline-block'}, el)