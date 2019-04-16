console.log("its connected");

// global variable to hold the preferences object
var preferences ;
// If preferences in undefined then create it.
if(preferences === undefined){
    preferences = new Object();
    console.log("'preferences' has been created");
}

console.log("'preferences' is a type of: " + typeof preferences);

function setParaColor(){
    // get all the p tags
    var ptags =  document.getElementsByTagName("p");

    var paracolor = document.getElementById("paracolor").value;

    // Create a property in the preferences object for paragraph
    // color and save the selected color to it.
    preferences.paracolor = paracolor;

    // Testing to see whats now in the preferences object
    console.log(preferences);

    for (let index = 0; index < ptags.length; index++) {
        
        ptags[index].style.color = paracolor;        
    }

    changesMade = true;

    // Just for testing purposes
    showLocalStorage();
}

function setBgColor(){
    // get all the body tag
    var bodytags =  document.getElementsByTagName("body");

    var bodycolor = document.getElementById("bgcolor").value;

    // Create a property in the preferences object for body
    // color and save the selected color to it.
    preferences.bodycolor = bodycolor;

    // Testing to see whats now in the preferences object
    console.log(preferences);

    bodytags[0].style.background = bodycolor;

    changesMade = true;

    // Just for testing purposes
    showLocalStorage();
}

function setFontSize(){
    // get the font from the combo box
    var parafontsize = document.getElementById("parafontsize").value;

    // collection of p tags
    var ptags = document.getElementsByTagName("p");
    
    for (let index = 0; index < ptags.length; index++) {
        ptags[index].style.fontSize = parafontsize + "px";        
    }
    preferences.parafontsize = parafontsize;

    changesMade = true;
    showLocalStorage();
}

function savePreferences(){

    // JSON encode our preferences object
    var settings = JSON.stringify(preferences);

    // save the JSON encoded settings string to locla storage
    // with the key of "usersettings"
    localStorage.setItem("usersettings",settings);

    //for testing
    showLocalStorage();

    //feedback 
    alert("preferances have been saved");

    changesSaved == true;
    resetUnsavedChangesWarning();

}

function showLocalStorage(){
    // Dump the local storage to the console
    console.log(localStorage);
}

function reset(){

    //Clear local storage
    localStorage.clear();

   //reset the elements styling we have changed with javascript
   //(to empty strings  and they magicaly go back to default)
   document.body.style.backgroundColor = "";
   var ptags = document.getElementsByTagName("p");
   for (let index = 0; index < ptags.length; index++) {
       ptags[index].style.color = "";
       ptags[index].style.fontSize = "";
       
   }
}



function resetUnsavedChangesWarning(){
    document.getElementById("message").innerHTML ="";
}

//wndow.onload (even) will be raised each time a page loads (the same as the body onload event)
window.onload = function(){
    //Show the href(page location) of this page (just for testing)
    console.log("Page location is " + window.location.href);

    //if local storage is undefined it is not available
    if(typeof(Storage) === undefined){
    console.log("Local storage is unavailable");
    }
    else{
        console.log("Local storage is available");

        //if the key "usersettings" does not  exist in local storage
        //(It will be null)
        if(localStorage.getItem("usersettings") == null){
            console.log("No user settings saved");
        }
        //If its not null then it exists
        else{
            console.log("User settings available");
            
            //Retrieve the JSON encoded string for the key "usersettings" and parse/convert it to an object
             var usersettings = localStorage.getItem("usersettings");

             var settings = JSON.parse(usersettings);

             console.log("Setting is a: " + typeof settings);
             console.log(localStorage);

             // have a look at the settings object
             console.log("settings object: ", settings);

             //If we have a paragraph color then set that as a paragraph color
                 //check and see if the object has a propety called 'paracolor'
                 // the string 'undefined' would be returned if it doesnt exist in the object

                 var ptags = document.getElementsByTagName ("p");//get all "p" tags
            if (settings.paracolor !== 'undefined') {
               

                for (let index = 0; index < ptags.length; index++) {
                    ptags[index].style.color = settings.paracolor;
                    
                }
            }
                //If we have a font size  then set that as a paragraph font size 
             if (settings.parafontsize !== 'undefined' ) {
                for (let index = 0; index < ptags.length; index++) {
                    ptags[index].style.fontSize = settings.parafontsize + "px";
                    
                }
            }
            //If we have a background color then set that as a background color
            if (settings.bodycolor !== 'undefined' ) {
                document.body.style.backgroundColor = settings.bodycolor;
            }
        }
    }
}
function mouseOver() {
    document.getElementById("demo").style.fontSize = "400%";
  }

  function mouseOut() {
    document.getElementById("demo").style.fontSize = "130%";
  }

 

                    

