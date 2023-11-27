﻿// A fórmula de Bhaskara é um método resolutivo para equações do segundo grau.
// Essa fórmula é um método para encontrar as raízes reais de uma equação de segundo grau fazendo uso apenas de seus coeficientes

double a, b, c, delta, x1, x2;

// console informa a frase
Console.WriteLine("... Equação do segundo grau ...");

//console pede para usuario digitar o valor de a e converte em numero
Console.Write(" Digite o valor de (a): "); 
a = Convert.ToDouble(Console.ReadLine());  


Console.Write(" Digite o valor de (b): "); 
b = Convert.ToDouble(Console.ReadLine()); 


Console.Write(" Digite o valor de (c): "); 
c = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine();


if (a == 0)
{   //se a = 0 informar que não é equação de segundo grau
    Console.ForegroundColor = ConsoleColor.Red; //altera coloração da letra para vermelho
    Console.WriteLine("Não é uma equação de segundo grau!");
    Console.ResetColor(); //reseta cor original

}
else
{
    //caso valido executar a formula
    delta = b * b - 4 * a * c;

    //se delta menor que zero informar que não possui raizes reais
    if (delta < 0)
    {
        
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine($"...Resultado...\n Como delta = {delta:N2}, a equação não possui raízes reais!"); 
        Console.ResetColor(); //reseta cor original
}
    
    else
    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a); 
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.ForegroundColor = ConsoleColor.Green; //altera coloração da letra para verde
        Console.WriteLine($"...Resultado...\n x1 = {x1:N2}\n x2 = {x2:N2}"); //mostra o resultado na tela
        Console.ResetColor(); //reseta cor original
    }
}