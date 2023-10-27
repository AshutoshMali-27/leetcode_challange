/*Given an integer n, return a counter function. This counter function initially returns n and then returns 
1 more than the previous value every subsequent time it is called(n, n + 1, n + 2, etc).*/


//Input:
//n = 10
//["call", "call", "call"]
//Output: [10, 11, 12]
//Explanation:
//counter() = 10
//counter() = 11
//counter() = 12



function createCounter(n) {
    let currentValue = n;

    function counter() {
        const value = currentValue;
        currentValue += 1;
        return value;
    }

    return counter;
}

// Example usage:
const n = 5;
const myCounter = createCounter(n);

for (let i = 0; i < 10; i++) {
    console.log(myCounter());
}