import {expect} from "chai";
import {describe} from "mocha";
import {foodDelivery} from "../foodDelivery.js";

describe('Test foodDelivery', () => {
    describe('getCategory', () => {
        it('should return proper message for input Vegan', () => {
            expect(foodDelivery.getCategory("Vegan"))
                .to.equal("Dishes that contain no animal products.");

        })
        it('should return proper message for input Vegetarian', () => {
            expect(foodDelivery.getCategory("Vegetarian"))
                .to.equal("Dishes that contain no meat or fish.");
        })
        it('should return proper message for input Gluten-Free', () => {
            expect(foodDelivery.getCategory("Gluten-Free"))
                .to.equal("Dishes that contain no gluten.");
        })
        it('should return proper message for input All', () => {
            expect(foodDelivery.getCategory("All"))
                .to.equal("All available dishes.");
        })
        it('should throw an error if input parameter is not valid', () => {
            expect(() => foodDelivery.getCategory(""))
                .to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory(null))
                .to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory(undefined))
                .to.throw("Invalid Category!");
            expect(() => foodDelivery.getCategory("Arthas"))
                .to.throw("Invalid Category!");
        })
    })
    describe('addMenuItem', () => {
        it('should throw an error if input parameters are not valid', () => {
            expect(() => foodDelivery.addMenuItem("", ""))
                .to.throw("Invalid Information!");

            expect(() => foodDelivery.addMenuItem([], 5))
                .to.throw("Invalid Information!");

            expect(() => foodDelivery.addMenuItem([{name: "Pizza", price: 10}], "10"))
                .to.throw("Invalid Information!");

            expect(() => foodDelivery.addMenuItem([{name: "Pizza", price: 10}], 4))
                .to.throw("Invalid Information!");
        })
        it('should return proper message if parameters are valid', () => {
            expect(foodDelivery.addMenuItem([{name: "Pizza", price: 10}], 10))
                .to.equal("There are 1 available menu items matching your criteria!");
        })
        it('should return proper message if all items prices are gteater than maxPrice', () => {
            const menu = [
                { name: "Pizza", price: 20 },
                { name: "Pasta", price: 25 }
            ];
            const maxPrice = 15;

            expect(foodDelivery.addMenuItem(menu, maxPrice))
                .to.equal("There are 0 available menu items matching your criteria!");
        })
    })
    describe('calculateOrderCost', () => {
        it('should throw an error if input parameters are not valid', () => {
            expect(() => foodDelivery.calculateOrderCost(5, ["sauce"], true))
                .to.throw("Invalid Information!");

            expect(() => foodDelivery.calculateOrderCost(["standard"], "sauce", true))
                .to.throw("Invalid Information!");

            expect(() => foodDelivery.calculateOrderCost(["standard"], ["sauce"], "true"))
                .to.throw("Invalid Information!");
        })
        it('should return proper message with discount', () => {
            const shipping = ["standard"];
            const addons = ["sauce", "beverage"];

            expect(foodDelivery.calculateOrderCost(shipping, addons, true))
                .to.equal("You spend $6.38 for shipping and addons with a 15% discount!");
        })
        it('should return proper message without discount', () => {
            const shipping = ["express"];
            const addons = ["beverage"];

            expect(foodDelivery.calculateOrderCost(shipping, addons, false))
                .to.equal("You spend $8.50 for shipping and addons!");
        })
    })
})