function solve(arr) {
    let guests = [];

    while (arr[0] !== 'PARTY') {

        let currGuest = arr.shift();
        guests.push(currGuest);

    }

    arr.shift();

    for (let guest of arr) {

        if (guests.includes(guest)) {
            let index = guests.indexOf(guest);
            guests.splice(index, 1);
        }
    }

    let vipGuests = guests.filter(guest => !isNaN(guest[0]));
    let regularGuests = guests.filter(guest => isNaN(guest[0]));

    console.log(guests.length);
    console.log(vipGuests.join("\n"));
    console.log(regularGuests.join("\n"));

}

solve(
    ['7IK9Yo0h',
        '9NoBUajQ',
        'Ce8vwPmE',
        'SVQXQCbc',
        'tSzE5t0p',
        'PARTY',
        '9NoBUajQ',
        'Ce8vwPmE',
        'SVQXQCbc'
    ]
)