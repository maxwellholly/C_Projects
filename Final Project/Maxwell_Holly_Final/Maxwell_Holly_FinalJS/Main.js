document.writeln ("<center><h1> ~STAGE~ <h1></center>");
document.writeln ("<br><br>");
document.writeln ("<center><h3>Stage is a story progression game that transports you back to the simple pleasures of childhood,<br>where life is kind of like life...just a little more interesting.</h3></center>");
document.writeln("<center><button onclick=Continue()>Continue</button></center>");

class Character {

    constructor(name){

        this.name = name;

    }

    getCharacterName(){

        return this.name;

    }

    setCharacterName(name){

        this.name = name;

    }
//Local Storage and polymorphism
    save(){

        localStorage.setItem("Main Character Changed", ""+this.getCharacterName+" is now the main character in this story!");

    }

    describe(){

        document.writeln("<center>"+this.name+" is my name and I am the main character!</center><br>");
    }

}

class Animal extends Character{

    constructor(name, species){

        super(name);
        this.species = species;

    }

    getCharacterName(){

        return this.name;

    }

    setCharacterName(name){

        this.name = name;

    }

    getCharacterSpecies(){

        return this.species;

    }

    setCharacterSpecies(species){

        this.species = species;

    }
    //Local Storage and polymorphism
    save(){

        localStorage.setItem("New Character Added", "Hi! I'm "+this.getCharacterName()+" and I'm a "+this.getCharacterSpecies()+"!");

    }

    describe() {

        return document.writeln("<center>Hi! My name is " +this.name+ " and I am a " +this.species+"!</center><br>");
    }

}


function Continue() {

var name = prompt("What is your name?").valueOf();



//name validation
while (name == "" || name == " " ||  name == null){

    name = prompt("Invalid input...what is your name?").valueOf();
}

Menu(name);

}

var dad = new Animal("dad", "human");
var mainCharacter = new Character(name);

function Menu(name){

    document.writeln("<center>Fantastic! Welcome, "+name+"!</center>");

    mainCharacter.save();

    document.writeln("<center>Ok, I think I've got some that are your size...<br>Ah! Here they are!<br>Are you ready for this fully immersive experience?<br>*HUGE goggles are placed on your head and almost instantly you begin falling asleep*<br></center>");

    document.writeln("<center><button onclick=Story()>Continue</button></center>");
}

function Swings(){

    document.writeln("<center>You sit comfortably on the swing waiting for your " +dad.getCharacterName()+ " to push you.</center>");

    document.writeln("<center>He pushes you until you're soaring high, grinning ear to ear.</center>");

    document.writeln("<center>With the last push, something peculiar happens...you soar high but you don't come back down!</center>");

    document.writeln("<center>You're just floating...FLYING!</center>");

    document.writeln("<center>Your dad looks on in amazement and a little bit of uneasy fear.</center>");

    document.writeln("<center>'Can you get down?!' he shouts at you.</center>");

    document.writeln("<center>You come down, but instead of landing you grab your dad by the shoulders and fly him all the way home.</center>");

    document.writeln("<br><center>THE END</center>");

}

function SeeSaw(){

    document.writeln("<center>Once the two of you push off of the ground, you feel a splash of water <br>and begin looking around to notice that you're no longer in the park! " +
        "The see-saw has turned into a pirate ship and you and your dad are now in the middle of a giant bathtub...<br>" +
        "The two of you begin to laugh and play, digging through treasure and exploring. <br>" +
        "You spend hours playing pirates, until he says 'We should probably head home now,' <br>and just like that you're back home in a warm bath getting ready for dinner and a nap.<br></center>");

    document.writeln("<br><center>THE END</center>");
}

function OpenField(){

    var rabbit = new Animal("black rabbit", "rabbit");

    document.writeln("<center>As you roll and laugh in the grass you see a black bunny rabbit hopping towards you.<br>" +
        "You stay as still as possible so that you don't scare it away but the rabbit just stops and stares at you puzzled<br>" +
        "then says 'why are you playing statue? Is there danger around?' You stare back even more puzzled.<br>" +
        "The small black rabbit moves in closer and says 'My name is Nari, what's yours?'<br>" +
        "'"+ name +"' you say.<br>" +
        "'Well hello "+ name +", I think we're going to be good friends...I'll see you next time you come to play'<br> he said before disappearing into the nearby bushes.<br>" +
        "Your dad comes, picks you up and says 'we better head home'.<br></center>");

    rabbit.setCharacterName("Nari");

    document.writeln("<br><center>THE END</center>");

}

function PlushMonkey(){


    document.writeln( "<center>While playing with your new monkey friend you hear footsteps approaching the door to your room.<br>Your door opens and in walks your " +dad.getCharacterName()+ " with your coat and boots.<br>'It's time to head to the park!' he exclaims. </center>");

    document.writeln("<center>He helps you get bundled and the two of you head off.</center>");

    document.writeln("<center>Once at the park, you see all of your favorite places to play...the swings, the see-saw, and of course the open field...</center>");

    document.writeln("<center><button onclick=Swings()>Swings</button></center>");

    document.writeln("<center><button onclick=SeeSaw()>See-Saw</button></center>");

    document.writeln("<center><button onclick=OpenField()>Open Field</button></center>");

}

function Blocks(){

    var bosco = new Animal("Bosco", "dog");

    document.writeln( "<center>While building your tower to the moon you hear clattering, growing louder and louder.<br>" +
        "Finally, your dog," +bosco.getCharacterName()+", bursts into the room and exclaims 'HURRY, WE MUST GO!' before putting you on his back and racing off.<br>" +
        "'You can talk?!' you exclaim. 'Yes!' Bosco barks 'Now, there's an emergency we must attend to! Quick!'<br>" +
        "Bosco runs directly for the kitchen, he runs so excidedly that he slides halfway accross the tiled floor before stopping.<br>" +
        "'Where's the emergency?' you ask.<br>" +
        "'Can't you see it?! My dog food bag is COMPLETELY EMPTY!' he responds.<br>" +
        "'I need you to feed me from the refridgerator...' "+bosco.getCharacterName()+" trails off.<br>" +
        "So, you open the refidgerator for "+bosco.getCharacterName()+" and have a delicious feast.</center><br>");

    document.writeln("<br><center>THE END</center>");

}

function FireEngine(){

    var mom = new Animal("mom", "human");

    document.writeln ("<center>You hear footsteps drawing closer to your room until the door opens and a bear wearing your mom's clothes looks in on you.<br>" +
        "'Are you ready for your playdate?' she asks.<br>" +
        "'Yes' you reply without hesitation, you love playdates!<br>" +
        "'Alright, get your shoes on we're leaving now' she says sweetly.<br>" +
        "You put your shoes on and head to your playdate.</center><br>");

    mom.setCharacterSpecies = "bear";

    var leo = new Animal("Leo", "lion");
    var barry = new Animal("Barry", "bear");
    var arnold = new Animal("Arnie", "ostrich");
    var claire = new Animal("Claire", "zebra");

    var animals = [ leo, barry, arnold, claire ];

    document.writeln ("<center>When you get there, there aren't any children!<br>" +
        "There are only animals, and when they see you arrive they all start towards you.</center><br>");

    //Array loop iteration
    for (let i = 0; i < animals.length; i++)
    {
        document.writeln(animals[i].describe());
    }

    document.writeln("<center>You smile and say 'I'm " + name + "' and you all play safari for what seems like hours!</center><br>");


    document.writeln("<center>THE END</center>");

}

function Story(){

    document.writeln("<center>You wake up, cozy and snug, in your bed.<br>After rubbing your eyes you notice 3 toys placed neatly beside you...a plush monkey, some blocks and a fire engine.<br>Which toy will you choose?<br></center>");

    document.writeln("<center><button onclick=PlushMonkey()>Plush Monkey</button></center>");

    document.writeln("<center><button onclick=Blocks()>Blocks</button></center>");

    document.writeln("<center><button onclick=FireEngine()>Fire Engine</button></center>");

}







