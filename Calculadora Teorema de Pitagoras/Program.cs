using System;
class Program
{

    static void Main(string[] args)
    {
        double catetoA,catetoA2,catetoB,catetoB2,hipotenusa2, hipotenusa;
        Console.WriteLine("Calculadora do Teorema de Pitágoras");
        Console.WriteLine("Digite o valor do cateto A:");
        catetoA = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do cateto B:");
        catetoB = double.Parse(Console.ReadLine());
        catetoA2 = Math.Pow(catetoA, 2);
        catetoB2 = Math.Pow(catetoB, 2);
        hipotenusa2 = catetoA2+catetoB2;
        hipotenusa = Math.Sqrt(hipotenusa2);
        Console.Write("A hipotenusa é: ");
        Console.Write(hipotenusa);
        Console.ReadLine();
    }
}
