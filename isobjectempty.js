// JavaScript source code



//Given an object or an array, return if it is empty.

//An empty object contains no key-value pairs.
//An empty array contains no elements.
//You may assume the object or array is the output of JSON.parse.




using System;

function isEmpty(obj) {
    if (Array.isArray(obj)) {
        return obj.length === 0;
    }
    else if (typeof obj === 'object' && obj !== null) {
        return Object.keys(obj).length === 0;
    }
    else {
        return true; // Not an object or array, so consider it empty
    }
}

// Example usage:
const emptyObject = {};
const nonEmptyObject = { key: 'value' };
const emptyArray = [];
const nonEmptyArray = [1, 2, 3];

console.log(isEmpty(emptyObject)); // true
console.log(isEmpty(nonEmptyObject)); // false
console.log(isEmpty(emptyArray)); // true
console.log(isEmpty(nonEmptyArray)); // false
