import pytest
import math

class Circle():
    def __init__(self, radius):
        self.radius = radius
    
    def area(self):
        return math.pi * self.radius ** 2
    
    def perimeter(self):
        return 2 * math.pi * self.radius

def add(x, y):
    return x + y

def divide(x, y):
    if(y == 0):
        raise ValueError
    return x / y

def test_add():
    result = add(3, 8)
    assert result == 11
    
def test_divide():
    result = divide(10, 2)
    assert result == 5
    
def test_divide_zero():
    with pytest.raises(ValueError):
        result = divide(5, 0)

#@pytest.mark.skip(reason="Pomijamy")
@pytest.mark.parametrize("a, b, expectedResult", [[2, 3, 5], [3, 7, 10], [9, 11, 20]])
def test_ultimate(a, b, expectedResult):
    result = add(a, b)
    assert result == expectedResult
    
@pytest.fixture
def circle():
    return Circle(10)

def test_area(circle):
    result = circle.area()
    assert result == math.pi * circle.radius ** 2
    
def test_perimeter(circle):
    result = circle.perimeter()
    assert result == 2 * math.pi * circle.radius