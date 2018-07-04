Module _4_4
    Sub main()
        'Elaborar un algoritmo que cargue programáticamente
        'nombre de países y su dominio de país en una Collection.
        'A continuación, debe permitir realizar consultas: se 
        'introduce el nombre del dominio y se deberá mostrar 
        'el nombre del país. Salir cuando el valor ingresado es
        'vacío.
        Dim paises As New Collection
        Dim buscar As String
        paises.Add("Argentina", "arg")
        paises.Add("Rusia", "rus")
        paises.Add("Paraguay", "py")
        paises.Add("Uruguay", "uru")
        Do
            Console.WriteLine("Ingrese el nombre del Dominio del Pais: ")
            buscar = Console.ReadLine
            If paises.Contains(buscar) = True Then
                Console.WriteLine("El Pais es: " & paises.Item(buscar))
            Else
                Console.WriteLine("El Codigo es Incorrecto. Ingrese de nuevo")
            End If
        Loop Until buscar = Nothing
    End Sub
End Module
