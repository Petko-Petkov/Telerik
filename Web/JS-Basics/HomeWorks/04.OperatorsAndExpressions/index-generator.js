var HtmlBuilder = (function (){
	var html = createElement;
	
	function (tagName, attrs, arr) {
		if (!arr && !(this instanceof Array)) {
			throw 'No array provided';
		}
		
		var array = arr || this,
			attrs = attrs || null,
			__html = [],
			len = array.length,
			i,
			tagName = tagName || 'span';
			
		for (i = 0; i < len; i += 1) {
			if (typeof array[i] == 'object') {
				__html.push(buildFromObject(array[i]));
			} else {
				__html.push(html(tagName, attrs, array[i]));
			}
		}
		
		return __html;
	}
	
	function buildFromObject(obj) {
		if (!obj && !(this instanceof Object)) {
			throw 'No object provided';
		}
		
		return html(obj.tagName, obj.attrs, obj.content);
	}
	
	function init() {
		return {
			element : html,
			buildFromArray : buildFromArray,
			buildFromObject : buildFromObject
		}
	}
	
	return init();
}());

function createElement(type, attr, html) {
	var i, element = document.createElement(type);
	
	if(attr) {
		for (i in attr) {
			if (attr.hasOwnProperty(i)) {
				element[i] = attr[i];
				
			}
		}
	}
	
	if (typeof html === 'object') {
		element.appendChildren(html);
	} else if(html) {
		setValue(element, html);
	}
} 

function appendChildren(children, parent) {
	if(!parent && !(this instanceof Element)) {
		throw 'No configuration'
	}
	
	var i, 
		len = children.length,
		parent = parent || this;
		
	for (i = 0; i <len; i+=1) {
		parent.appenChild(children[i]);		
	}
	
	return parent;
}

function setValue(element, value) {
	var action = element.tagName === 'INPUT' ? 'value' : 'innerHTML';
	return element[action] = value;
}

function getValue(element) {
	var action = element.tagName === 'INPUT' ? 'value' : 'innerHTML';
	return element[action];
}

function addEvent(element, type, handler, capture) {
	return element.addEventListener(type, handler, capture);
} 

function removeEvent(element, type, handler) {
	return element.removeEventListener(type, handler);
}

function removeChildren(parent) {
	if (!parent && !(this instanceof Element)) {
		throw 'No configuration';
	}
	
	var childElement,
		parent = parent || this;
		
	while ((childElement = parent.firstChild) !== null) {
		parent.removeChild(childElement);
	}
}