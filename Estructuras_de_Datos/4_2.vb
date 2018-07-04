Module _4_2
    'Se tiene tres arrays cargados programáticamente con una lista de
    'productos:
    'el primero tiene el código, 
    'el segundo el producto y
    'el tercero el precio unitario.
    'Repetitivamente se ingresa un código de producto y el 
    'programa muestra su descripción y precio, luego el usuario 
    'ingresa la cantidad con lo que el programa responde calculando 
    'el total del producto y el total general (acumulando los 
    'productos anteriores). Esto sucede hasta que el código sea cero.
    Sub main()
        Dim valor As Byte
        Dim codigo = New Integer() {1, 2, 3, 4}
        Dim producto = New String() {"Queso", "Tomate", "Pan", "Coca Cola"}
        Dim precio = New Single() {35, 25.5, 20, 45}
        Dim totgeneral As Single
        Dim cantidad As UShort
        Do
            Console.WriteLine("Ingrese el Codigo del producto:      (0 para salir)")
            valor = Console.ReadLine()
            Validar(valor, codigo.Length)
            For i = 0 To codigo.Length - 1
                If valor = codigo(i) Then
                    Console.WriteLine(" - Descripcion: " & producto(i))
                    Console.WriteLine(" - Precio: " & precio(i) & " $")
                    Console.WriteLine("Ingrese la cantidad: ")
                    cantidad = Console.ReadLine()
                    totgeneral = Total(cantidad, precio(i), totgeneral)
                End If
            Next
        Loop While (valor <> 0)
    End Sub

    Private Function Total(ByRef cantidad As Integer, ByRef precio As Decimal, ByRef tot As Decimal) As Decimal
        Console.WriteLine("Total del Producto:  $" & cantidad * precio)
        tot = tot + (cantidad * precio)
        Console.WriteLine("El total General es: $" & tot)
        Return tot
    End Function

    Private Function Validar(ByRef ing As Integer, largo_array As Integer) As Boolean
        If ing > largo_array Then
            Console.WriteLine("Error. El Codigo no existe")
            Return False
        Else
            Return True
        End If
    End Function
End Module

