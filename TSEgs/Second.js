"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Emp = exports.greeting = void 0;
exports.greeting = "Hello World!";
var Emp = /** @class */ (function () {
    function Emp(n, i) {
        if (n != undefined && i != undefined) {
            this.name = n;
            this.id = i;
        }
    }
    Emp.prototype.print = function () {
        console.log("Emp details : id=" + this.id + " Name = " + this.name);
    };
    return Emp;
}());
exports.Emp = Emp;
