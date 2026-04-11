function solve(input) {

    let searchedWords = input.shift().split(' ');
    let wordsNumbers = {};

    for (let word of searchedWords) {
        wordsNumbers[word] = 0;
    }

    for (let currentWord of input) {

        if (wordsNumbers.hasOwnProperty(currentWord)) {
            wordsNumbers[currentWord]++;
        }
    }

    let sortedWords = Object.entries(wordsNumbers).sort((a, b) => b[1] - a[1]);

    for (let [word, count] of sortedWords) {
        console.log(`${word} - ${count}`);
    }
}

solve([
    'this sentence',
    'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]);