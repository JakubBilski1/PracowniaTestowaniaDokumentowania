#include "pch.h"
#include "CppUnitTest.h"
#include "../ZSK_CPP_Tests/Algorithms.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		TEST_METHOD(TestMethod1)
		{
			//Arrange
			int n = 5;
			int expected = 120;
			//Act
			int actual = Algorithms::factorial(n);
			//Assert
			Assert::AreEqual(expected, actual);
		}
		TEST_METHOD(TestMethod2)
		{
			//Arrange
			int n = 5;
			int expected = 15;
			int arr[] = { 1,2,3,4,5 };
			//Act
			int actual = Algorithms::arraySum(arr, n);
			//Assert
			Assert::AreEqual(expected, actual);
		}
		TEST_METHOD(TestMethod3)
		{
			//Arrange
			long long base = 2;
			long long exp = 10;
			long long expected = 1024;
			//Act
			long long actual = Algorithms::fastPow(base, exp);
			//Assert
			Assert::AreEqual(expected, actual);
		}
		TEST_METHOD(TestMethod4)
		{
			//Arrange
			int u = 12;
			int v = 18;
			int expected = 6;
			//Act
			int actual = Algorithms::gcd_recursive(u, v);
			//Assert
			Assert::AreEqual(expected, actual);
		}	
	};
}
