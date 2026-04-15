import { artGallery } from "../artGallery.js";
import { expect } from "chai";
import { describe } from "mocha";

describe('artGallery', () => {
    describe('test addArtwork', () => {
        it('should throw an error if title is not a string', () => {
            expect(() => artGallery.addArtwork(55, "50 x 70", "Monet")).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork(undefined, "50 x 70", "Monet")).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork(null, "50 x 70", "Monet")).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork(["Mistborn"], "50 x 70", "Monet")).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork({ key: "value" }, "50 x 70", "Monet")).to.throw("Invalid Information!");
        });

        it('should throw an error if artist is not a string', () => {
            expect(() => artGallery.addArtwork("Brandon", "50 x 70", 666)).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork("Shadowmourne", "50 x 70", undefined)).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork("Lich King", "50 x 70", null)).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork("Mistborn", "50 x 70", ["Brandon"])).to.throw("Invalid Information!");
            expect(() => artGallery.addArtwork("Value", "50 x 70", { key: "value" })).to.throw("Invalid Information!");
        });

        it('should throw an error if dimension is not in valid format', () => {
            expect(() => artGallery.addArtwork("Lich King", "50x70", "Monet")).to.throw("Invalid Dimensions!");
            expect(() => artGallery.addArtwork("Value", "50", "Monet")).to.throw("Invalid Dimensions!");
            expect(() => artGallery.addArtwork("Value", "x50 70", "Monet")).to.throw("Invalid Dimensions!");
            expect(() => artGallery.addArtwork("Value", "50 x 70 x 10", "Monet")).to.throw("Invalid Dimensions!");
        });

        it('should throw an error if artist is not allowed', () => {
            expect(() => artGallery.addArtwork("Mistborn", "50 x 70", "Brandon")).to.throw("This artist is not allowed in the gallery!");
        });

        it('should return proper message if all parameters are valid', () => {
            expect(artGallery.addArtwork("Water Lilies", "50 x 70", "Monet")).to.equal("Artwork added successfully: 'Water Lilies' by Monet with dimensions 50 x 70.");
        });
    });

    describe('test calculateCosts', () => {
        it('should throw an error if any parameter are not valid', () => {
            expect(() => artGallery.calculateCosts("100", 200, true)).to.throw("Invalid Information!");
            expect(() => artGallery.calculateCosts(100, "200", true)).to.throw("Invalid Information!");
            expect(() => artGallery.calculateCosts(100, 200, "true")).to.throw("Invalid Information!");
            expect(() => artGallery.calculateCosts(-100, 200, true)).to.throw("Invalid Information!");
            expect(() => artGallery.calculateCosts(100, -200, true)).to.throw("Invalid Information!");
            expect(() => artGallery.calculateCosts(null, 200, true)).to.throw("Invalid Information!");
        });

        it('correct calculations with a sponsor', () => {
            expect(artGallery.calculateCosts(100, 200, true)).to.equal("Exhibition and insurance costs are 270$, reduced by 10% with the help of a donation from your sponsor.");
            expect(artGallery.calculateCosts(0, 0, true)).to.equal("Exhibition and insurance costs are 0$, reduced by 10% with the help of a donation from your sponsor.");
        });

        it('correct calculations without a sponsor', () => {
            expect(artGallery.calculateCosts(100, 200, false)).to.equal("Exhibition and insurance costs are 300$.");
            expect(artGallery.calculateCosts(50.5, 49.5, false)).to.equal("Exhibition and insurance costs are 100$.");
        });
    });

    describe('test organizeExhibits', () => {
        it('should throw an error if any parameter are not valid', () => {
            expect(() => artGallery.organizeExhibits("10", 2)).to.throw("Invalid Information!");
            expect(() => artGallery.organizeExhibits(10, "2")).to.throw("Invalid Information!");
            expect(() => artGallery.organizeExhibits(0, 2)).to.throw("Invalid Information!");
            expect(() => artGallery.organizeExhibits(10, 0)).to.throw("Invalid Information!");
            expect(() => artGallery.organizeExhibits(-5, 2)).to.throw("Invalid Information!");
            expect(() => artGallery.organizeExhibits(10, -1)).to.throw("Invalid Information!");
        });

        it('should return proper message if artworksPerSpace is lower than five', () => {
            expect(artGallery.organizeExhibits(12, 3)).to.equal("There are only 4 artworks in each display space, you can add more artworks.");
            expect(artGallery.organizeExhibits(4, 1)).to.equal("There are only 4 artworks in each display space, you can add more artworks.");
        });

        it('should return proper message if artworksPerSpace is greater or equal to five', () => {
            expect(artGallery.organizeExhibits(15, 3)).to.equal("You have 3 display spaces with 5 artworks in each space.");
            expect(artGallery.organizeExhibits(21, 3)).to.equal("You have 3 display spaces with 7 artworks in each space.");
        });
    });
});
