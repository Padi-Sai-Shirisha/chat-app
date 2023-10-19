
// function calc(n1:number,n2:number):void; 
// function calc(s1:string, s2:string):void; 
// function calc(n1:number,n2:number, n3:number,n4:number):void; 
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
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
var sec = require("./Second");
console.log(sec.greeting); //Prints Hello World!
//greeting is a read-only property here, non-editable.
//sec.greeting = "blah blah";
var myEmp = /** @class */ (function (_super) {
    __extends(myEmp, _super);
    function myEmp(n, i) {
        var _this = this;
        if (n != undefined && i != undefined)
            _this = _super.call(this, n, i) || this;
        return _this;
    }
    myEmp.prototype.print = function () {
        console.log("myEmp inheriting parent Emp details : id=" + this.id + " Name = " + this.name);
    };
    return myEmp;
}(sec.Emp));
var empObj = new sec.Emp("John", 101);
empObj.print();
var myEmpObj = new myEmp("Doe", 102);
myEmpObj.print();
