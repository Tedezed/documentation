#include <iostream>
using namespace std;

extern int x;

void modify_variable_external() {
  x = x + 43;
}
