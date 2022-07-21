namespace Lesson_32_Exception_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Result = " + Divide(10));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You divide by 0 value!!!" + e.Message);
            }
            catch (Exception e) //deklaracja klasy utworzenie nowego obiektuby uzyskac informacje o wyjatku 
            {
                Console.WriteLine("Ou something is wrong!" + e.Message);
            }
            finally
            {
                Console.WriteLine("I will clean anyway ");
            }
            Console.ReadKey();

            
        }

        //tworzenie metody
       public static float Divide(int a)
        {
            if(a == 5)
            {
                throw new Exception(" Never divide by 5!");
            }
            else
            {
                return 10 / a;
            }   
        }
    }
}