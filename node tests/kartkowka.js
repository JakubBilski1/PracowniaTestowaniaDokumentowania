const test = require('node:test')
const assert = require('assert')

findingBiggestNumber = (array) => {
    let biggest = array[0]
    for (let i = 0; i < array.length; i++) {
        if (biggest < array[i]) {
            biggest = array[i]
        }
    }
    return biggest
}

countEvenNumbers = (array) => {
    let counter = 0
    for (let i = 0; i < array.length; i++) {
        if (array[i] % 2 == 0) {
            counter++
        }
    }
    return counter
}

bogoSort = (array) => {
    let newArray = [...array]
    let sorted = false
    while (!sorted) {
        for (let i = 0; i < newArray.length; i++) {
            let randomIndex = Math.floor(Math.random() * newArray.length)
            let temp = newArray[i]
            newArray[i] = newArray[randomIndex]
            newArray[randomIndex] = temp
        }
        sorted = true
        for (let i = 0; i < newArray.length - 1; i++) {
            if (newArray[i] > newArray[i + 1]) {
                sorted = false
            }
        }
    }
    return newArray
}

miracleSort = (arr) => {
    let sorted = false
    while (!sorted) {
        sorted = true
        for (let i = 0; i < arr.length - 1; i++) {
            if (arr[i] > arr[i + 1]) {
                let temp = arr[i]
                arr[i] = arr[i + 1]
                arr[i + 1] = temp
                sorted = false
            }
        }
    }
    return arr
}

const numbers = [5, 7, 2, 23, 12, 34, 5, 8]

test.describe('testing findBiggestNumber', (t)=>{
    test.it('should work', (t)=>{
        let expectedResult = 34;
        let result = findingBiggestNumber(numbers)
        assert.deepEqual(result, expectedResult)
    })
    test.it('should work', (t)=>{
        let expectedResult = 4
        let result = countEvenNumbers(numbers)
        assert.deepEqual(result, expectedResult)
    })
    test.it('should sort', (t)=>{
        let expectedResult = [2, 5, 5, 7, 8, 12, 23, 34]
        let result = bogoSort(numbers)
        assert.deepStrictEqual(result, expectedResult)
    })
    test.it('should sort', (t)=>{
        let expectedResult = [2, 5, 5, 7, 8, 12, 23, 34]
        let result = miracleSort(numbers)
        assert.deepStrictEqual(result, expectedResult)
    })
})