// JavaScript source code
function createHelloWorld() {
    return function () {
        return "Hello World";
    };
}

// Usage:
const helloWorldFunction = createHelloWorld();
console.log(helloWorldFunction()); // Output: "Hello World"