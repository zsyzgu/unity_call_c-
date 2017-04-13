#include <iostream>
#include <Windows.h>

using namespace std;

const int POINT_NUMBER = 60;

int otherFunction() {
	return 0;
}

extern "C" __declspec(dllexport) int getInt() {
	return otherFunction();
}

extern "C" __declspec(dllexport) int* getIntArray() {
	static int array[POINT_NUMBER];
	for (int i = 0; i < POINT_NUMBER; i++) {
		array[i] = i;
	}
	return array;
}
