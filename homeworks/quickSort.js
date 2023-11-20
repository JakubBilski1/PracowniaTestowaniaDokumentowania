const test = require('node:test')
const assert = require('assert')

const quickSort = (array) =>{
    if(array.length<=1){
        return array
    }
    const pivot = array[0]
    const left = []
    const right = []

    for(let i=1; i<array.length; i++){
        if(array[i]<pivot){
            left.push(array[i])
        }
        else{
            right.push(array[i])
        }
    }
    return quickSort(left).concat(pivot, quickSort(right))
}

test.describe('testing quick sort', (t)=>{
    test.beforeEach(()=>{console.log('starting tests')})
    test.after(()=>{console.log('all tests finished')})
    test.it('should work', (t)=>{
        const numbers = [5, 3, 6, 2, 7]
        const result = quickSort(numbers)
        const expectedResult = [2, 3, 5, 6, 7]
        assert.equal(result, expectedResult)
    })
})