#include <stdio.h>
#include <stdlib.h>

int main() {

	//variable to hold a char
	char char1;
	char1 = 'a';


	//Make a variable to hold a string of up to 100 characters
	//and initialise it to the string "Hello"
	char sentance [100];

	//Copy the string into a char array
	strcpy(sentance, "Hello from the other side");

	char1 = 'a';
	

	printf("The char in char1 is: * %c *", char1);
	printf("\nThe sentance in sentance is: %s \n", sentance);


	/*
	Read some input from the console and assign values to the char2 
	and sentence variables
	*/
	printf("\n\n\n");

	printf("Please enter a single character: ");

	//Read the character and assign it to char1
	scanf_s("%c", &char1);

	printf("You have entered * %c * \n", char1);


	printf("Please write a sentance up to 100 characters: ");

	//Read the character as a character '%c' and assign it memory address of the variable char1
	//_countof(sentance) gets the lenght of the char array 'sentance' 
	

	//flushes the standard input 
	//clears the input buffer
	while ((getchar()) != '\n');
	
	fgets(sentance, _countof(sentance), stdin);
	printf("You have entered * %s  \n* ", sentance);



}