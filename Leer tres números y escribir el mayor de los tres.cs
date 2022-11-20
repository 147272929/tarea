/*  nombre: ramonjvd3A  */
class Program
{
    static void Main (string[] args)
    {
        int n1, n2, n3;
        Console.WriteLine("añada un numero:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("añada un numero:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("añada un numero:");
        n3 = int.Parse(Console.ReadLine());

        int mayor , menor ;

        mayor = n1;

        if (mayor <n2 ) mayor =n2;
        if (mayor < n3) mayor = n3;

        menor = n1;

        if (menor >n2 ) menor = n2;
        if (menor >n3 ) menor = n3;

        Console.WriteLine("el mayor de los tres numeros es:" + mayor);
        Console.WriteLine("el menor de los tres numeros es : " + menor );

        Console.ReadLine();
    }
}