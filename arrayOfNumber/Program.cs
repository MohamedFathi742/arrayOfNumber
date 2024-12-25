namespace arrayOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                // welcome to user
                Console.WriteLine("Welcome To  Array Of Number APP");
                //ask user enter size of array
                Console.WriteLine("Please Enter Size Of Array ");
                //read
                byte sizeArr = 0;
                bool isConverted = byte.TryParse(Console.ReadLine(), out sizeArr);
                if (!isConverted) { Console.WriteLine("please enter valid number"); return; }
                else
                {
                    //array
                    int[] numberArr = new int[sizeArr];


                    for (int i = 0; i < sizeArr; i++)
                    {
                        Console.WriteLine($"please enter index {(int)(i + 1)}");
                        byte index = 0;
                        bool isConvertedd = byte.TryParse(Console.ReadLine(), out index);
                        if (!isConverted) { Console.WriteLine("please enter valid number"); return; }
                        numberArr[i] = index;
                    }
                    //get max number
                    int maxNum = 0;
                    int minNum = numberArr[0];
                    int sum = 0;
                    int avg = 0;
                    for (int i = 0; i < sizeArr; i++)
                    {
                        if (numberArr[i] > maxNum)
                        {
                            maxNum = numberArr[i];
                        }
                        if (numberArr[i] < minNum)
                        {
                            minNum = numberArr[i];
                        }

                        sum += numberArr[i];
                        avg = sum / sizeArr;
                    }
                    Console.WriteLine("-------------");

                    Console.WriteLine($"max number\n{maxNum}");

                    Console.WriteLine("-------------");

                    Console.WriteLine($"min number\n{minNum}");

                    Console.WriteLine("-------------");

                    Console.WriteLine($"sum number \n{sum}");

                    Console.WriteLine("-------------");

                    Console.WriteLine($"avg number \n{avg}");

                }
            }
        }
    }

