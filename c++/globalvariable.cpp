#include <ext_global_variable.cpp>
int x = 1337;

int main()
{
    modify_variable_external();
    cout << x;
}