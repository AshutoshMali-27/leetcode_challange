//Write a function expect that helps developers test their code.It should take in any value val and return an object with the following two functions.

//    toBe(val) accepts another value and returns true if the two values === each other.If they are not equal, it should throw an error "Not Equal".
//        notToBe(val) accepts another value and returns true if the two values !== each other.If they are equal, it should throw an error "Equal".
// // JavaScript source code

function expect(value) {
    return {
        toBe: function (expected) {
            if (value !== expected) {
                throw new Error("Not Equal");
            }
            return true;
        },
        notToBe: function (notExpected) {
            if (value === notExpected) {
                throw new Error("Equal");
            }
            return true;
        },
    };
}

// Example usage:
const result = expect(5);

try {
    result.toBe(5); // This will throw "Not Equal" error
} catch (error) {
    console.error(error.message);
}

try {
    result.notToBe(6); // This will throw "Equal" error
} catch (error) {
    console.error(error.message);
}