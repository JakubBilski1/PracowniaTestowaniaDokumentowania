const test = require('node:test');
const assert = require('assert');

  function potegowanie(a,b) { 
    let pot_result= 1;
    for (let i=1;i<=b; i++){
        pot_result = pot_result * a;
    }
    return pot_result;
  }

  test('testing Pow',(t)=>{
    let a = 2;
    let b = 0;
    let expectedResult = 1;
    let result= potegowanie(a,b);
    assert.strictEqual(result, expectedResult);

  });