Module _4_14


    'Crear un algoritmo para administrar una lista de precios de bebidas:
    'se conoce el nombre del artículo, código y precio.
    'El algoritmo debe agregar, editar, y borrar utilizando el código como clave.
    'Antes de agregar verificar que el código no exista y antes de editar o 
    'borrar verificar que exista.
    'También disponer una opción que liste los artículos ordenados por su nombre
    Enum opciones
            agregar = 1
            editar = 2
            borrar = 3
            listar = 4
        End Enum
    Sub main()

        Dim codigo_articulo As New Dictionary(Of UInteger, String)
        Dim codigo_precio As New Dictionary(Of UInteger, Single)
        Dim opcion As Byte


        codigo_articulo.Add(123, "Papa")
        codigo_articulo.Add(456, "Harina")
        codigo_articulo.Add(789, "Pera")
        codigo_articulo.Add(369, "Pan")
        codigo_precio.Add(123, 15)
        codigo_precio.Add(456, 40)
        codigo_precio.Add(789, 25)
        codigo_precio.Add(369, 12)
        Do
            Console.WriteLine("#----------------------------- OPCIONES ------------------------------#")
            Console.WriteLine("#  1 = AGREGAR" & vbTab & "2 = EDITAR" & vbTab & "3 = BORRAR" & vbTab & "4 = LISTAR ARTICULOS")
            opcion = Console.ReadLine
            Select Case opcion
                Case opciones.agregar
                    agregar(codigo_articulo, codigo_precio)
                Case opciones.editar
                    editar(codigo_articulo, codigo_precio)
                Case opciones.borrar
                    borrar(codigo_articulo, codigo_precio)
                Case opciones.listar
                    listar(codigo_articulo, codigo_precio)
                Case 0
                    Exit Do
            End Select
        Loop
    End Sub
    Private Sub listar(ByRef codigo_articulo As Dictionary(Of UInteger, String), ByRef codigo_precio As Dictionary(Of UInteger, Single))
        Dim ordenar As New ArrayList
        For Each articulo In codigo_articulo
            ordenar.Add(articulo.Value)
        Next
        ordenar.Sort()
        Console.WriteLine("--------------------------------------")
        Console.WriteLine(vbTab & "CODIGO" & vbTab & vbTab & "ARTICULO" & vbTab & "PRECIO")
        For I As Byte = 0 To ordenar.Count - 1
            For Each articulo In codigo_articulo
                If articulo.Value = (ordenar(I).ToString) Then
                    Console.WriteLine(vbTab & articulo.Key & vbTab & vbTab & articulo.Value & vbTab & vbTab & codigo_precio(articulo.Key))
                End If
            Next
        Next
    End Sub
    Private Sub borrar(ByRef codigo_articulo As Dictionary(Of UInteger, String), ByRef codigo_precio As Dictionary(Of UInteger, Single))
        Dim codigo As UInteger
        Dim valor As Boolean = True
        Do
            Console.WriteLine("BORRAR: ")
            Console.WriteLine("CODIGO: ")
            codigo = Console.ReadLine
            If codigo_articulo.ContainsKey(codigo) And codigo_precio.ContainsKey(codigo) Then
                codigo_articulo.Remove(codigo)
                codigo_precio.Remove(codigo)
                Console.WriteLine("CODIGO BORRADO")
            Else
                Console.WriteLine("El codigo NO Existe. Ingrese de nuevo")
                valor = False
            End If
        Loop While valor = False
    End Sub
        Private Sub agregar(ByRef codigo_articulo As Dictionary(Of UInteger, String), ByRef codigo_precio As Dictionary(Of UInteger, Single))
            Dim articulo As String
            Dim precio As Single
            Dim codigo As UInteger
        Dim valor As Boolean = True
        Do
            Console.WriteLine("POR FAVOR, INGRESE: ")
            Console.WriteLine("CODIGO: ")
            codigo = Console.ReadLine
            If codigo_articulo.ContainsKey(codigo) And codigo_precio.ContainsKey(codigo) Then
                Console.WriteLine("EL CODIGO YA EXISTE")
            Else
                valor = False
            End If
        Loop While valor = True
        Console.WriteLine("NOMBRE DEL ARTICULO: ")
            articulo = Console.ReadLine
            Console.WriteLine("PRECIO: ")
            precio = Console.ReadLine
            valor = False
            codigo_articulo.Add(codigo, articulo)
            codigo_precio.Add(codigo, precio)
            Console.WriteLine("PRODUCTO AGREGADO")
        End Sub
    Private Sub editar(ByRef codigo_articulo As Dictionary(Of UInteger, String), ByRef codigo_precio As Dictionary(Of UInteger, Single))
        Dim codigo As UInteger
        Dim articulo As String
        Dim precio As Single
        Dim valor As Boolean = True
        Do
            Console.WriteLine("INGRESE EL CODIGO A EDITAR: ")
            codigo = Console.ReadLine
            If codigo_articulo.ContainsKey(codigo) And codigo_precio.ContainsKey(codigo) Then
                Console.WriteLine(" NUEVO CODIGO : ")
                codigo = Console.ReadLine
                Console.WriteLine("NUEVO NOMBRE DEL ARTICULO: ")
                articulo = Console.ReadLine
                Console.WriteLine("NUEVO PRECIO: ")
                precio = Console.ReadLine
                valor = False
                codigo_articulo.Remove(codigo)
                codigo_precio.Remove(codigo)
                codigo_articulo.Add(codigo, articulo)
                codigo_precio.Add(codigo, precio)
            Else
                Console.WriteLine("EL CODIGO NO EXISTE")
                valor = False
            End If
        Loop While valor = True

    End Sub
End Module
