function solve(array) {
    let topElements = [];

    for (let i = 0; i < array.length; i++) {
        let currentElement = array[i];
        let isTop = true;

        for (let j = i + 1; j < array.length; j++) {
            if (currentElement <= array[j]) {
                isTop = false;
                break;
            }
        }

        if (isTop) {
            topElements.push(currentElement);
        }
    }

    console.log(topElements.join(" "));
}

solve([1, 4, 3, 2]);