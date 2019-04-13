//string, numbers, boolean, null, undefined

const name="Magdalena";
const age = 28;

//Template string 
const hello = `My name is ${name} and I am ${age}`;
console.log(hello);

const s = 'technology, computers, it, code';
console.log(s.split(', '));


//Arrays
var person = {
    firstName: "Magdalena",
    lastName: "Kajinic",
    favFood: ["pizza", "strawberries", "bannana"],   
    toString: function (){
     return this.firstName + " " + this.lastName + " likes " + this.favFood;
    }
}
 console.log(person.toString());

//Arays of objects
const toDos = [
    {
        name: "John",
        id: 1,
        text: "Take out Trash",
        isCompleted: true
    },

    {
        name: "Mark",
        id:2,
        text: "Do dishes",
        isCompleted:true
    },
    {
        name: "Jordan",
        id: 3,
        text: "Meeting with boss",
        isCompleted: false
    },

];

/*for (let i = 0; i < toDos.length; i++) {
      console.log(toDos[i].text);
    
}*/

//or

for (let i of toDos ){
    console.log(i.text);
};

//high order Array 
// Foreach (loops trough arrays),
// Map (allows to create new array from array), 
// Filter(create new array base od condition)

//foreach (loops trough array)
toDos.forEach(function(todo) {
console.log(todo.id)
});

//map (returns an array)
const todoName = toDos.map(function(todo) {
return todo.name;
}); 
console.log(todoName);

//filter()
const todoCompleted = toDos.filter(function(todo) {
    return todo.isCompleted === true;
    }).map(function(todo){
        return todo.text;
    });
    console.log(todoCompleted);



