#include "GCD.h"

#pragma once
int GCD::gcd_recursive(int u, int v) {
	return (v != 0) ? gcd_recursive(v, u % v) : u;
}
