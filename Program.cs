namespace allWon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bemenet
            int count;

            //Kimenet
            int allWon;

            //Ellenorzeshez
            string inputText;
            bool error;

            //Beolvasas
            do
            {
                Console.WriteLine("hanyszor jatszott? nyilvan nem lehet negativszor csinalni semmit");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out count) && count < 0;
                if (error)
                {
                    Console.WriteLine("hogy mennyi, az szam es negativszor nem tudsz jatszani. ujra");
                }
            }while (error);
            

            //tomb deklaralas
            int[] won = new int[count + 1];
            for (int i = 1; i <= count; i++)
            {
                do
                {
                    Console.WriteLine("nyeremenyek(nyilvan szam): ");
                    inputText = Console.ReadLine();
                    error = !int.TryParse (inputText, out won[i]);
                    if (error)
                    {
                        Console.WriteLine("ennyit szerinted lehet nyerni? ujra");
                    }
                } while (error);
            }

            //feldolgozas
            allWon = 0;

            for (int i = 1;i <= count; i++)
            {
                if (won[i] > 0)
                {
                    allWon += won[i];
                }
            }

            //kiir
            Console.WriteLine("ennyit nyert ez a szerencsetlen nyomorek fuggo: \n{0}", allWon);
        }
    }
}