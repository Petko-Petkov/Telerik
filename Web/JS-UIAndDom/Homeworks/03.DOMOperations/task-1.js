
/* globals $ */

/* 
Create a function that takes an id or DOM element and an array of contents
* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {
    return function (id, contents) {
            try {
                var element,
                    index = 0,
                    len = contents.length,
                    content,
                    div,
                    df = new DocumentFragment();

                if (typeof id == 'string') {
                    element = document.getElementById(id);
                } else if (id instanceof HTMLElement) {
                    element = id;
                } else if (typeof contents != 'object'){
                    throw new Error;
                } else {
                    throw new Error;
                }   

                for (index; index < len; index += 1) {
                    content = contents[index];
                    if (typeof content != 'string' && typeof content != 'number') {
                        throw new Error;
                    }
                    div = document.createElement('DIV');
                    div.innerHTML = content;
                    df.appendChild(div);
                }         
                
                element.innerHTML = '';
                element.appendChild(df);

            } catch (error) {
                throw error;
            }
    };
};
function solve() {
    return function (id, contents) {
        try {
            var element,
                index = 0,
                len = contents.length,
                content,
                div;

            if (typeof id == 'string') {
                element = document.getElementById(id);
            } else if (id instanceof HTMLElement) {
                element = id;
            } else {
                throw new Error;
            }   

            element.innerHTML = '';

            for (index; index < len; index += 1) {
                content = contents[index];
                if (typeof content != 'string' && typeof content != 'number') {
                    throw new Error;
                }
                div = document.createElement('DIV');
                div.innerHTML = content;
                element.appendChild(div);
            }         
        } catch (error) {
            throw error;
        }
  };
}