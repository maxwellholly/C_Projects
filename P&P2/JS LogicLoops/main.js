document.body.innerHTML = "<center><h3>Hello, please make a selection from below.<h3>";

function MakingTheGrade(){

    document.writeln("Hi, welcome to Making The Grade!<br>");
    var testOne = prompt("Please input your first test grade and hit enter").valueOf();

    while (!parseFloat(testOne) || testOne > 100 || testOne < 0){

        testOne = prompt("Invalid input...please input your first test grade and hit enter").valueOf();
    }

    var testTwo = prompt("Please input your second test grade and hit enter").valueOf();

    while (!parseFloat(testTwo) || testTwo > 100 || testTwo < 0){

        testTwo = prompt("Invalid input...please input your second test grade and hit enter").valueOf();
    }

    if (testOne >= 70 && testTwo >= 70){

        document.writeln("Congrats! both grades are passing!");

    } else {

        document.writeln("One or more grades are failing, try harder next time!");

    }

}

function BrunchBunch(){

    document.writeln("Hello, welcome to Brunch Bunch!<br>Let's see which brunch price you are eligible for...<br>");

    var age = prompt("What is your age?").valueOf();

    while (!parseInt(age) || age < 0){

        age = prompt("It looks like you entered an invalid input...what is your age?");

    }

    if (age >= 55 || age < 10){

        document.writeln("Your cost for brunch today is $10.00");

    }else {

        document.writeln("Your cost for brunch today is $15.00");
    }



}

function AddThemUp(){

    document.writeln("Hello, welcome to Add Them Up!<br>Let's see how many DVDs, Blu-Rays, and Digital UltraViolet copies you own!<br>");

    var dvds = prompt("How many DVDs do you own?").valueOf();

    while (!parseInt(dvds)){

        dvds = prompt("Invalid input...how many DVDs do you own?").valueOf();
    }

    var bluRays = prompt("How many Blu-Rays do you own?").valueOf();

    while (!parseInt(bluRays)){

        bluRays = prompt("Invalid input...how many Blu-Rays do you own?").valueOf();
    }

    var digitalUltraViolets = prompt("How many Digital UltraViolet copies do you own?").valueOf();

    while (!parseInt(digitalUltraViolets)){

        digitalUltraViolets = prompt("Invalid input...how many Digital UltraViolet copies do you own?").valueOf();
    }

    var totalMovies = parseInt(dvds)+parseInt(bluRays)+parseInt(digitalUltraViolets);

    if (totalMovies > 100){

        document.writeln("Wow, I am impressed with your collection of " + totalMovies + " movies!");

    } else {

        document.writeln("You have a total of " + totalMovies + " movies in your collection.");
    }


}

function ChaChing(){

    document.writeln("Hello, welcome to Cha-Ching!<br>");

    var giftCard = prompt("What is your giftcard amount?").valueOf();


    while (!parseFloat(giftCard)){

        giftCard = prompt("Invalid input...what is your giftcard amount?").valueOf();
    }

    var giftCardFloat = parseFloat(giftCard);

    var purchase;

    while (giftCardFloat > 0) {

        purchase = prompt("How much is your purchase?").valueOf();

        while (!parseFloat(purchase)){

            purchase = prompt("Invalid input...how much is your purchase?").valueOf();
        }

        var purchaseFloat = parseFloat(purchase);

        if (purchaseFloat < giftCardFloat){

            giftCardFloat -= purchaseFloat;

            document.writeln("With your purchase of $" + purchaseFloat + " your giftcard balance is $" + giftCardFloat) +".<br>";

        } else {


            document.writeln("With your purchase of $" + purchaseFloat + " you have used your giftcard up and still owe $" + (purchaseFloat - giftCardFloat) + ".<br>");

            giftCardFloat = 0;

        }
    }


}


