/*Leia um valor inteiro, queé o tempo de duração em segundos de um determinado evento em uma fábrica e informe-o expresso no formato hora minutos e segundos.

Entrada 

O arquivo de entrada contém um valor inteiro N.

Saída 

Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas: minutos: segundos, conforme exemplo fornecido.*/ 

int N, horas, resto, minutos, segundos; // declarei as variaveis 

N = int.Parse(Console.ReadLine());// solicitei que o usuario digite um valor

horas = N / 3600;// divisao do valor digitado pelo usuario pela quantidade de horas que transformadas em segundos é equivalente a 3.600
resto = N % 3600;// o resto da divisao do valor de N por 3.600 vai ficar armazenado nessa variavel 

minutos = resto / 60;// minutos recebe o resto da divisao das horas divido por 60 segundos para apresentar os minutos 
segundos = resto % 60;// e segundos recebe o resto da divisão mod (%) 60 que mostrara os segundos 

Console.WriteLine(horas + ":" + minutos + ":" + segundos);
Console.ReadLine(); 