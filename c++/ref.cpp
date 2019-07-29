#include<iostream> 
using namespace std; 

// Example 2: Modify the passed parameters in a function
void swap (int& first, int& second) 
{ 
	int temp = first; 
	first = second; 
	second = temp; 
}

// Example 3: Avoiding copy of large structures
struct Student { 
	string name; 
	string address; 
	int rollNo; 
}; 

void print_student(const Student &s) 
{ 
	cout << s.name << " " << s.address << " " << s.rollNo; 
}

void print_example(int num_example)
{
	// need int
	// need int variable, int&
	string body_string = "Example ";
	if (num_example > 1)
	{
		cout << "\n" << body_string << num_example << ":\n";
	}
	else
	{
		cout << body_string << num_example << ":\n";
	}
}

int main() 
{ 
	// Example 1
	print_example(1);
	int x = 10; 

	// ref is a reference to x. 
	int& ref_to_x = x; 

	// Value of x is now changed to 20 
	ref_to_x = 20; 
	cout << "x = " << x << endl ; 

	// Value of x is now changed to 30 
	x = 30; 
	cout << "ref = " << ref_to_x << endl ;
	cout << "x = " << x << endl ;


	// Example 2
	print_example(2);
	int a = 2, b = 3; 
	swap( a, b ); 
	cout << a << " " << b << endl; 

	// Example 3
	print_example(3);

	// End
	return 0; 
}