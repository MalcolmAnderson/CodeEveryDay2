function absoluteValuesSumMinimization(a: number[]): number {
    const valueCollection: number[] = [];
    for (let i: number = 0; i <= 20; i++) {
        let total: number = 0;
        for (let j: number = 0; j < a.length; j++) {
            total += Math.abs(a[j] - i);
        }
        valueCollection.push(total);
    }
    console.log(valueCollection);
    let min = 5000;
    let index = -1;
    for (let i: number = 0; i < valueCollection.length; i++) {
        if (valueCollection[i] < min) {
            min = valueCollection[i];
            index = i;
        }

    }
    return index;
}

// abs(a[0] - x) + abs(a[1] - x)

console.log(absoluteValuesSumMinimization([2, 4, 7]));
console.log(absoluteValuesSumMinimization([2, 4, 7, 6]));
console.log(absoluteValuesSumMinimization([2, 4, 7, 6, 6]));
console.log(absoluteValuesSumMinimization([2, 4, 7, 6, 6, 8]));