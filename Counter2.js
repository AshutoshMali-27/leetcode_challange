//Write a function createCounter. It should accept an initial integer init.It should return an object with three functions.

//The three functions are:

//increment() increases the current value by 1 and then returns it.
//    decrement() reduces the current value by 1 and then returns it.
//    reset() sets the current value to init and then returns it.





function createCounter(init) {
    let currentValue = init;

    return {
        increment: function () {
            currentValue++;
            return currentValue;
        },
        decrement: function () {
            currentValue--;
            return currentValue;
        },
        reset: function () {
            currentValue = init;
            return currentValue;
        }
    };
}

// Example usage:
const counter = createCounter(5);
console.log(counter.increment()); // Output: 6
console.log(counter.increment()); // Output: 7
console.log(counter.decrement()); // Output: 6
console.log(counter.reset());    // Output: 5
