Module _4_11
    Sub main()
        'Crear un algoritmo que lea valores reales en forma consecutiva y los vaya 
        'agregando a una pila de tipo real.
        ' Si el valor ingresado es cero se quita un elemento.
        ' En todo momento informar la sumatoria total de los valores.
        Dim valores As New Stack
        Dim numeros, suma, suma2 As Single
        Do
            Console.WriteLine("     INGRESE UN NUMERO :")
            numeros = Console.ReadLine
            valores.Push(numeros)
            suma = suma + numeros
            If numeros = 0 Then
                valores.Pop()
                Console.WriteLine("    INGRESO 0. SE QUITA EL NUMERO : " & valores.Peek & vbCrLf)
                suma2 = suma - valores.Pop
                Console.WriteLine("    LA SUMA DE LOS VALORES ES: " & suma2 & vbCrLf)
            End If
            Console.WriteLine("    LA SUMA TOTAL DE LOS VALORES INGRESADOS ES: " & suma & vbCrLf)
        Loop
    End Sub
End Module
