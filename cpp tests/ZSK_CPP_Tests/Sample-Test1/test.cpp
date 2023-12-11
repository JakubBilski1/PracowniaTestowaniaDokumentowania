#include "pch.h"
#include "../ZSK_CPP_Tests/Algorithms.h"

TEST(TestCaseName, TestName) {
	//Arrange
	int n = 5;
	int expected = 120;
	//Act
	int actual = Algorithms::factorial(n);
	//Assert
	ASSERT_EQ(expected, actual);
}

TEST(TestCaseName, TestName2) {
	//Arrange
	int n = 5;
	int expected = 15;
	int arr[] = { 1,2,3,4,5 };
	//Act
	int actual = Algorithms::arraySum(arr, n);
	//Assert
	ASSERT_EQ(expected, actual);
}

TEST(TestCaseName, TestName3) {
	//Arrange
	long long base = 2;
	long long exp = 10;
	long long expected = 1024;
	//Act
	long long actual = Algorithms::fastPow(base, exp);
	//Assert
	ASSERT_EQ(expected, actual);
}

TEST(TestCaseName, TestName4) {
	//Arrange
	int u = 12;
	int v = 18;
	int expected = 6;
	//Act
	int actual = Algorithms::gcd_recursive(u, v);
	//Assert
	ASSERT_EQ(expected, actual);
}