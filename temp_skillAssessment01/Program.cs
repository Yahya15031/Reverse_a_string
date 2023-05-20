namespace temp_skillAssessment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string_ = "Hello World";
            string resultantString=ReversedString(string_);
            Console.WriteLine(resultantString);
          
            Console.ReadKey();
        }
        static char[] stringToArray(string string_)

        {
            char[] arr = new char[string_.Length];
            for (int i = 0; i < string_.Length; i++)
            {
                arr[i] = string_[i];

            }

            return arr;
        }
        static string ReversedString( string string_)
        {
            char[] arr= new char[string_.Length];
            arr= stringToArray(string_);
            string resultant ="";

            for (int i = arr.Length-1; i >= 0; i--)
            {
                resultant+=arr[i]; 
            }


            return resultant;
        }

    }
}