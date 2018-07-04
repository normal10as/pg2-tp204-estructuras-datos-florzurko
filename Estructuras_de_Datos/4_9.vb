Module _4_9
    Sub main()
        ' Crear un programa para dar tunos a los compradores de una tienda por orden 
        'de llegada.
        'Cuando los compradores ingresan al local dan su nombre y quedan esperando 
        'ser llamados por un empleado.
        ' Un empleado llama al próximo cliente para ser atendido el programa muestra
        'su nombre y este sale de la lista
        ' Tener en cuenta que estos procesos pueden ser en cualquier orden.
        ' En todo momento informar la cantidad de clientes en espera y el nombre de 
        'los dos siguientes clientes a ser atendidos. 
        'Si no hay compradores en espera  informar “Sin clientes”.
        Dim clientes As New Queue
        Dim nombre As String
        Dim opcion As Byte
        Do
            If clientes.Count = 0 Then
                Console.WriteLine("#--------------- SIN CLIENTES ---------------#")
            Else
                Console.WriteLine("#----------- NUMERO DE CLIENTES: " & clientes.Count & "------------#")
            End If
            Console.WriteLine("#----------------- OPCIONES ------------------#")
            Console.WriteLine("     1 = AGREGAR" & vbTab & "2 = LLAMAR ")
            opcion = Console.ReadLine
            If opcion = 1 Then
                Console.WriteLine("#     Ingrese el nombre del cliente: ")
                nombre = Console.ReadLine
                clientes.Enqueue(nombre)
                Console.WriteLine(vbCrLf & "#    Por favor espere. En breve sera atendida." & vbCrLf)
            ElseIf opcion = 2 Then
                Console.WriteLine("#    TURNO AL CLIENTE: " & clientes.Dequeue & vbCrLf)
            Else
                Console.WriteLine("    ERROR. OPCION INCORRECTA    !!!")
            End If
        Loop

    End Sub
End Module
