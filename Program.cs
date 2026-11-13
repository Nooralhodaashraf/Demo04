using System.Diagnostics;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //Console.WriteLine(x);
            //long bigX = x;
            //Console.WriteLine(bigX);
            //bigX = 10000000000;
            //Console.WriteLine(bigX);
            //implicite casting => small data type to big data type EX: int => long , float => double


            //eceplicte casting => data loss && not save 
            //checked
            //{
            //long bigY = 10000000000;
            //int y = (int)bigY; //=> it's not save to be converted 
            //Console.WriteLine(y); //console execption 

            //}

            //data = value ===reinial. = new value 
            //const = constant ==== value 

            //const int discount = 10;
            //  int newdis = discount;
            //  newdis = 20;

            //Console.WriteLine(x.ToString()); //write => string
            //student student01 = new student();
            //Console.WriteLine(student01); // toString => inside console 

            int x = 10;
            int y = 20;
            //data type (Value Type) value == value 
            //Console.WriteLine(x.Equals(y));//false - true 

            //space heap => ADD. inside stack 


            student std01 = new student();
            student std02 = new student();
            student std03 = std01;
            //Console.WriteLine("std 01 :" + std01);
            //Console.WriteLine("std 02 :" + std02);
            //Console.WriteLine(std01.Equals(std02));//false
            //Console.WriteLine("=====================================");//false - true 

            //Console.WriteLine(std01.Equals(std03));// true 

            ////GetHashCode

            //Console.WriteLine(std01.GetHashCode());
            //Console.WriteLine(std02.GetHashCode());

            //GetType()
            //Console.WriteLine(x.GetType());
            //Console.WriteLine(std01.GetType());

            //=> type? Api ,,,, inpute

            //controll statements : controll code flow
            //Conditional statements;
            //looping statement 
            //jump statements 



            //statement based on a condition (condition => true => false)

            //if condition


            //if ledder 
            //if (grade >= 90) //true
            //{
            //    Console.WriteLine("A");
            //}else if(grade >= 80)
            //{
            //    Console.WriteLine("B");

            //}
            //else if (grade >= 70)
            //{
            //    Console.WriteLine("C");

            //}
            //else if (grade >= 60)
            //{
            //    Console.WriteLine("D");

            //}
            //else //false
            //{
            //    Console.WriteLine("fail");

            //}


            int grade = 55;
            string className = "class A";
            //nested if
            if(grade > 60)
            {
                Console.WriteLine("pass");
                if(className== "class A") {
                    Console.WriteLine("your in class a ");

                }else
                {
                    Console.WriteLine("class a is not your class");

                }
            }
            else
            {
                Console.WriteLine("try again");

            }


            //operators ==     equal
            //>=   greater than or equal
            // =<    lesser than or equal 
            //!=
            //<    > 

            //(grade > 60 && className = "class A")
            //logical operators 
            // && And => true only when all are true 
            // || or => true if at least one is true 
            // ! => true = false, false= true 





        }

        public static void print( object value)
        {
            Console.WriteLine(value);
            //inhertance => object is the base root of all data types in C#
            //4 methods
        }

        //=> base root of all data types in C# is object
        //class => object 
        //int => object 
        //string => object
        //char => object
        //parent class => object
    }
}
