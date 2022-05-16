// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string s = "#  *";
// Console.WriteLine(s);
// Найти фаториал N

// Console.Write("Enter number:");
// int Number = Convert.ToInt32(Console.ReadLine());
// //string NumberToSrting = Convert.ToString(Math.Abs(Number));

// int fact_func(int i)
//  {
// if(i==1) return i;
// else return i*fact_func(i-1);
// }
// Console.WriteLine($"N!= {fact_func(Number)}");


// int Fact (int Number);
// {
//   if(userInt===0);
//     return '1'

//   if(!userInt)
//     return ''

//   var i, nextNumber, carret,

//   result = userInt.toString().split('').reverse().map(Number)

//   while(--userInt){
//     i = carret = 0

//     while((nextNumber = result[i++]) !== undefined || carret) {
//       carret = (nextNumber || 0) * userInt + carret
//       result[i-1] = carret % 10
//       carret = parseInt(carret/10)
//     }
//   }

//   return result.reverse().join('')
// }


// Console.Write("Enter number:");
// int Number = Convert.ToInt32(Console.ReadLine());

// int multiplyx(int x, int ans[], int size) 
// { 
//     int carry = 0;   
//     for (int i=0; i<size; i++) 
//     { 
//         int product = ans[i] * x + carry; 
//         ans[i] = product % 10;   
//         carry  = product/10;     
//     } 

//     while (carry) 
//     { 
//         ans[size] = carry%10; 
//         carry = carry/10; 
//         size++; 
//     } 
//     return size; 
// } 

// void factorial(int n) 
// { 
//     int ans[MAX]; 
//     ans[0] = 1; 
//     int size = 1; 
//     for (int x=2; x<=n; x++) 
//         size = multiplyx(x, ans, size); 
//     for (int i=size-1; i>=0; i--) 
//         cout << ans[i]; 
// } 

// int main(int n)
// {
// 	factorial(n);
// 	return 0;
// }
// Console.WriteLine($"N!= {main(Number)}");


// C# program to compute
// factorial of big numbers
using System;

// This function finds factorial
// of large numbers and prints them
static void factorial(int n)
{
    int[] res = new int[500];

    // Initialize result
    res[0] = 1;
    int res_size = 1;

    // Apply simple factorial formula
    // n! = 1 * 2 * 3 * 4...*n
    for (int x = 2; x <= n; x++)
        res_size = multiply(x, res,
                            res_size);

    Console.WriteLine("Factorial of " +
                   "given number is ");
    for (int i = res_size - 1; i >= 0; i--)
        Console.Write(res[i]);
}

// This function multiplies x
// with the number represented
// by res[]. res_size is size
// of res[] or number of digits
// in the number represented by
// res[]. This function uses
// simple school mathematics for
// multiplication. This function
// may value of res_size and
// returns the new value of res_size
static int multiply(int x, int[] res, int res_size)
{
    int carry = 0; // Initialize carry

    // One by one multiply n with
    // individual digits of res[]
    for (int i = 0; i < res_size; i++)
    {
        int prod = res[i] * x + carry;
        res[i] = prod % 10; // Store last digit of
                            // 'prod' in res[]
        carry = prod / 10; // Put rest in carry
    }

    // Put carry in res and
    // increase result size
    while (carry != 0)
    {
        res[res_size] = carry % 10;
        carry = carry / 10;
        res_size++;
    }
    return res_size;
}
Console.Write("Enter number:");
int Number = Convert.ToInt32(Console.ReadLine());
factorial(Number);

//Максимум = 253!

// Convert.ToString(factN(n)).("");
// resnumb[j] = System.Convert.ToString (res[i]);