// function calc(n1:number,n2:number):void; 
// function calc(s1:string, s2:string):void; 
// function calc(n1:number,n2:number, n3:number,n4:number):void; 

// function calc(x:any,y:any, z?:number,w?:number ):void { 
//     if(w!= undefined && z!= undefined)
//     {
//         console.log(w+x+y+z);
//     }
//     else if(typeof(x) == 'number' && typeof(x) == 'number')
//     {
//         console.log(x+y);
//     }
//     else
//     {
//         console.log(x+y);
//     }
//  } 

//  calc("hello", " world");
//  calc(2,3);
//  calc(1,2,3,4);
//  calc(3.4, 5.5);


import * as sec from "./Second";
console.log(sec.greeting); //Prints Hello World!
//greeting is a read-only property here, non-editable.
//sec.greeting = "blah blah";
class myEmp extends sec.Emp{
   constructor();
    constructor(n:string,i:number);
    constructor(n?:string,i?:number){
      if(n!=undefined && i!=undefined)
         super(n,i);
    }
    print():void{
      console.log("myEmp inheriting parent Emp details : id=" + this.id + " Name = " + this.name );
  }
}

var empObj = new sec.Emp("John",101);
empObj.print();

var myEmpObj = new myEmp("Doe",102);
myEmpObj.print();
 
 