document.body.innerHTML = "<center><h3>Hello, please make a selection from below.<h3>";

function BakingConverter(){

    document.writeln("Hello, welcome to Baking Converter!<br>Where we convert between grams and ounces for you!<br>");

    var weight = prompt("Please enter the weight you would like to convert");

    while (!parseFloat(weight)){

        weight = prompt("Invalid input...please enter the weight you would like to convert");
    }

    var weightFloat = parseFloat(weight);

    var units = prompt("Perfect! Is that in oz or g?");

    switch (units) {

        case "oz":
        case "OZ":
        case "OZ":
        case "ounces":
        {
            var gWeight = weightFloat * 28.34952;

            document.writeln("The weight is " + gWeight + " grams");

        }break;
        case "g":
        case "grams":
        case "G":
        {
            var ozWeight = weightFloat/28.34952;

            document.writeln("The weight is " + ozWeight + " ounces");

        }break;
        default: units = prompt("Invalid input...is that in oz or g?");
        break;


    }





}

function PizzaPerPerson(){

    document.writeln("Hello, welcome to Pizza Per Person!<br>Let's see if you have enough pizza.<br>");

    var pizzas = prompt("How many pizzas did you order?");

    while (!parseInt(pizzas)){

        pizzas = prompt("Invalid input...how many pizzas did you order?");

    }

    var pizzasInt = parseInt(pizzas);

    var slices = prompt("How many slices are there per pizza?");

    while (!parseInt(slices)){

        slices = prompt("Invalid input...how many slices per pizza?");

    }

    var slicesInt = parseInt(slices);

    var guests = prompt("Perfect! How many guests will be at the party?");

    while (!parseInt(guests)){

        guests = prompt("Invalid input...how many guests will be at the party?");

    }

    var guestsInt = parseInt(guests);

    var slicesPerGuest = prompt("Finally, how many slices will each guest eat?");

    while (!parseInt(slicesPerGuest)) {

        slicesPerGuest = prompt("Invalid input...how many slices will each guest eat?");
    }

    var slicesPerGuestInt = parseInt(slicesPerGuest);

    var totalSlices = pizzasInt * slicesInt;
    var slicesNeeded = slicesPerGuestInt * guestsInt;
    var leftOvers = totalSlices - slicesNeeded;
    var moreSlices = slicesNeeded - totalSlices;

    if (totalSlices >= slicesNeeded){

        document.writeln("Yes, you have enough pizza for your guests with " + leftOvers + " left over.");
    } else {

        document.writeln("You need at least " + moreSlices + " more slices of pizza. You should order more pizza.");
    }

}

function TaxBrackets(){

    document.writeln("Hello, welcome to Tax Brackets!<br>Let's find out which tax bracket you are in.<br>");

    var income = prompt("What is your yearly income?");

    while (!parseFloat(income)){

        income = prompt("Invalid input...what is your yearly income?");
    }

    var incomeFloat = parseFloat(income);

    if (incomeFloat <= 9000){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 1 and your tax rate is 10%.");

    }else if (incomeFloat < 37950 && incomeFloat > 9000){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 2 and your tax rate is 15%.");

    }else if (incomeFloat < 91900 && incomeFloat >= 37950){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 3 and your tax rate is 25%.");

    }else if (incomeFloat < 191650 && incomeFloat >=91900){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 4 and your tax rate is 25%.");

    }else if (incomeFloat < 416700 && incomeFloat >= 191650){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 5 and your tax rate is 33%.");

    }else if (incomeFloat < 418400 && incomeFloat >= 416700){

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 6 and your tax rate is 35%.");

    }else {

        document.writeln("You have an income of $" +incomeFloat+ " which puts you in tier 7 and your tax rate is 39%.");

    }




}

function DiscountDoubleCheck(){

    document.writeln("Welcome to Discount Double Check!<br>Let's check to see if you are getting a discount!<br>");

    var item1 = prompt("What is the cost of your first item?");

    while(!parseFloat(item1)){

        item1 = prompt("Invalid input...what is the cost of your first item?");
    }

    var item1Float = parseFloat(item1);

    var item2 = prompt("Great, what is the cost of your second item?");

    while(!parseFloat(item2)){

        item2 = prompt("Invalid input...what is the cost of your second item?");

    }

    var item2Float = parseFloat(item2);

    var totalPurchase = item1Float + item2Float;
    var discount5 = totalPurchase - (totalPurchase * .05);
    var discount10 = totalPurchase - (totalPurchase * .10);

    if (totalPurchase < 50){

        document.writeln("Your total purchase is $" +totalPurchase);

    } else if (totalPurchase > 50 && totalPurchase < 100){

        document.writeln("Your total purchase is $" + discount5 + " which includes your 5% discount");

    } else {

        document.writeln("Your total purchase is $" + discount10 + " which includes your 10% discount");
    }

}

