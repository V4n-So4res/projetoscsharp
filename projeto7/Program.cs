//Encadeamento de estruturas condicionais 

int horas; 

Console.WriteLine("Que horas são?");
horas = int.Parse(Console.ReadLine());

if(horas < 12){
    Console.WriteLine("Bom dia");
}
else if (horas < 18) {
        Console.WriteLine("Boa tarde");
    }
    else {
        Console.WriteLine("Boa noite");
   }

Console.ReadLine();