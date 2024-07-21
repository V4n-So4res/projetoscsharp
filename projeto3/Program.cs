using System.Globalization;

string nome1, nome2;
int id1, id2;
double iMedia;

string[] pessoas;

pessoas = Console.ReadLine().Split(' ');
nome1  = pessoas[0];
id1 = int.Parse(pessoas[1]);

pessoas = Console.ReadLine().Split(' ');
nome2  = pessoas[0];
id2 = int.Parse(pessoas[1]);

iMedia = (double) (id1 + id2) / 2;

Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + iMedia + " anos.");

Console.ReadLine();


