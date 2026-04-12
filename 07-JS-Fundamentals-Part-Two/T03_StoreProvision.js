function solve(arr1, arr2) {
    let store = {};

    for (let i = 0; i < arr1.length; i += 2) {
        let item = arr1[i];
        let qty = arr1[i + 1];
        store[item] = Number(qty);
    }

    for (let i = 0; i < arr2.length; i += 2) {
        let item = arr2[i];
        let qty = Number(arr2[i + 1]);


        if (store.hasOwnProperty(item)) {
            store[item] += qty;
        } else {
            store[item] = qty;
        }
    }

    for (let item in store) {
        console.log(`${item} -> ${store[item]}`);
    }
}

solve(
    ['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
    ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']
);