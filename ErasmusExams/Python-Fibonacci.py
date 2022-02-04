
#Fibonacci Series That Are Smaller 2000

print("Hello World")
a, b, result, iteration= 0, 1, 0, 0

while result < 2000:
    iteration = iteration + 1;
    print(result)
                
    if iteration <= 1:
        result = iteration
    else:
        result = a + b
        a = b
        b = result
