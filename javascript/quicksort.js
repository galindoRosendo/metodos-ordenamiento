const unsortedArray = [4, 9, 2, 1, 6, 3, 8, 5, 7, 15, 12, 20, 11];

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

console.log(quickSort(unsortedArray));