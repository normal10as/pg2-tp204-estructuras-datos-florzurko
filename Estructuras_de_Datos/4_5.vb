Module _4_5
    Sub main()
        ' Al ejercicio anterior agregarle las funcionalidades que permita 
        ' agregar, editar, eliminar y mostrar el nombre de país y su dominio.
        'También informar la cantidad de países cargados.
        Dim paises As New Collection
        Dim opcion As Byte
        paises.Add("Argentina", "arg")
        paises.Add("Rusia", "rus")
        paises.Add("Paraguay", "py")
        paises.Add("Uruguay", "uru")
        Do
            Console.WriteLine(vbTab & vbTab & vbTab & vbTab & "HAY " & paises.Count & " PAISES")
            Console.WriteLine("   #------------------------------------------------------------------------#")
            Console.WriteLine(vbTab & vbTab & vbTab & vbTab & "Que desea hacer:     ")
            Console.WriteLine(" ")
            Console.WriteLine("   " & "1 = AGREGAR" & vbTab & "2 = EDITAR" & vbTab & "3 = ELIMINAR" & vbTab & "4 = BUSCAR" & vbTab & "0 = SALIR")
            opcion = Console.ReadLine
            Select Case opcion
                Case 0
                    Exit Do
                Case 1
                    agregar(paises)
                Case 2
                    editar(paises)
                Case 3
                    eliminar(paises)
                Case 4
                    buscar(paises)
                Case Else
                    Console.WriteLine("Error. Opcion incorrecta")
            End Select
        Loop Until opcion = 0
    End Sub

    Private Sub buscar(ByRef paises As Collection)
        Dim codigo As String
        Dim condicion As Boolean
        Do
            Console.WriteLine("   #------------------------------------------------------------------------#")
            Console.WriteLine("     Ingrese el Codigo del Pais a Buscar:    ")
            codigo = Console.ReadLine
            If paises.Contains(codigo) Then
                Console.WriteLine("     El Pais es: " & paises.Item(codigo))
                condicion = True
            Else
                Console.WriteLine("     El Codigo es Incorrecto. Ingrese de nuevo")
                condicion = False
            End If
        Loop While condicion = False
    End Sub

    Private Sub agregar(ByRef paises As Collection)
        Dim nombre, codigo As String
        Dim condicion As Boolean
        Do
            Console.WriteLine("   #------------------------------------------------------------------------#")
            Console.WriteLine("     Ingrese el Codigo del Pais a Agregar:  ")
            codigo = Console.ReadLine
            If paises.Contains(codigo) Then
                Console.WriteLine("     El codigo ya existe. Ingrese de nuevo")
                condicion = False
            Else
                Console.WriteLine("     Ingrese el Nombre del Pais: ")
                nombre = Console.ReadLine
                paises.Add(nombre, codigo)
                Console.WriteLine("     Se ha agregado el Pais")
                condicion = True
            End If
        Loop While condicion = False
    End Sub

    Private Sub editar(ByRef paises As Collection)
        Dim codigo, nombre As String
        Dim condicion As Boolean
        Do
            Console.WriteLine("   #------------------------------------------------------------------------#")
            Console.WriteLine("     Ingrese el Codigo del Pais a Editar: ")
            codigo = Console.ReadLine
            If paises.Contains(codigo) Then
                paises.Remove(codigo)
                Console.WriteLine("     Ingrese el nuevo Codigo del Pais: ")
                codigo = Console.ReadLine
                Console.WriteLine("     Ingrese el Nuevo Nombre del Pais: ")
                nombre = Console.ReadLine
                paises.Add(nombre, codigo)
                Console.WriteLine("     Se ha editado el Pais")
                condicion = True
            Else
                Console.WriteLine("     El codigo no existe. Ingrese de nuevo")
                condicion = False
            End If
        Loop While condicion = False
    End Sub

    Private Sub eliminar(ByRef paises As Collection)
        Dim codigo As String
        Dim condicion As Boolean
        Do
            Console.WriteLine("   #------------------------------------------------------------------------#")
            Console.WriteLine("     Ingrese el Codigo del Pais a Eliminar: ")
            codigo = Console.ReadLine
            If paises.Contains(codigo) Then
                paises.Remove(codigo)
                Console.WriteLine("     El Pais se ha Eliminado")
                condicion = True
            Else
                Console.WriteLine("     El codigo no existe. Ingrese de nuevo")
                condicion = False
            End If
        Loop While condicion = False
    End Sub
End Module

