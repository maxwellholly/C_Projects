document.body.innerHTML = "<center>Welcome to shopping list, below you will find the contents of the list and the corresponding prices.</center>";


let shoppingList = ["peach", "pineapple", "apple", "grape", "honeydew", "strawberry", "mango", "cucumber" ];


let priceList = [ 1.75, 3.45, 2.50, 4.65, 3.20, 5.45, 4.35, 1.25 ];


document.writeln("We'll be making some changes to the shopping list, changes are shown below.<br>");


shoppingList.remove("peach");
shoppingList.remove("pineapple");
priceList.remove(1.75);
priceList.remove(3.45);


shoppingList.push("banana");
priceList.push(0.50);


CombineTheLists(shoppingList, priceList);


function CombineTheLists (shop, price)
{

    for (let i=0; i < shop.length; i++)
    {



        Console.WriteLine("The " + shop[i] + " costs " + price[i].toString('c'));



    }


}