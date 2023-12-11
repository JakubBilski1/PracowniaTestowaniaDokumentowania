#include "Algorithms.h"

int Algorithms::factorial(int n) {
    if (n == 0) {
        return 1;
    }
    else {
        return n * factorial(n - 1);
    }
}

int Algorithms::arraySum(int arr[], int n) {
    if (n == 0) {
        return 0;
    }
    else {
        return arr[n - 1] + arraySum(arr, n - 1);
    }
}

long long Algorithms::fastPow(long long base, long long exp) {
    if (exp == 0)
        return 1;
    else if (exp == 1)
        return base;
    else {
        long long temp = fastPow(base, exp / 2);
        if (exp % 2 == 0)
            return temp * temp;
        else
            return base * temp * temp;
    }
}

int Algorithms::gcd_recursive(int u, int v) {
    return (v != 0) ? gcd_recursive(v, u % v) : u;
}
