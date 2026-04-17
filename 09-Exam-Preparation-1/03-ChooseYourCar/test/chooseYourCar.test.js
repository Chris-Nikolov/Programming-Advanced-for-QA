import { chooseYourCar } from '../chooseYourCar.js'
import { describe } from 'mocha'
import { expect, assert } from 'chai';

describe('Test chooseYourCar', () => {
    describe('choosingType', () => {
        it('should throw an error on invalid input', () => {

            expect(() => chooseYourCar.choosingType("Coupe", "Green", 2010))
                .to.throw("This type of car is not what you are looking for.");

            assert.throw(() => chooseYourCar.choosingType("Sedan", "Red", 1898),
                "Invalid Year!")

            assert.throw(() => chooseYourCar.choosingType("Sedan", "Yellow", 2023),
                "Invalid Year!")


        });
        it('should meet requirments for a car', () => {
            expect(chooseYourCar.choosingType("Sedan", "Green", 2010))
                .to.equal(`This Green Sedan meets the requirements, that you have.`)
        });
        it('should not meet requirments for a car', () => {

            expect(chooseYourCar.choosingType("Sedan", "Yellow", 2008))
                .to.equal(`This Sedan is too old for you, especially with that Yellow color.`)
        });
    });

    describe('brandName', () => {
        it('should throw an error on invalid input', () => {
            expect(() => chooseYourCar.brandName("BMW, Porsche, McLaren", 0))
                .to.throw("Invalid Information!");

            expect(() => chooseYourCar.brandName({BMW: "BMW"}, 0))
                .to.throw("Invalid Information!");

            expect(() => chooseYourCar.brandName(["BMW", "Porsche"], 1.1))
                .to.throw("Invalid Information!");

            expect(() => chooseYourCar.brandName(["BMW", "Porsche"], 2))
                .to.throw("Invalid Information!");

            expect(() => chooseYourCar.brandName(["BMW", "Porsche"], -1))
                .to.throw("Invalid Information!");
        });

        it('should return the correct brands', () => {
            expect(chooseYourCar.brandName(["BMW", "Porsche", "Ford"], 2))
                .to.equal("BMW, Porsche")
        });
    });

    describe('carFuelConsumption', () => {
        it('should throw an error on invalid input', () => {
            expect(() => chooseYourCar.carFuelConsumption( "10", 10))
                .to.throw("Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption( 10, "10"))
                .to.throw("Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption( 0, 0))
                .to.throw("Invalid Information!");
            expect(() => chooseYourCar.carFuelConsumption( -10, -1))
                .to.throw("Invalid Information!");
        });

        it('should return message for an efficient car', () => {
            expect(chooseYourCar.carFuelConsumption( 60, 4))
                .to.equal(`The car is efficient enough, it burns 6.67 liters/100 km.`)

            expect(chooseYourCar.carFuelConsumption(1000, 70))
                .to.equal(`The car is efficient enough, it burns 7.00 liters/100 km.`);
        });

        it('should return message for an non efficient car', () => {
            expect(chooseYourCar.carFuelConsumption( 60, 10))
                .to.equal(`The car burns too much fuel - 16.67 liters!`)
        });
    });
});