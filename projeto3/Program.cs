using System.Globalization;

string nome1, nome2;// declaramos a variavel nome
int id1, id2;// declaramos as variaveis inteiras
double iMedia;// variavel flutuante

string[] pessoas;// criamos um vetor 

pessoas = Console.ReadLine().Split(' ');// leitura de mais um dado na mesma linha 
nome1  = pessoas[0];
id1 = int.Parse(pessoas[1]);

pessoas = Console.ReadLine().Split(' ');// leitura de mais um dado na mesma linha 
nome2  = pessoas[0];
id2 = int.Parse(pessoas[1]);

iMedia = (double) (id1 + id2) / 2.0;// tivemos que adicionar a informação double pra realizar o casting e transformar em número flutuante 

Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + iMedia.ToString("F1", CultureInfo.InvariantCulture) + " anos.");

Console.ReadLine();


