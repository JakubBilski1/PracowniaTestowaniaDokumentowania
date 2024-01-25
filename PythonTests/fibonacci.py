import unittest

def fibonacci(n):
    if n <= 1:
        return n
    else:
        return fibonacci(n-1) + fibonacci(n-2)

class FibonacciTest(unittest.TestCase):
    def test_fib(self):
        n = 3
        expected = 2
        self.assertEqual(fibonacci(n), expected)
    def test_fib2(self):
        n = 5
        expected = 5
        self.assertEqual(fibonacci(n), expected)
        
if __name__ == '__main__':
    unittest.main()