function solve(arr1, arr2) {
    const set2 = new Set(arr2);

    for (const item of arr1) {
        if (set2.has(item)) {
            console.log(item);
        }
    }
}

solve(
    ['Hey', 'hello', 2, 4, 'Peter', 'e'],
    ['Petar', 10, 'hey', 4, 'hello', '2']
);
