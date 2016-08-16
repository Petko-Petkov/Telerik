function solve() {
    
  return function (selector, isCaseSensitive) {
    var el = $(selector),
      label = createElement('label', {for: 'add_value'}),
      inputWrapper = createElement('DIV', {classList: 'add_controls'}),
      addButton = createElement('input', {type: 'button', value: 'Add', id: 'add_button', classList: 'button', onclick: 'addElement', display: 'block'}),
      searchLabel = createElement('label', {for: 'search_input'}),
      searchInput = createElement('input', {type: 'text', id: 'search_input'}),
      searchWrapper = createElement('div', {classList: 'search_controls'}),
      resultsWrapper = createElement('div', {classList: 'result-controls', id: 'results'}),
      itemsList = createElement('ul', {classList: 'items-list'});


      addButton.onclick  = addElement;
      setValue(label, 'Enter text');
      inputWrapper.appendChild(label);
      inputWrapper.appendChild(createElement('input', {type: 'text', id: 'add_value'}));
      inputWrapper.appendChild(addButton);
      el.append(inputWrapper);

      searchInput.onkeyup = searchElement;

      setValue(searchLabel, 'Search:');
      searchWrapper.appendChild(searchLabel);
      searchWrapper.appendChild(searchInput);
      resultsWrapper.appendChild(itemsList);
      el.append(searchWrapper);
      el.append(resultsWrapper);
      el.addClass('items-control');


  };

  function addElement(){
  var val = document.getElementById('add_value').value,
    el = document.getElementById('results'),      
    deleteButton = createElement('button', { id: val}),
    listDiv = createElement('li', {classList: 'list-item'}),
    listItem = createElement('span', {classList: 'add-controls', id: 'data-li-' + val}),
    itemsList = document.getElementsByClassName('items-list')[0];
    deleteButton.innerHTML = 'X';
    deleteButton.onclick = deleteItem;

    setValue(listItem, val);
    listDiv.appendChild(deleteButton);
    listDiv.appendChild(listItem);
    itemsList.appendChild(listDiv);
    document.getElementById('add_value').value = '';
    el.appendChild(itemsList);
}

function searchElement() {
  var el = document.getElementsByClassName('items-list')[0],
    value = document.getElementById('search_input').value;

  if (el && el.childNodes) {
    var elements = el.childNodes;
    for (var key in elements) {
      if (elements.hasOwnProperty(key)) {
        var element = elements[key];
        if (element.innerHTML.indexOf(value) < 1 && value != '') {
          element.style.display = 'none'; 
        } else {
          element.style.display = 'block';
        }
      }
    }
  }
}

function deleteItem() {
  var el = document.getElementById('data-li-' +this.id);
  el.parentNode.removeChild(el);
  this.parentNode.removeChild(this);
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

function setValue(el, val) {
    var action = el.tagName === 'INPUT' ? 'value' : 'innerHTML';
    return el[action] = val; 
}

function getValue(el) {
    var action = el.tagName === 'INPUT' ? 'value' : 'innerHTML';
    return el[action];
}
}



// createElement('DIV', {id: 'wrapper', class: 'wrapper'}, {color: 'red', display: 'inline-block'}, el)

module.exports = solve;