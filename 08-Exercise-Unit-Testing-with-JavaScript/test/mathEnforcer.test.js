import {mathEnforcer} from "../mathEnforcer.js";
import {describe, it} from "mocha";
import {expect} from "chai";

describe("MathEnforcer", function() {
    it('should return undefined on addFive functions when parameter is is not a number', () => {
        let input = "5";
        let input2 = undefined;
        let input3 = null;
        let input4 = ["five"];
        let input5 = {"five": 5};

        let result = mathEnforcer.addFive(input);
        let result2 = mathEnforcer.addFive(input2);
        let result3 = mathEnforcer.addFive(input3);
        let result4 = mathEnforcer.addFive(input4);
        let result5 = mathEnforcer.addFive(input5);

        expect(result).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
    });

    it('should return a number + 5 if the parameter is number', () => {
        let input = 5;
        let expected = 10;
        let result = mathEnforcer.addFive(input);
        expect(result).to.equal(expected);
        expect(mathEnforcer.addFive(-5)).to.equal(0);
        expect(mathEnforcer.addFive(1.1)).to.be.closeTo(6.1, 0.01);
    })

    it('should return undefined on subtractTen functions when parameter is is not a number', () => {
        let input = "5";
        let input2 = undefined;
        let input3 = null;
        let input4 = ["five"];
        let input5 = {"five": 5};

        let result = mathEnforcer.subtractTen(input);
        let result2 = mathEnforcer.subtractTen(input2);
        let result3 = mathEnforcer.subtractTen(input3);
        let result4 = mathEnforcer.subtractTen(input4);
        let result5 = mathEnforcer.subtractTen(input5);

        expect(result).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
    });

    it('should return a number -10 if the parameter is number', () => {
        let input = 5;
        let expected = -5;
        let result = mathEnforcer.subtractTen(input);
        expect(result).to.equal(expected);
        expect(mathEnforcer.subtractTen(-10)).to.equal(-20);
        expect(mathEnforcer.subtractTen(10.5)).to.be.closeTo(0.5, 0.01);
    });

    it('should return undefined on sum functions when  first parameter is is not a number', () => {
        let input = "5";
        let input2 = undefined;
        let input3 = null;
        let input4 = ["five"];
        let input5 = {"five": 5};
        let param2 = 5;

        let result = mathEnforcer.sum(input, param2);
        let result2 = mathEnforcer.sum(input2, param2);
        let result3 = mathEnforcer.sum(input3, param2);
        let result4 = mathEnforcer.sum(input4, param2);
        let result5 = mathEnforcer.sum(input5, param2);

        expect(result).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
    });

    it('should return undefined on sum functions when  second parameter is is not a number', () => {
        let input = "5";
        let input2 = undefined;
        let input3 = null;
        let input4 = ["five"];
        let input5 = {"five": 5};
        let param1 = 5;

        let result = mathEnforcer.sum(param1, input);
        let result2 = mathEnforcer.sum(param1, input2);
        let result3 = mathEnforcer.sum(param1, input3);
        let result4 = mathEnforcer.sum(param1, input4);
        let result5 = mathEnforcer.sum(param1, input5);

        expect(result).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
    });

    it('should return sum of two parameters if they are valid numbers', () => {
        let param1 = 5;
        let param2 = 45;
        let expected = 50;
        let result = mathEnforcer.sum(param1, param2);
        expect(result).to.equal(expected);
        expect(mathEnforcer.sum(-5, -10)).to.equal(-15);
        expect(mathEnforcer.sum(1.1, 2.2)).to.be.closeTo(3.3, 0.01);
    });
});