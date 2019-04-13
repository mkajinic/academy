
// triple === checks the data type
const x = '10';
if( x === 10 ){
    console.log("x is 10"); 
}

const a = 23;
const b = 10;

if (a > 5 &&  b > 8) {
    console.log("Either a is bigger than 5 or b is bigger than 10");
}


//Turnery operator -kid of short if statement (to assign variables  based on condition )
       // (condition) ?(then) :(:else)
const color = a > 10 ? "red" : "blue";
                     //if treue  //if false

//to evaluate condition
switch(color){ 
    case "red": 
    console.log("color is red");
    break;
    case "blue" :
    console.log("color is blue");
    break;
    default:
    console.log("There is no color");
    break;
}



function addNums(num1=2, num2=4){
return num1 + num2;
}

console.log(addNums(9,5));

//Arrow function-doesent need {} nor return (we can put it but no need)
const addNums2 = (num1=2, num2=4) => num1 + num2;

console.log(addNums2(7,9));

//or if there is one value
const addNums3 = num1 => num1 + 5;

console.log(addNums3(5));


todos.forEach( (todo) => console.log(todo) );


