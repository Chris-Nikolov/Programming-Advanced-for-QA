function solve(array) {
    let towns = {};

    for (let i = 0; i < array.length; i++) {
        let [townName, lat, long] = array[i].split(" | ");

        towns[townName] = {
            'latitude': Number(lat).toFixed(2),
            'longitude': Number(long).toFixed(2)
        };
    }

    for (const townName in towns) {
        let lat = towns[townName].latitude;
        let long = towns[townName].longitude;

        console.log(`{ town: '${townName}', latitude: '${lat}', longitude: '${long}' }`);
    }
}

solve([
    'Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625'
]);