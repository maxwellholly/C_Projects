var firstArray = [7, 24, 30, 12];

var secondArray = [9, 20.5, 35.9, 237.24];

let totalSumFirstArray = firstArray[0] + firstArray[1] + firstArray[2] + firstArray[3];

document.writeln("The total sum of firstArray is: " + totalSumFirstArray + "<br>");

let totalSumSecondArray = secondArray[0]+ secondArray[1] + secondArray[2] + secondArray[3];

document.writeln("The total sum of secondArray is: " + totalSumSecondArray + "<br>");

let firstArrayAverage = totalSumFirstArray/4;

document.writeln("The average of firstArray is: " + firstArrayAverage + "<br>");

let secondArrayAverage = totalSumSecondArray/4;

document.writeln("The average of secondArray is: " + secondArrayAverage + "<br>");

var thirdArray = [(firstArray[0] + secondArray[0]), (firstArray[1] + secondArray[1]), (firstArray[2] + secondArray[2]), (firstArray[3] + secondArray[3])];

var i = 0;

document.writeln("The thirdArray contains: ");

for (i = 0; i < thirdArray.length; i++){

    if (i != (thirdArray.length-1)){

        document.writeln("" + thirdArray[i] + ",");

    } else {

        document.writeln("" +thirdArray[i] + "<br>");
    }



}

var MixedUp = [" is like measuring ", "Measuring programming progress", "aircraft building progress ", " by lines of code", "by weight."];

let gatesQuote = MixedUp[1] + MixedUp[3] + MixedUp[0] + MixedUp[2] + MixedUp[4];

document.writeln("The Bill Gates quote should read:<br>" + gatesQuote);


