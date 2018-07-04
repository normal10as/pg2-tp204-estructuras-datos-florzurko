Module _4_8
    Sub main()
        'Elaborar un algoritmo que cargue programáticamente nombre de países
        '   y su dominio de país en una Hashtable y permita realizar
        '   consultas por el nombre de dominio
        'se introduce el nombre del dominio y se deberá mostrar el nombre
        '       del país
        ' Informar si la clave no existe con un mensaje.
        'Salir cuando el valor ingresado es vacío.
        Dim paises As New Hashtable
        paises.Add("arg", "Argentina")
        paises.Add("rus", "Rusia")
        paises.Add("py", "Paraguay")
        paises.Add("uru", "Uruguay")
        Dim dominio As String
        Do
            Console.WriteLine("Ingrese el nombre de dominio: ")
            dominio = Console.ReadLine
            If paises.ContainsKey(dominio) = True Then
                Console.WriteLine("El Pais es :" & paises.Item(dominio))
            Else
                Console.WriteLine("ERROR. El dominio no existe. Ingrese de nuevo")
            End If
        Loop Until dominio = Nothing


    End Sub
End Module
