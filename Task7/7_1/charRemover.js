function charRem(s) 
{
    let stringS = s + "";
    console.log(stringS);

    let wrapWords = stringS.split(' ');
    console.log(wrapWords);

    let repeatLetter = [];

    wrapWords.forEach(element => {
        for(let i = 0; i < element.length; i++) {
            for (let j = i+1; j < element.length; j++) {
                if(element[j] == element[i] && !repeatLetter.includes(element[i]))
                    repeatLetter.push(element[i]);
            }
        }
    });
    console.log(repeatLetter);

    let result = stringS + "";
    console.log(result);
    repeatLetter.forEach(element => {
        console.log(element);
        while(result.includes(element)) {
            result = result.replace(element, "");
            console.log(result);
        }
    });
    
    return result;
}