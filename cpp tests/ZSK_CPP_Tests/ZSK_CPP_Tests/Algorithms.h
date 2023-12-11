#pragma once
class Algorithms
{
public:
	//Factorial - silnia - n!
	//https://pl.wikipedia.org/wiki/Silnia
	static int factorial(int n);

	//Sum of array elements - suma elementów w tablicy
	static int arraySum(int arr[], int n);

	//Fast Power - szybkie potengowanie
	//https://pl.wikipedia.org/wiki/Algorytm_szybkiego_pot%C4%99gowania
	static long long fastPow(long long base, long long exp);

	//Greatest Common Divisor
	//https://pl.wikipedia.org/wiki/Najwi%C4%99kszy_wsp%C3%B3lny_dzielnik
	static int gcd_recursive(int u, int v);
};

