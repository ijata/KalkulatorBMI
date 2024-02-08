// See https://aka.ms/new-console-template for more information
double waga;
double wzrost;
double bmi;
string wynik = "";

Console.WriteLine("Kalkulator BMI \n");
Console.ReadKey();

Console.Write("Podaj wagę w kg:");
string userwaga = Console.ReadLine();

Console.Write("Podaj wyskokość w metrach:");
string userwzrost = Console.ReadLine();

if(double.TryParse(userwaga, out waga))
{
    if(double.TryParse(userwzrost, out wzrost))
    {
        bmi = Math.Round((waga / (wzrost * wzrost)),2);
        Console.Write(bmi);

        if (bmi < 18.5)
        {
            wynik = "niedowaga";
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            wynik = "normalna waga";
        }
        else if (bmi >= 24.9 && bmi < 29.9)
        {
            wynik = "nadwaga";
        }
        else if (bmi >= 29.9 && bmi < 34.9)
        {
            wynik = "otyłość";
        }
        else
        {
            wynik = "otyłość olbrzymia";
        }

        Console.WriteLine(" => " + wynik);
    }
    else {
        Console.WriteLine("nieprawidłowa wartość dla parametru wzrost");
    }
}
else
{
    Console.WriteLine("nieprawidłowa wartość dla parametru waga");
}