function solve(numbers) {

    numbers = String(numbers);
    let evenSum = 0;
    let oddSum = 0;

    for (const digit of numbers) {

        let number = Number(digit);

        if (number % 2 === 0) {
            evenSum += number;
        } else {
            oddSum += number;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}