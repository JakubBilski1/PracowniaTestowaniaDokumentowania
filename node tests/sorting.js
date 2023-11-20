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
let counter = 0
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
        counter++
    }
    return newArray
}

const numbers = [5, 7, 2, 23, 12, 34, 5, 8]

const start = Date.now();
console.log(bogoSort(numbers))
console.log(`posortowano za ${counter} razem`)
const end = Date.now();
console.log(`Execution time: ${end - start} ms`);