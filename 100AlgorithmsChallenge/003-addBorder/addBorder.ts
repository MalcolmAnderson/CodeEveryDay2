function test(): number {
    return -1;
}
function addBorder(picture: string[]): string[] {
    let topBorder: string = "";
    for (let i: number = 0; i < picture[0].length + 2; i++) {
        topBorder += "*";
    }
    const output: string[] = [];
    output.push(topBorder);
    for (let i: number = 0; i < picture.length; i++) {
        output.push("*" + picture[i] + "*");
    }
    output.push(topBorder);
    return output;
}

console.log(addBorder(["abc", "ded"]));