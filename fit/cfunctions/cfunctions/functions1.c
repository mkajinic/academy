#include <stdio.h>

//Declare the function names signatures
//And we can include the function body later
int max(int x, int y);
double bigger(double x, double y);

//or we can put methods before the main




//main method
int main() {

	printf("Test\n");

	//Declare a variable of type int
	int largest1 = max(74, 28);
	double largest2 = bigger(12.5, 56.7);


	//Tell the printf function to display the int as an int with the format specifier 
	//placeholder of %d
	printf("The largest in number is %d \n", largest1);
	printf("The largest double number is %g \n", largest2);

	return 0;
}

/*
function to calculate the largest two numbers
*/
int max(int x, int y) {
	if (x > y)
	{
		return x;
	}
	else
	{
		return y;
	}
}

/*
Write a function to find the largest of two doubles
*/
double bigger(double x, double y) {
	if (x > y)
	{
		return x;
	}
	else
	{
		return y;
	}
}
