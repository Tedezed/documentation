#include <bits/stdc++.h> 
using namespace std;
class Person
{ 
	// Access specifier 
	public: 
	
	// Data 
	string name;
	int age;

	// Member Functions() 
	void printall() 
	{ 
	cout << "name: " << name << "\n";
	cout << "age: " << age << "\n"; 
	} 
}; 

int main() { 

	// Declare an object of class geeks 
	Person obj1; 

	// accessing data member 
	obj1.name = "Pepe";
	obj1.age = 20; 

	// accessing member function 
	obj1.printall(); 
	return 0; 
} 

