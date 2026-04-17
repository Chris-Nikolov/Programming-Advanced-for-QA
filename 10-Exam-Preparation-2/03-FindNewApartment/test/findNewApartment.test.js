import { findNewApartment } from '../findNewApartment.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai'

describe('test_findNewApartment', () =>{
    describe('isGoodLocation', () => {
        it('should throw error on invalid input', () => {
            expect(() => findNewApartment.isGoodLocation(1000, "true"))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isGoodLocation("Sofia", "true"))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isGoodLocation(["Sofia"], true))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isGoodLocation(undefined, undefined))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isGoodLocation(null, null))
                .to.throw("Invalid input!");
        });
        it('should return "This location is not suitable for you." if location is not valid', () => {

            expect( findNewApartment.isGoodLocation("Vidin", true))
                .to.equal("This location is not suitable for you.");

        });
        it('should return "You can go on home tour!" if location is good and public transport is available', () => {
            expect(findNewApartment.isGoodLocation("Sofia", true))
                .to.equal("You can go on home tour!");
            expect(findNewApartment.isGoodLocation("Varna", true))
                .to.equal("You can go on home tour!");
            expect(findNewApartment.isGoodLocation("Plovdiv", true))
                .to.equal("You can go on home tour!");
        });
        it('should return "There is no public transport in area." if location is good but public transport is unavailable', () => {
            expect(findNewApartment.isGoodLocation("Sofia", false))
                .to.equal("There is no public transport in area.");
            expect(findNewApartment.isGoodLocation("Varna", false))
                .to.equal("There is no public transport in area.");
            expect(findNewApartment.isGoodLocation("Plovdiv", false))
                .to.equal("There is no public transport in area.");
        });
    })
    describe('Test isLargeEnough', () => {
        it('Should return apartments that meet the wanted criteria for minimal square meters', () => {
            expect(findNewApartment.isLargeEnough([50, 33, 70, 85, 15, 55], 49))
                .to.equal("50, 70, 85, 55");
        });

        it('Should throw error on invalid input', () => {
            expect(() => findNewApartment.isLargeEnough(undefined, undefined))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isLargeEnough(null, null))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isLargeEnough([], 50))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isLargeEnough([33, 12], "50"))
                .to.throw("Invalid input!");
        });
    })
    describe('isItAffordable', () => {
        it('should throw an error on invalid input', () => {
            expect(() => findNewApartment.isItAffordable([33, 12], "50"))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(undefined, undefined))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(null, null))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(50, "50"))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable("66", 77))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(0, 0))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(-1, -1))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(55, -1))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(-1, 55))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(0, 55))
                .to.throw("Invalid input!");
            expect(() => findNewApartment.isItAffordable(55, 0))
                .to.throw("Invalid input!");
        });
        it('should not be affordable if price is greater than budget', () => {
            expect(findNewApartment.isItAffordable(50000, 25000))
                .to.equal("You don't have enough money for this house!");
        });
        it('should be affordable if price is equal to or less than budget', () => {
            expect(findNewApartment.isItAffordable(50000, 50000))
                .to.equal("You can afford this home!");

            expect(findNewApartment.isItAffordable(30000, 50000))
                .to.equal("You can afford this home!");
        });
    })
})


