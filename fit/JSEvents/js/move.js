//console.log("test");

//Globar variables (available everywhere)
var box;
var speed;
var moveAreaWidth, moveAreaHeight;

//The window.onload event fired(is raised) when the page is loaded
window.onload = function(){
    showSpeed();
    //set the box global variable to the box element in the DOM
    //so we dont have to write document.getElementById("box") all the time
    box = document.getElementById("box");

    //set the position  of the box in the DOM
    box.style.left = "10px";
    box.style.top = "10px";

    //Show the box position (calling the method)
    showBoxPosition();

    //Get the height and width of the moveArea
    moveAreaWidth = document.getElementById("moveArea").offsetWidth;
    moveAreaHeight = document.getElementById("moveArea").offsetHeight;

    console.log("Move area width: "+ moveAreaWidth);
    console.log("Move area height: "+ moveAreaHeight);



}//end of onload event


// Add an event listener for the 'keydown' event
document.addEventListener('keydown', function(e){

    //Show the keycode of which key was pressed
    console.log("Keycode: "+ e.which);

    if (e.which == 37) {
        //move left
        moveBoxLeft();
    }
    else if(e.which == 38){
        //move up
        moveBoxUp();
    }
    else if(e.which == 39){
        //move right
         moveBoxRight();
    }
    else if(e.which == 40){
        //move down
        moveBoxDown();
    }

    
})// end of eventListener

function moveBoxLeft(){
    //move the box left by the same number of pixels as the speed range set

   // var leftPosition = box.style.left; //string like "10px"

   // leftPosition = leftPosition.replace('px', ''); //replace the px part of the string with nothing

   // var leftNumber = parseInt(leftPosition); //number like 10

    leftNumber = parseInt(box.style.left) - parseInt(speed); //number like 15

    //if the new calculated leftNumber is 0 or less, move the box to the left 0px
    //Otherwise move it to the new left position
    if (leftNumber <= 0 ) {
        box.style.left = "0px";
    }
    else{
        box.style.left = "" + leftNumber + "px";
    }

    showBoxPosition();

}

function moveBoxRight(){
    //move the box left by the same number of pixels as the speed range set

    leftNumber = parseInt(box.style.left) + parseInt(speed); //number like 15

    //if the new calculated left position is greater than the widht of the move area less
    // the witdh of the box, then we want to keep the box inside the moveArea
    //Otherwise we move the box to the new postion
    if ( leftNumber >= (moveAreaWidth-box.offsetWidth)) {
        box.style.left = "" + (moveAreaWidth - box.offsetWidth) + "px";
    }
    else{
        box.style.left = "" + leftNumber + "px";
    }
    

    showBoxPosition();

}

function moveBoxUp(){
    //move the box left by the same number of pixels as the speed range set

   // var topPosition = box.style.top; //string like "10px"

   // leftPosition = leftPosition.replace('px', ''); //replace the px part of the string with nothing

   // var leftNumber = parseInt(leftPosition); //number like 10

    topNumber = parseInt(box.style.top) - parseInt(speed); //number like 15

    box.style.top = "" + topNumber + "px"
    showBoxPosition();

}

function moveBoxDown(){
    //move the box left by the same number of pixels as the speed range set

   // var topPosition = box.style.top; //string like "10px"

   // leftPosition = leftPosition.replace('px', ''); //replace the px part of the string with nothing

   // var leftNumber = parseInt(leftPosition); //number like 10

    topNumber = parseInt(box.style.top) + parseInt(speed); //number like 15

    box.style.top = "" + topNumber + "px"
    showBoxPosition();

}



//Show box left and righ position
function showBoxPosition(){     console.log("Box left: " + box.style.left + " top: " + box.style.top);
    }
    


//Set the text of the showSpeed text box to the value of the 'speed' range
function showSpeed(){
    //set the Global speed available
    speed = document.getElementById("speed").value 
    document.getElementById("showSpeed").value = speed;
    console.log("Speed is: " + speed);
}