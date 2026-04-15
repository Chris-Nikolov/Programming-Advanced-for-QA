import {expect} from "chai";
import {describe, it} from "mocha";
import {workforceManagement} from "../workforceManagement.js";

describe('Test_workforceManagement', () => {

    describe('recruitStaff', () => {
        it('should return correct message', () => {
            expect(workforceManagement.recruitStaff("Ivan", "Developer", 4))
                .to.equal("Ivan has been successfully recruited for the role of Developer.");
            expect(workforceManagement.recruitStaff("Ivan", "Developer", 10))
                .to.equal("Ivan has been successfully recruited for the role of Developer.");
            expect(workforceManagement.recruitStaff("John", "Developer", 3))
                .to.equal("John is not suitable for this role.");
        })
        it('should throw an error for invalid role', () => {
            expect(() => workforceManagement.recruitStaff("John", "Manager", 5))
                .to.throw("We are not currently hiring for this role.");
        })
    })

    describe('computeWages', () => {
        it('should throw an error for incorrect hoursWorked', () => {
            expect(() => workforceManagement.computeWages("20")).to.throw("Invalid hours");
            expect(() => workforceManagement.computeWages(-1)).to.throw("Invalid hours");
            expect(() => workforceManagement.computeWages(undefined)).to.throw("Invalid hours");
        })
        it('should return correct payment', () => {
            expect(workforceManagement.computeWages(100)).to.equal(1800);
            expect(workforceManagement.computeWages(160)).to.equal(2880);
            expect(workforceManagement.computeWages(161)).to.equal(161 * 18 + 1500);
            expect(workforceManagement.computeWages(0)).to.equal(0);
        })
    })

    describe('dismissEmployee', () => {
        it('should throw an error if input parameters are not valid', () => {
            expect(() => workforceManagement.dismissEmployee("Ivan", 1)).to.throw("Invalid input");
            expect(() => workforceManagement.dismissEmployee(["Ivan"], "1")).to.throw("Invalid input");
            expect(() => workforceManagement.dismissEmployee(["Ivan"], -1)).to.throw("Invalid input");
            expect(() => workforceManagement.dismissEmployee(["Ivan"], 1)).to.throw("Invalid input");
            expect(() => workforceManagement.dismissEmployee(["Ivan"], 1.5)).to.throw("Invalid input");
        })
        it('should return correct message', () => {
            expect(workforceManagement.dismissEmployee(["Peter", "Ivan", "George"], 1))
                .to.equal("Peter, George");
            expect(workforceManagement.dismissEmployee(["Peter"], 0))
                .to.equal("");
            expect(workforceManagement.dismissEmployee(["Peter", "Ivan"], 0))
                .to.equal("Ivan");
        })
    })
})