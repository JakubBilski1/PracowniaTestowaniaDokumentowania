const test = require('node:test');
const assert = require('assert');

// funkcja potegowania 2 do potegi 10
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

  test.describe("testing gcd", (t) => {
    test.beforeEach(()=>{console.log("about run test")})
    test.after(()=>{console.log("All test finished")})
    test.it("should work",(t)=>{
        let a = 120
        let b = 21
        let expectedResult = 0
        let result = gcd(a,b)
        assert.notEqual(result, expectedResult)
    })
    test.it("should work",(t)=>{
        let a = 2
        let b = 10
        let expectedResult = 1024
        let result = gcd(a,b)
        assert.notEqual(result, expectedResult)
    })
    test.it("should work",(t)=>{
        let a = 120
        let b = 21
        let expectedResult = 0
        let result = gcd(a,b)
        assert.notEqual(result, expectedResult)
    })

  })