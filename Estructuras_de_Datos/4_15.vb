Module _4_15
    Sub main()
        'Crear un algoritmo para dar turnos a clientes de un local de ventas varias
        'donde los clientes ancianos y embarazadas tienen prioridad 
        '(Son atendidos tan pronto un empleado esté disponible):
        ' Cuando los compradores ingresan al local dan su nombre y quedan esperando 
        'ser llamados por un empleado. 
        'Si tienen prioridad pasan al tope de la lista excepto que en el tope ya
        'exista alguien con prioridad en cuyo caso quedan en lugar del primer cliente
        'que no tenga prioridad.
        ' Un empleado llama al próximo cliente para ser atendido el programa muestra
        'su nombre y este sale de la lista
        'Tener en cuenta que estos procesos pueden ser en cualquier orden.
        'En todo momento informar la cantidad de clientes en espera y el nombre 
        'del siguiente cliente a ser atendido. Si no hay compradores en espera
        'informar “Sin clientes”.
        ' Utilizar Linkedlist.
        Dim clientes As New LinkedList(Of String)
        Dim nombre As String
        Dim opcion As Byte
        Dim prioridad As Byte
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
                Console.WriteLine("EL CLIENTE TIENE PRIORIDAD")
                Console.WriteLine("1 = SI 2 = NO")
                prioridad = Console.ReadLine
                If prioridad = 1 Then
                    Console.WriteLine("#     Ingrese el nombre del cliente: ")
                    nombre = Console.ReadLine
                    clientes.AddAfter(prioridad, nombre)

                End If


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
