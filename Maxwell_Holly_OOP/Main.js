
class Person {

    constructor(name){

        this.name = name;
    };

    get theirName(){

        return this.name;

    };

    speak(){

        console.log(this.name + " is a person!");
    };
};

class Manager extends Person {

    constructor(name, salary){

        super(name);
        this.salary = salary;
    }

    get getSalary(){

        return this.salary;

    };

    speak(){

        console.log("Manager: " + this.name + " makes $" + this.salary + " per year.");
    };

};

class Employee extends Person {

    constructor(name, pay){

        super(name);
        this.pay = pay;
    };

    get getPay(){

        return this.pay;

    };

    speak(){

        console.log("Employee: " + this.name + " makes $" + this.pay + " per hour.");
    };

};


var charlie = new Person("Charlie");

var jerry = new Employee("Jerry", 14.00);

var laura = new Manager("Laura", 50000);

console.log(charlie.theirName + " is a customer.");

console.log("Jerry is hourly and makes $" + jerry.getPay + " per hour.");

console.log("Laura is the manager and she makes $" + laura.getSalary + " a year.");

laura.speak();

charlie.speak();

jerry.speak();

// Inheritance was used by extending the Person class with the Manager class and Employee class
// Polymorphism was used with the unique speak functions for the super class and its child classes