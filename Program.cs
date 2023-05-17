
CheckPrimeEvenFibonacci(2);

// verify if a given number is prime, even or fibonacci
void CheckPrimeEvenFibonacci (int number) {
    bool isPrime = IsPrime(number);
    bool isEven = IsEven(number);
    bool isFibonacci = IsFibonacci(number);
    
    Console.WriteLine($"{number} is prime: {isPrime} even: {isEven} fibonacci: {isFibonacci}");
}

// verify if a given number is prime
bool IsPrime(int number){
    if (number > 1) {
        return Enumerable.Range(1,number).Where(x => number % x == 0 ).SequenceEqual(new [] {1,number});
    }

    return false;
}

// verify if a given number is even
bool IsEven(int number){   
    if (number % 2 != 0) {
        return false;
    }

    return true;
}

// verify if a given number is a perfect square
bool IsPerfectSquare(int number) {
    int result = (int) Math.Sqrt(number);

    return ((result * result) == number);
}

// verify if a given number is fibonacci
bool IsFibonacci(int number){
    // is fibonacci if and only if (5*N^2+4) or (5*N^2-4) is a perfect square
    return (IsPerfectSquare((5*number*number) + 4) || IsPerfectSquare((5*number*number) - 4));
}