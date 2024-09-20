namespace _5M03konObliczanieCzestosciLiter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string lorem2 = lorem.ToLower();
            Console.WriteLine("rzutowanie char<->int");
            Console.WriteLine((int)'a');
            Console.WriteLine((char)100);

            int[] litery = new int[128];
            //tablica na 128 znaków ASCII, w niej sa litery
            for (int i = 0; i < 128; i++) 
                litery[i] = 0;
            for(int i = 0; i < lorem2.Length; i++)
            {
                char c = lorem2[i];
                litery[(int)c]++;
            }

            for (int i = (int)'a'; i <= (int)'z'; i++)
                Console.WriteLine($"{(char)i}: {litery[i]}");
                 


        }
    }
}
