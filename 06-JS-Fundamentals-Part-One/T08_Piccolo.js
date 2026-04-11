function solve(arr) {
    let parking = [];

    for (let i = 0; i < arr.length; i++) {
        let [command, car] = arr[i].split(", ");

        if (command === "IN") {
            if (!parking.includes(car)) {
                parking.push(car);
            }
        } else if (command === "OUT") {

            let index = parking.indexOf(car);

            if (index !== -1) {
                parking.splice(index, 1);
            }
        }
    }

    if (parking.length === 0) {
        console.log("Parking Lot is Empty");
    } else {

        parking.sort((a, b) => a.localeCompare(b));

        parking.forEach(car => console.log(car));
    }
}

solve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU'])