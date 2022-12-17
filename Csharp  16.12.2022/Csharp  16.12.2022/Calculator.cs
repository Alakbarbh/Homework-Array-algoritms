
#region MyRegion





    //    {
    //        double result = 0;
    //        double sum = 0;
    //        double multi = 0;
    //        double division = 0;
    //        public void Calculation(int n,string operation, int m)

    //        {
    //            int result = n - m;
    //            Console.WriteLine(result);

    //            int sum = n + m;
    //            Console.WriteLine(sum);

    //            int multi = n * m;
    //            Console.WriteLine(multi);


    //            if (m==0)
    //            {
    //                Console.WriteLine("0 a bolmek olmur");
    //                return;
    //            }
    //            else
    //            {
    //                division = n / m;
    //            }
    //            Console.WriteLine(division);
    //        }


    //    }
    //}
    #endregion



    public class Calculator
    {
    public void Calculation()
    {
        float result = 0;

       
        Console.WriteLine("Enter first number");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator");
        string op = Console.ReadLine();

        switch (op)
        {

            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
           

        }
        Console.WriteLine("Result = " + result);


    }
}


    

