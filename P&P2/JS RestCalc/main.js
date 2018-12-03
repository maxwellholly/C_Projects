document.body.innerHTML = "<center><h3>Hello, thank you for dining with us! <br>Welcome to our check calculator! <br><br></h3></center>";

document.body.innerHTML += "<center><h4>Let's calculate each check (with desired tip) and the total for your party...</h4></center>";



function CalculateCheck(){
    var y = prompt("How many guests were in your party?").valueOf();

    //validate
    while (!parseFloat(y)){

        y = prompt("You have entered an invalid input...how many guests were in your party?").valueOf();
    }
    var i = 1;
    var check;
    var tip = 0;
    var tipPercent;
    var tipRunning = 0;
    var totalCurrent = 0;
    var totalRunning = 0;

    document.writeln("Here's your party's check totals:<br><br>");
    while (i<=y){

       check = prompt("What is guest " + i +"'s check total before tip? (do not enter special characters)").valueOf();

       //validate
       while (!parseFloat(check)){

           check = prompt("Invalid input...what is guest " + i +"'s check total before tip? (do not enter special characters)").valueOf()
       }

       tipPercent = prompt("What is guest " + i +"'s desired tip percentage? (do not enter special characters)").valueOf();

       //validate
       while (!parseFloat(tipPercent)){

           tipPercent = prompt("Invalid input...what is guest " + i +"'s desired tip percentage? (do not enter special characters)").valueOf();

       }

       totalCurrent = parseFloat(check) + ((tipPercent/100)*check);

       tip = ((tipPercent/100)*check);

       document.writeln("Guest " + i + " check total: $" + totalCurrent + "<br>");

       totalRunning += totalCurrent;

       tipRunning += tip;

       i++;


    }

    document.writeln("Total tip for your waiter: $" + tipRunning + "<br>");
    document.writeln("Grand total: $" + totalRunning + "<br>");
    document.writeln("Split " + y + " ways: $" + totalRunning/y + "<br>");

}


