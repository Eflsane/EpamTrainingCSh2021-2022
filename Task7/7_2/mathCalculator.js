function mathCalc(s) 
{
    let stringS = s + "";
    console.log(stringS);

    let operatorsPattern = /[\+,\-,\*,\/,\=]/ig;  
    let operatorArr = stringS.match(operatorsPattern);
    console.log(operatorArr);
    
    let operandsPattern = /\d+(\.\d+)?/ig;
    let operandArr = stringS.match(operandsPattern);
    console.log(operandArr);

    if(operandArr.length <= 0 || operatorArr.length <= 0) {
        console.log("there is no operands or operators in given string");
        return 0;
    }

    if(operandArr.length != operatorArr.length) {
        console.log("exception");
        return 0;
    }
    
    let a = Number(operandArr[0]);
    console.log(a);
    let b = 0;

    for(let i = 0; i < operatorArr.length; i++) {
        switch (operatorArr[i]) {
            case "+":
                b = Number(operandArr[i+1]);
                console.log(b);
                a += b;
                break;
            
            case "-":
                b = Number(operandArr[i+1]);
                console.log(b);
                a -= b;
                break;
                
            case "*":
                b = Number(operandArr[i+1]);
                console.log(b);
                a *= b;
                break;
            
            case "/":
                b = Number(operandArr[i+1]);
                console.log(b);
                a /= b;
                break;
                
            case "=":
                return a.toFixed(2);   
            default:
                console.log("exception")
                return 0;
                break;
        } 
    }

    console.log("error occured")
        return 0;     
}