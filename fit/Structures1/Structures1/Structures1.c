#include <stdio.h>
#include <string.h>
#include <stdlib.h>


//Structure! NOT a class or object
struct Book {
	char title[50];
	char author[50];
	char subject[100];
	int book_id;
};

//function declarations
void printBookInfo(struct Book book);
void printArrayOfBooks(struct Book books[]);

int main() {

	struct Book book1;
	struct Book book2;

	//We cant do this, we have to use string copy strcpy (we want to copy string into the
	//book1.author = "Jim";

	//An array of 10 book structures
	struct Book books[3];

	

	//book1.author = "Jussi Adler";

	//strcpy_s(the char[] we to copy the char's to the lenght of tha same char array
	//the actual chars/string we want to copy to the array)
	strcpy_s(book1.author, _countof(book1.author), "Jussi Adler Olsen");
	strcpy_s(book1.title, _countof(book1.title), "Message in a bottle");
	strcpy_s(book1.subject, _countof(book1.subject), "Crime");
	book1.book_id = 10;


	printf("The Author of Book 1 is: %s \n", book1.author);
	printf("The Title of Book 1 is: %s \n", book1.title);
	printf("The Subject of Book 1 is: %s \n", book1.subject);
	printf("The ID of Book 1 is: %d \n", book1.book_id);

	//book2 is a copy of book1. We now have two structures in memory
	book2 = book1;

	

	//Check the subject of book2 now...
	printf("The Author of Book 2 is: %s \n", book2.author);
	

	//Change the author of book2
	strcpy_s(book2.author, _countof(book2.author), "Micky Jones");

	//Put 3 books in the array
	struct Book book3 = { "Positive mindset", "Joanna Jones", "Positivity", 41 };

	books[0] = book1;
	books[1] = book2;
	books[2] = book3;

	//Print the title of the first book in the array 
	printf("The first books title is: ", books[0].title);

	//Now check the authors of book1 and book2
	printf("\n");
	printf("The Author of Book 1 is: %s \n", book1.author);
	printf("The Author of Book 2 is: %s \n", book2.author);
	
	

	//Call the printBookInfo  function
	printBookInfo(book1);
	printBookInfo(book2);

	printArrayOfBooks(books);

	

	



}


void printBookInfo(struct Book book) {

	//print data for the book
	printf("*****************************************************\n");
	printf("The Author of Book  is: %s \n", book.author);
	printf("The Title of Book is: %s \n", book.title);
	printf("The Subject of Book  is: %s \n", book.subject);
	printf("The ID of Book is: %d \n", book.book_id);
	printf("\n");
}


//A method to print all the information for an array of books
void printArrayOfBooks(struct Book books[]) {
	for (size_t i = 0; i < sizeof(books); i++) 
	{
		printBookInfo(books[i]);
	}
	
}