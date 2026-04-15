import {isOddOrEven}from "../isOddOrEven.js";
import {describe} from "mocha";
import {expect} from "chai";

describe("isOddOrEven function", () => {
    it('should return undefined if input is not string', () => {
        let input = 666;
        let result = isOddOrEven(input);
        expect(result).to.equal(undefined);
        expect(isOddOrEven([3, 2])).to.equal(undefined);
        expect(isOddOrEven({'haha': "666"})).to.equal(undefined);
    });

    it('should return "even" if string length is even', () => {
        let input = "Warcraft";
        let result = isOddOrEven(input);
        expect(result).to.equal("even");
    });

    it('should return "odd" if string length is odd', () => {
        let input = "Paladin";
        let result = isOddOrEven(input);
        expect(result).to.equal("odd");
    });
});
