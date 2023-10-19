export var greeting : string = "Hello World!";
export class  Emp{
    name:string;
    id:number;
    constructor();
    constructor(n:string,i:number);
    constructor(n?:string,i?:number){
        if(n!=undefined && i!=undefined)
        {
            this.name=n;
            this.id=i;
        }
    }
    print():void{
        console.log("Emp details : id=" + this.id + " Name = " + this.name );
    }
}

