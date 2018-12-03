document.body.innerHTML = "<center><h3>Hello, please make a selection from below.<h3>";

function OnTheMoon() {

    document.writeln("Welcome to Space Cadet!<br>Let's calculate what your weight would be if you were on the surface of the moon!");

    var weight = prompt("What is your current weight in pounds?");

    while (!parseFloat(weight)){

        weight = prompt("Invalid input...what is your current weight in pounds?");

    }

    var weightFloat = parseFloat(weight);


    function MoonWeight(weightFloat)
    {

        let weightOnMoon = weightFloat / 6;

        return weightOnMoon;

    }

    document.writeln("Ok! Here are your results: <br>");
    document.writeln("On earth you weigh " + weightFloat + "lbs and on the moon you weigh " + MoonWeight(weightFloat) + "lbs.");
}

function Discount(){


    document.writeln("Hey! Welcome to Discount Calculator!<br>");
    document.writeln("Let's calculate the final cost of your two items with discount.<br>");

    var item1 = prompt("What is the cost of your first item?");

    while(!parseFloat(item1)){

        item1 = prompt("Invalid input...what is the cost of your first item?");

    }

    var item1Float = parseFloat(item1);

    var item2 = prompt("What is the cost of your second item?");

    while(!parseFloat(item2)){

        item2 = prompt("Invalid input...what is the cost of your second item?");

    }

    var item2Float = parseFloat(item2);

    var discount = prompt("Got it! Now what is the desired discount?");

    while(!parseInt(discount)){

        discount = prompt("Invalid input...what is the desired discount?");

    }

    var discountInt = parseInt(discount);

    function TotalCost(){

        let totalCost = (item1Float + item2Float) - ((item1Float + item2Float) * (discountInt/100));

        return totalCost;


    }

    var totalCost = TotalCost(item1Float, item2Float, discountInt);

    document.writeln("With a discount of " + discountInt + "%, your total is $" + totalCost);




}

function DoubleTheFun(){

    let intArray = [ 11, 22, 44, 5, 6, 10, 33, 14];


    let intArrayDoubled = ArrayDoubler(intArray);


    function ArrayDoubler()
    {

        var arrayDoubled;
        for (let i = 0; i < intArray.length; i++)
        {

            arrayDoubled[i] = intArray[i] * 2;


        }


        return arrayDoubled;



    }

    document.writeln("Your original array was " + intArray + " and now it is doubled it is " + intArrayDoubled);

}

