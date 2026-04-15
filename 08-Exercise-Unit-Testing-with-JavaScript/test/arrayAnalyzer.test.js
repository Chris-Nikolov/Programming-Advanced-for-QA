import {analyzeArray} from '../arrayAnalyzer.js';
import {describe} from "mocha";
import {expect} from "chai";

describe("analyzeArray", function() {
    it('should return undefined if input is not an array', () => {
        expect(analyzeArray("not an array")).to.equal(undefined);
        expect(analyzeArray(13)).to.equal(undefined);
        expect(analyzeArray({ key: "value" })).to.equal(undefined);
        expect(analyzeArray(null)).to.equal(undefined);
        expect(analyzeArray(undefined)).to.equal(undefined);
    });

    it('should return undefined if the array is empty', () => {
        expect(analyzeArray([])).to.equal(undefined);
    });

    it('should return undefined if any element in the array is not a number', () => {
        expect(analyzeArray([1, 2, "3"])).to.equal(undefined);
        expect(analyzeArray([1, null, 3])).to.equal(undefined);
        expect(analyzeArray([undefined])).to.equal(undefined);
    });

    it('should return correct object if input is a valid array of numbers', () => {
        let input = [1, 2, 3, 4, 5];
        let expected = { min: 1, max: 5, length: 5 };
        expect(analyzeArray(input)).to.deep.equal(expected);
    });

    it('should work correctly with negative numbers', () => {
        let input = [-5, -1, -10, 0];
        let expected = { min: -10, max: 0, length: 4 };
        expect(analyzeArray(input)).to.deep.equal(expected);
    });

    it('should work correctly with floating point numbers', () => {
        let input = [1.1, 2.2, 0.5];
        let result = analyzeArray(input);
        expect(result.min).to.be.closeTo(0.5, 0.01);
        expect(result.max).to.be.closeTo(2.2, 0.01);
        expect(result.length).to.equal(3);
    });

    it('should return correct object if input is a single element array', () => {
        let input = [5];
        let expected = { min: 5, max: 5, length: 1 };
        expect(analyzeArray(input)).to.deep.equal(expected);
    });

    it('should return correct object if input is an array with equal elements', () => {
        let input = [7, 7, 7];
        let expected = { min: 7, max: 7, length: 3 };
        expect(analyzeArray(input)).to.deep.equal(expected);
    });
});
