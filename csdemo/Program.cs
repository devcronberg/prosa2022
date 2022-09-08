try
{
    System.Console.WriteLine("Indtast tal");
    string input = Console.ReadLine();
    int tal = Convert.ToInt32(input);
    tal++;
    System.Console.WriteLine(tal);

}
catch (System.Exception ex)
{
    System.Console.WriteLine("Der er sket en fejl");
    System.Console.WriteLine(ex.Message);
}



return;
Tæl(5);
System.Console.WriteLine("*");
Tæl(2);

void Tæl(int tælTil)
{
    int i = 1;
    do
    {

        if (i % 2 == 0)
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
        }


        System.Console.WriteLine(i);
        i++;
    } while (i < tælTil);

}