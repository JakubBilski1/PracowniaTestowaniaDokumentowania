const test = require('node:test');
const assert = require('assert');

function gcd(a,b) {
    a = Math.abs(a);
    b = Math.abs(b);
  
    if (b > a) {
      var temp = a;
      a = b;
      b = temp; 
    }
  
    while (true) {
      a %= b;
      if (a === 0) { return b; }
      b %= a;
      if (b === 0) { return a; }
    }
  }

  test('testing GCD',(t)=>{
    let a = 10;
    let b = 20;
    let expectedResult = 10;
    let result= gcd(a,b);
    assert.strictEqual(result, expectedResult);
  });