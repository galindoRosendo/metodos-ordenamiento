const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Select a sort method:\n1. Quick Sort \n2. Radix\n', function (method) {
    
    switch (method) {
        case "1":    
            console.log('Quick Sort Selected');
            console.log('========== Unsorted Array ==========');
            console.log(unsortedArray.join(","));
            console.log('========== Sorted Array ==========');
            console.log(quickSort(unsortedArray).join(","));
            break;
        case "2":
            console.log('Radix Selected');
            console.log('========== Unsorted Array ==========');
            console.log(unsortedArray.join(","));
            console.log('========== Sorted Array ==========');
            console.log(unsortedArray.join(","));
            console.log(radixSort(unsortedArray.slice()).join(","));
            break;
        default:
            console.log('Not valid method');
            break;
    }
    rl.close();
});

rl.on('close', function () {
  console.log('\nSee you !!!');
  process.exit(0);
});

//#region Variables
const unsortedArray = randomListNumber(1000);
//#endregion

//#region Public Methods
function quickSort(array) {
    
    if (array.length < 1) {
        return [];
    }

    var left = [];
    var right = [];
    var pivot = array[0];

    for (let i = 1; i < array.length; i++) {
        if (array[i] < pivot) {
            left.push(array[i]);
        }
        else {
            right.push(array[i]);
        }
    }

    return [].concat(quickSort(left), pivot, quickSort(right));
}
function radixSort(inputArray){

    if(inputArray.length < 2) return inputArray;

    let maxValue = inputArray[0];

    for(let i=1;i<inputArray.length;i++){
        if(inputArray[i] > maxValue){
            maxValue = inputArray[i];
        }
    }

    const iterationCount = maxValue.toString().length;

    for(let digit=0; digit<iterationCount; digit++){
        const bucketArray = Array.from({length:10}, ()=> []);

        for(let i=0; i<inputArray.length; i++){
            const digitValue = Math.floor(inputArray[i] / Math.pow(10,digit)) % 10;
            bucketArray[digitValue].push(inputArray[i]);
        }

        inputArray = [].concat(...bucketArray);
    }
    return inputArray;
}
//#endregion

//#region Private Methods
function randomListNumber(size) {
    var result = [];

    while (result.length < size) {
        var randomNumber = Math.floor(Math.random() * size);

        if (!result.includes(randomNumber)) {
            result.push(randomNumber);
        }
    }
    
    return result;
}
//#endregion