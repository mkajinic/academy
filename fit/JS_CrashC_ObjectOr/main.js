//Constructor function
function Person (firstName, lastName, dob){
    this.firstName = firstName;
    this.lastName = lastName;
    this.dob = new Date(dob);
    this.getBirthYear = function(){
        return this.dob.getFullYear();
    }
    this.getFullName = function(){
        return `${this.firstName} has a last name ${this.lastName} is born on ${this.dob}`;
    }

}

//Instantiate the object
var person1 = new Person('John', 'Smith', '11-20-1990');
var person2 = new Person('Jordan', 'Smith', '1-3-1999');
const person3 = new Person('Mary', 'Smith', '12-9-1887');


console.log(person2.getBirthYear());
console.log(person2.getFullName());