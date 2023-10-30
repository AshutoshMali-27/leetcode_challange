//Given a function fn, return a new function that is identical to the original function except that it ensures fn is called at most once.

//The first time the returned function is called, it should return the same result as fn.
//Every subsequent time it is called, it should return undefined.


function once(fn) {
    let called = false;
    let result;

    return function (...args) {
        if (!called) {
            called = true;
            result = fn(...args);
            return result;
        } else {
            return undefined;
        }
    };
}

// Example usage:
function add(a, b) {
    return a + b;
}

const onceAdd = once(add);

console.log(onceAdd(2, 3)); // Output: 5
console.log(onceAdd(4, 5)); // Output: undefined
