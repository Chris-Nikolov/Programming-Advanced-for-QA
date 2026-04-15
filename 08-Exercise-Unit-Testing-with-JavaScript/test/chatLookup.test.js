import {lookupChar} from "../chatLookup.js";
import {expect} from "chai";
import {describe} from "mocha"

describe("test-charLookup", () => {
    it("returns undefined if first parameter is not a string", () => {
        let firstParam1 = 8;
        let firstParam2 = {'eight': 8};
        let firstParam3 = null;
        let firstParam4 = undefined;
        let firstParam5 = ["8"];

        let secondParam = 9;

        let result1 = lookupChar(firstParam1, secondParam);
        let result2 = lookupChar(firstParam2, secondParam);
        let result3 = lookupChar(firstParam3, secondParam);
        let result4 = lookupChar(firstParam4, secondParam);
        let result5 = lookupChar(firstParam5, secondParam);

        expect(result1).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
    });

    it("returns undefined if second parameter is not a string", () => {
        let secondParam1 = '8';
        let secondParam2 = {'eight': 8};
        let secondParam3 = null;
        let secondParam4 = undefined;
        let secondParam5 = ["8"];
        let secondParam6 = 2.2;

        let firstParam = '9';

        let result1 = lookupChar(firstParam, secondParam1);
        let result2 = lookupChar(firstParam, secondParam2);
        let result3 = lookupChar(firstParam, secondParam3);
        let result4 = lookupChar(firstParam, secondParam4);
        let result5 = lookupChar(firstParam, secondParam5);
        let result6 = lookupChar(firstParam, secondParam6);

        expect(result1).to.equal(undefined);
        expect(result2).to.equal(undefined);
        expect(result3).to.equal(undefined);
        expect(result4).to.equal(undefined);
        expect(result5).to.equal(undefined);
        expect(result6).to.equal(undefined);
    });

    it("returns 'Incorrect index' if index is out of range", () => {
        let firstParam = "Okay";
        let secondParam1 = 4;
        let secondParam2 = 8;
        let secondParam3 = -1;
        let expected = "Incorrect index";

        let result1 = lookupChar(firstParam, secondParam1);
        let result2 = lookupChar(firstParam, secondParam2);
        let result3 = lookupChar(firstParam, secondParam3);

        expect(result1).to.equal(expected);
        expect(result2).to.equal(expected);
        expect(result3).to.equal(expected);
    })

    it("returns correct expected value if both parameters are correct", () => {
        let firstParam = "Okay";
        let secondParam = 3;
        let expected = "y";
        let result = lookupChar(firstParam, secondParam);
        expect(result).to.equal(expected);
    })
});
