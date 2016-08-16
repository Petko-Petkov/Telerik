/* globals document, window, console */

function solve() {
    suggestions = [];

    return function(selector, initialSuggestions) {
        var addBtn = document.getElementsByClassName('btn-add')[0],
            wrapper = document.querySelector(selector), 
            suggList = document.getElementsByClassName('suggestions-list')[0],
            searchInput = document.getElementsByClassName('tb-pattern')[0];

        if (initialSuggestions) {
            for (var key in initialSuggestions) {
                if (initialSuggestions.hasOwnProperty(key)) {
                    var element = initialSuggestions[key];
                    var li = addSuggestion(element);
                    if(li) appendElement(li);   
                    
                    suggestions.push(element.toLowerCase());
                }
            }
        }

        searchInput.onkeyup = searchElement
        wrapper.appendChild(suggList);
        addBtn.onclick = addSuggestion;

        return wrapper;
    };

    function hideElement(value) { 
        var el = document.getElementsByClassName('suggestions-list')[0];
        var nodes = el.childNodes;

        for (var key in nodes) {
            if (nodes.hasOwnProperty(key)) {
                var element = nodes[key];
                var innerEl = element && element.childNodes && element.childNodes[0] ?  element.childNodes[0].innerHTML.toLowerCase() : '';
                if(value && innerEl && value.toLowerCase() === innerEl) {
                    element.style.display = 'block';
                }
                else if (element && element.style ) {
                    element.style.display = 'none';
                }
            }
        }
     }

    function searchElement() {
        var el = document.getElementsByClassName('suggestions-list')[0],
            value = document.getElementsByClassName('tb-pattern')[0].value.toLowerCase();

        if (el && el.childNodes) {
            var elements = el.childNodes;
            for (var key in elements) {
                if (elements.hasOwnProperty(key)) {
                    var elementLi = elements[key],
                        element = elementLi.childNodes[0];

                    if (element && element.innerHTML ) {
                        if (element.innerHTML.toLowerCase().indexOf(value) >= 0) {
                            elementLi.style.display = 'block';                                                    
                        } else {
                            elementLi.style.display = 'none';
                        }
                    } 
                }
            }
        }
    };

    function addSuggestion(input) 
    {
        var li = createElement('li', {classList: 'suggestion'}, {display: 'none'}),
            anchor = createElement('a', {href: '#', classList: 'suggestion-link'} ),
            value = document.getElementsByClassName('tb-pattern')[0].value;
            //suggList = document.getElementsByClassName('suggestions-list')[0];

        anchor.onclick = selectToInput;

        if (typeof(input) == 'string') {
            if(suggestions.indexOf(input.toLowerCase()) >= 0){
                return;
            }
            setValue(anchor, input);  
            li.appendChild(anchor);  
        } else {
            document.getElementsByClassName('tb-pattern')[0].value = '';
            if(suggestions.indexOf(value.toLowerCase()) >= 0){
                return;
            }
            suggestions.push(value.toLowerCase());
            setValue(anchor, value); 
            li.appendChild(anchor);
            appendElement(li);
            hideElement();
        }
        
        
        //suggList.appendChild(li);

        return li;
    }

    function appendElement(el) { 
        var suggList = document.getElementsByClassName('suggestions-list')[0];
        suggList.appendChild(el);
     }

    function selectToInput() {
        document.getElementsByClassName('tb-pattern')[0].value = this.innerHTML;
        hideElement(this.innerHTML);

    }

    function setValue(el, val) {
        var action = el.tagName === 'INPUT' ? 'value' : 'innerHTML';
        return el[action] = val; 
    }

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
}

module.exports = solve;