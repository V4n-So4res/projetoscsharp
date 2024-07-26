using System.Globalization;

double n1, n2, notaFinal;

n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

notaFinal = n1 + n2;

if (notaFinal >= 60){
    Console.WriteLine("Você foi aprovado");
} 
else{
    Console.WriteLine("Você foi reprovado");
}

Console.WriteLine("NOTA FINAL = " + notaFinal.ToString('F1', CultureInfo.InvariantCulture));

Console.ReadLine();


