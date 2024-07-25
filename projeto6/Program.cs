//estrutura condicional composta

int horas;//defini uma variavel horas

Console.WriteLine("Que horas são?");//perguntei ao usuario
horas = int.Parse (Console.ReadLine());//solicitei que ele digite um valor

if (horas < 12){// informei a primeira condição caso seja verdadeira sera executado o comando dentro dela 
    Console.WriteLine("Bom dia!");
    } 
else{//caso a primeira condição seja falta o bloco executado sera o else e exibira o comando armazenado dentro dele 
    Console.WriteLine("Boa tarde!");
}

Console.ReadLine();