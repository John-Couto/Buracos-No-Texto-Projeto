internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Se você pensar em um papel como um plano e uma letra como uma marcação neste plano, então estas letras dividem o plano em regiões. Por exemplo, as letras A, D e O dividem o plano em 2 pois possuem um espaço confinado em seu desenho, ou um “buraco”. Outras letras como B possuem 2 buracos e letras como C e E não possuem buracos.");
        Console.WriteLine("Escreva o texto que desejar, e eu direi para você quantos ''buracos'' há no texto");
        Console.WriteLine("Digite o texto desejado:");
        var texto = Console.ReadLine();
        int total = 0;
        var umBuraco = "AabDdegOoPpQqR";
        var doisBuracos = "B";
        foreach (var C in texto.ToArray())
        {
            if (umBuraco.Contains(C))
                total++;
            else if (doisBuracos.Contains(C))
                total += 2;
            // if (C == 'a')
            //     total++;
            // else if (C == 'b')
            //     total++;
            // switch (C)
            // {
            //     case 'a':
            //     case 'b':
            //     case 'd':
            //     case 'o': total++; break;
            //     case 'B': total += 2; break;
            // }
        }
        Console.WriteLine(total);
    }

}