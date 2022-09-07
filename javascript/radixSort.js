const unsortedArray = [4, 9, 2, 1, 6, 3, 8, 5, 7, 15, 12, 20, 11];

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

console.log(radixSort(unsortedArray.slice()));