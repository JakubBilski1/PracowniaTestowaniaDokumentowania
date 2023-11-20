const test = require('node:test');
const assert = require('assert');

const bubbleSort = (array) => {
    const newArray = [...array]; // Tworzymy kopię tablicy wejściowej
    for (let i = 0; i < newArray.length; i++) {
        for (let j = 0; j < newArray.length - i - 1; j++) {
            if (newArray[j] > newArray[j + 1]) {
                let temp = newArray[j];
                newArray[j] = newArray[j + 1];
                newArray[j + 1] = temp;
            }
        }
    }
    return newArray; // Zwracamy nową, posortowaną tablicę
};

const numbers = [5, 2, 3, 1, 6];

console.log(`Sorted: ${numbers}`);

test.describe('testing bubble sort', (t) => {
    test.it('should work', (t) => {
        let result = bubbleSort(numbers);
        let expectedResult = [1, 2, 3, 5, 6];
        assert.deepEqual(result, expectedResult);
    });
});
