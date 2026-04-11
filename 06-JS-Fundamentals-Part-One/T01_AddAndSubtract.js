function solve(numbers)
{
    let originalSum = 0;
    let finalSum = 0;

    for (let i = 0; i < numbers.length; i++)
    {
        originalSum += numbers[i];
        if (numbers[i] % 2 === 0) {

            numbers[i] += i;
        } else {
            numbers[i] -= i;
        }
        finalSum += numbers[i];
    }

    console.log(numbers);
    console.log(originalSum);
    console.log(finalSum);
}

