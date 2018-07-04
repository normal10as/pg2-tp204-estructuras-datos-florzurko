Module _4_10
    Sub main()
        ' Crear un algoritmo que tenga una colección de stack de manera tal
        'que pueda ser accedida en todo el módulo. 
        'Con un menú permite efectuar 2 acciones: ingresar nombres a la colección desde
        'teclado y la segunda permita extraerlo y mostrarlo en la pantalla. 
        'El programa debe finalizar cuando se quitan todos los elementos de la colección.
        Dim elemento As New Stack
        Dim nombre As String
        Dim opcion As Byte
        Do
            Console.WriteLine("OPCIONES:" & vbTab & "1 - AGREGAR" & vbTab & "2 - EXTRAER Y MOSTRAR ")
            opcion = Console.ReadLine
            If opcion = 1 Then
                Console.WriteLine("Ingrese el nombre: ")
                nombre = Console.ReadLine
                elemento.Push(nombre)
                Console.WriteLine("Nombre agregado")
            ElseIf opcion = 2 Then
                Console.WriteLine("Se eliminara el nombre: {0}", elemento.Pop)
                Console.WriteLine("Elemento Eliminado")
            Else
                Console.WriteLine("Error. Opcion Incorrecta")
            End If
        Loop Until elemento.Count = 0
        Console.WriteLine("---------- NO HAY MAS NOMBRES")
        Console.ReadKey()
        Exit Sub
    End Sub
End Module
