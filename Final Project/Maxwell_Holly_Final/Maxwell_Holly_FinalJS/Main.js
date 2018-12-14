document.writeln ("<center><h1> ~STAGE~ <h1></center>");
document.writeln ("<br><br>");
document.writeln ("<center><h3>Stage is a story progression game that transports you back to the simple pleasures of childhood,<br>where life is kind of like life...just a little more interesting.</h3></center>");
document.writeln("<center><button onclick=Continue()>Continue</button></center>");

class Character {

    constructor(name){

        this.name = name;

    };

    get getCharacterName(){

        return this.name;

    }

    set setCharacterName(name){

        this.name = name;

    }
//Local Storage and polymorphism
    save(){

        localStorage.setItem("Main Character Changed", ""+this.getCharacterName+" is now the main character in this story!");

    }

}

class Animal extends Character{

    constructor(name, species){

        super(name);
        this.species = species;

    }

    get getCharacterName(){

        return this.name;

    }

    set setCharacterName(name){

        this.name = name;

    }

    get getCharacterSpecies(){

        return this.species;

    }

    set setCharacterSpecies(species){

        this.species = species;

    }
    //Local Storage and polymorphism
    save(){

        localStorage.setItem("New Character Added", "Hi! I'm "+this.getCharacterName+" and I'm a "+this.getCharacterSpecies+"!");

    }

}


function Continue(){

var name = prompt("What is your name?").valueOf();

//
while (name == "" || name == " " || name == null){

    name = prompt("Invalid input...what is your name?")
}

Menu(name);

}


function Menu(name){

    document.writeln("<center>Fantastic! Welcome, "+name+"!</center>");

    var mainCharacter = new Character(name);

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

    document.writeln("<center>'"+mainCharacter.getCharacterName()+"can you get down?!' he shouts at you.</center>");

    document.writeln("<center>You come down, but instead of landing you grab your dad by the shoulders and fly him all the way home.</center>");

    document.writeln("<br><center>THE END</center>");

}

function SeeSaw(){


}

function OpenField(){


}

function PlushMonkey(){

    var dad = new Animal("dad", "human");

    document.writeln( "<center>While playing with your new monkey friend you hear footsteps approaching the door to your room.<br>Your door opens and in walks your " +dad.getCharacterName+ "with your coat and boots.<br>'It's time to head to the park!' he exclaims. </center>");

    document.writeln("<center>He helps you get bundled and the two of you head off.</center>");

    document.writeln("<center>Once at the park, you see all of your favorite places to play...the swings, the see-saw, and of course the open field...</center><br>");

    document.writeln("<center><button onclick=Swings()>Swings</button></center>");

    document.writeln("<center><button onclick=SeeSaw()>See-Saw</button></center>");

    document.writeln("<center><button onclick=OpenField()>Open Field</button></center>");

}

function Blocks(){


}

function FireEngine(){


}

function Story(){

    document.writeln("<center>You wake up, cozy and snug, in your bed.<br>After rubbing your eyes you notice 3 toys placed neatly beside you...a plush monkey, some blocks and a fire engine.<br>Which toy will you choose?<br></center>");

    document.writeln("<center><button onclick=PlushMonkey()>Plush Monkey</button></center>");

    document.writeln("<center><button onclick=Blocks()>Blocks</button></center>");

    document.writeln("<center><button onclick=FireEngine()>Fire Engine</button></center>");

}







