using System.Globalization;

string nomeVendedor;
double salarioFixo, vendasEfetuadasMes, salarioTotal;

nomeVendedor =  Console.ReadLine();
salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
vendasEfetuadasMes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

salarioTotal = vendasEfetuadasMes * 15.0 /100 + salarioFixo;// aqui fazemos o calculo de 15% do valor das vendas efetuadas no mes mais o salario do funcionario 

Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));

Console.ReadLine();

