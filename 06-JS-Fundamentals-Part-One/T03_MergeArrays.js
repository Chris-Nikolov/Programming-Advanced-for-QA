function solve(arr1, arr2) {

    let finalArray = [];

    for (let i = 0; i < arr1.length; i++) {
        if (i % 2 === 0){

            finalArray.push(Number(arr1[i]) + Number(arr2[i]));

        } else {

            finalArray.push(arr1[i] + arr2[i]);

        }
    }

    console.log(finalArray.join(" - "));
}

solve(
    ['13', '12312', '5', '77', '4'],
    ['22', '333', '5', '122', '44']
);