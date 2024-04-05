using System;
//a
class Program
{
    static void Main()
    {
        double[,] compras = {
            { 200, 80, 20, 210, 190 },
            { 150, 270, 110, 400, 401 },
            { 885, 100, 130, 155, 79 },
            { 289, 180, 990, 10, 350 },
            { 70, 60, 140, 80, 110 }
        };

        calculardescuentos(compras);
    }

    static void calculardescuentos(double[,] compras)
    {
        int filas = compras.GetLength(0);
        int columnas = compras.GetLength(1);

        for (int cliente = 0; cliente < filas; cliente++)
        {
            double totalCompras = 0;

            for (int compra = 0; compra < columnas; compra++)
            {
                totalCompras += compras[cliente, compra];
            }

            double descuento = 0;

            if (totalCompras >= 100 && totalCompras <= 1000)
            {
                descuento = totalCompras * 0.10;
            }
            else if (totalCompras > 1000)
            {
                descuento = totalCompras * 0.20;
            }

            double montofinal = totalCompras - descuento;

            Console.WriteLine($"Cliente {cliente + 1}:");
            Console.WriteLine($"Total de compras: {totalCompras:C}");
            Console.WriteLine($"Descuento aplicado: {descuento:C}");
            Console.WriteLine($"Monto final: {montofinal:C}");
            Console.WriteLine();
        }
    }
}

