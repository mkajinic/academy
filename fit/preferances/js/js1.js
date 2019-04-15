console.log("js1.js is loaded");

//Global variable to hold preferances object
var preferances;

// if preferances is undefined then create it
if(preferances === undefined){
    preferances = new Object();
    console.log("'preferances' has been created");
}
console.log("'preferances' is  a type of " + typeof preferances);

function setParaColor(){
    //get all the p tags
    var ptags = document.getElementsByTagName("p");

    var paracolor = document.getElementById("paracolor").value; //paracolor is from input

    //create a property in the preferances object for paragraph color and save the selected color to it
    preferances.paracolor = paracolor;

    

    //testing what is now in preferences object
    console.log(preferances);

    for (let index = 0; index < ptags.length; index++) {
        ptags[index].style.color = paracolor;   
    }
    //save to local storage
    savePreferances();
}

function setBgColor(){
    //get all the body tags
    var bodytags = document.getElementsByTagName("body");

    var bodycolor = document.getElementById("bgcolor").value; //bgcolor is from input

    //create a property in the preferances object for paragraph color and save the selected color to it
    preferances.bodycolor = bodycolor;

    //testing what is now in preferences object
    console.log(preferances);

   bodytags[0].style.backgroundColor = bodycolor;
    //save to local storage
    savePreferances();
}

function setFontSize(){
    
}

function savePreferances(){
    //JSON encode our preferances objects
    var settings = JSON.stringify(preferances);

    //save the JSON encoded setting string to local storage with the key of "usersettings"
    localStorage.setItem("usersettings", settings);
}