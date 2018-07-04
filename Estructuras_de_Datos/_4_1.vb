Module _4_1
    Sub Main()
        '- Elaborar un algoritmo que permita cargar 5 números en un 
        'arreglo de 5 elementos
        '- Calcular la media y luego imprimir cada elemento del 
        'arreglo y la desviación que tiene respecto a la media.
        'La Media se obtiene la sumatoria de los todos elementos 
        'del arreglo y se divide por la cantidad de los mismos. 
        'La DESVIACION de cada elemento se obtiene restándole al 
        'elemento la Media.
        Dim valores(4) As Integer
        Dim suma As Integer = 0
        Dim Media As Integer = 0
        Dim desviacion As Integer = 0
        Dim resta As Integer = 0
        Console.WriteLine("Ingrese el primer numero: ")
        valores(0) = Console.ReadLine
        Console.WriteLine("Ingrese el segundo numero: ")
        valores(1) = Console.ReadLine
        Console.WriteLine("Ingrese el tercer numero: ")
        valores(2) = Console.ReadLine
        Console.WriteLine("Ingrese el cuarto numero: ")
        valores(3) = Console.ReadLine
        Console.WriteLine("Ingrese el quinto numero: ")
        valores(4) = Console.ReadLine
        For x = 0 To valores.Length - 1
            suma += valores(x)
            Media = suma / 5
            resta -= valores(x)
        Next
        Console.WriteLine("Los numeros ingresados son: ")
        Console.WriteLine(valores(0) & ", " & valores(1) & ", " & valores(2) & ", " & valores(3) & ", " & valores(4))
        Console.WriteLine("La Media de los numeros es: " & Media)
        Console.WriteLine("La Desviacion es: " & resta)
        Console.ReadKey()
    End Sub
End Module
