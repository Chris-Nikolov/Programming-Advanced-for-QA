function solve(arr) {

    for (let i = 0; i < arr.length; i++) {

        let digits = String(arr[i]);

        let reversedDigits = digits.split('').reverse().join('');

        if (digits === reversedDigits) {
            console.log(true);
        } else {
            console.log(false);
        }
    }
}

solve([123, 323, 421, 121]);