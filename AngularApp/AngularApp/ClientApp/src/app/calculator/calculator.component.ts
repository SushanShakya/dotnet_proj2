import { Component } from "@angular/core";

@Component({
    selector: "app-calculator-component",
    templateUrl: "./calculator.component.html"
})
export class CalculatorComponent {
    public result = 0;

    public dummy() {
        console.log("Hello World");
        alert("Hello World");
    }

    public compute() {

        let a = (document.getElementById("a") as HTMLInputElement).value;
        let b = (document.getElementById("b") as HTMLInputElement).value;
        let c = (document.getElementById("op") as HTMLSelectElement).value;

        let x = parseInt(a)
        let y = parseInt(b)

        switch (c) {
            case "add":
                this.add(x, y);
                break;
            case "sub":
                this.substract(x, y);
                break;
            case "mul":
                this.multiply(x, y);
                break;
        }
    }

    public add(a: number, b: number) {
        this.result = a + b;
    }

    public substract(a: number, b: number) {
        this.result = a - b;

    }

    public multiply(a: number, b: number) {
        this.result = a * b;
    }
}