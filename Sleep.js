//// JavaScript source code

//Given a positive integer millis, write an asynchronous function that sleeps for millis milliseconds.It can resolve any value.


function sleep(millis) {
    return new Promise((resolve) => {
        setTimeout(resolve, millis);
    });
}

// Usage
async function myAsyncFunction() {
    console.log("Before sleep");
    await sleep(3000); // Sleep for 3000 milliseconds (3 seconds)
    console.log("After sleep");
}

myAsyncFunction();