function solve(array) {
    let movies = []
    for (const info of array) {

        if (info.startsWith('addMovie')) {

            let movie = info.replace('addMovie ', '');
            movies.push({name: movie});

        } else if (info.includes('directedBy')) {

            let [movieName, directorName] = info.split(' directedBy ');
            let movie = movies.find(m => m.name === movieName);

            if (movie) {
                movie.director = directorName;
            }

        } else if (info.includes('onDate')) {

            let [movieName, movieDate] = info.split(' onDate ');
            let movie = movies.find(m => m.name === movieName);

            if (movie) {
                movie.date = movieDate;
            }
        }
    }

    for (const movie of movies) {

        if (movie.director && movie.date) {
            console.log(JSON.stringify(movie));
        }
    }
}

solve([
    'addMovie Fast and Furious',
    'addMovie Godfather',
    'Inception directedBy Christopher Nolan',
    'Godfather directedBy Francis Ford Coppola',
    'Godfather onDate 29.07.2018',
    'Fast and Furious onDate 30.07.2018',
    'Batman onDate 01.08.2018',
    'Fast and Furious directedBy Rob Cohen'
])