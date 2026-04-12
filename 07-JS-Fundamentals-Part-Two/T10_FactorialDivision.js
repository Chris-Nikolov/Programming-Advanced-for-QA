function solve(num1, num2) {

    function calculateFactorial(n) {
        let result = 1;
        for (let i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }

    let firstFactorial = calculateFactorial(num1);
    let secondFactorial = calculateFactorial(num2);

    let result = firstFactorial / secondFactorial;

    console.log(result.toFixed(2));
}

solve(5, 2);
