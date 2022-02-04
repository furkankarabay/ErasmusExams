
//Fibonacci Series That Are Smaller Than 2000
    
let a = 0, b = 1, result = 0, iteration = 0;

while(result < 2000)
{
    iteration++;
    console.log(result);
    
    if (iteration <= 1)
        result = iteration;
    else
    {
        result = a + b;
        a = b;
        b = result; 
    }
                    
}