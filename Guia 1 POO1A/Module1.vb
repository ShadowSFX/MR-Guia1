Module Module1

    Sub Main()

        Dim opc As Integer = 0

        Console.WriteLine("Ingrese la función a revisar: ")
        Console.WriteLine("1. Sentencias")
        Console.WriteLine("2. Tipo de datos")
        Console.WriteLine("3. Operadores")
        Console.WriteLine("4. Sintaxis")
        opc = Console.ReadLine()

        Select Case opc
            Case 1
                Console.WriteLine("Sentencias")
                Sentencias()
            Case 2
                Console.WriteLine("Tipo de datos")
                TiposDeDato()
            Case 3
                Console.WriteLine("Operadores")
                Operadores()
            Case 4
                Console.WriteLine("Sintaxis")
                SintexisVB()
            Case Else
                Console.WriteLine("opcion invalida")
        End Select


    End Sub


    Sub Sentencias()
        Dim declaracionVar As String
        declaracionVar = "Esta frase es el valor de declaracionVar."

        Console.WriteLine("Esta llamada al método Writeline del objeto consola es una sentencia ejecutable.")
        Console.WriteLine("Las sentencias de control de flujo y repetición también son sentencias ejecutables.")
        Console.ReadLine()
    End Sub

    Sub TiposDeDato()
        Dim boolVar As Boolean = False
        Dim byteVar As Byte = 240
        Dim intVar As Integer = 10
        Dim doubleVar As Double = 20.2
        Dim longVar As Long = 5454564
        Dim decimalVar As Decimal = 54.54
        Dim dateVar As Date = Now
        Console.WriteLine("Tipo de dato booleano.  Ejemplo de valor: " & boolVar)
        Console.WriteLine("Tipo de dato byte.  Ejemplo de valor: " & byteVar)
        Console.WriteLine("Tipo de dato integer.  Ejemplo de valor: " & intVar)
        Console.WriteLine("Tipo de dato double.  Ejemplo de valor: " & doubleVar)
        Console.WriteLine("Tipo de dato long.  Ejemplo de valor: " & longVar)
        Console.WriteLine("Tipo de dato decimal.  Ejemplo de valor: " & decimalVar)
        Console.WriteLine("Tipo de dato date.  Ejemplo de valor: " & dateVar)
        Console.ReadLine()
    End Sub

    Sub Operadores()

        'Aritméticos
        Dim a As Short = 100
        Dim b As Short = 20
        Dim x As Short
        x = a + b
        Console.WriteLine("El operador de suma es '+'. El resultado de 100 + 20 es: " & x)
        x = a * b
        Console.WriteLine("El operador de multiplicación es '*'. El resultado de 100 * 20 es: " & x)
        x = a - b
        Console.WriteLine("El operador de resta es '-'. El resultado de 100-20 es: " & x)
        x = a / b
        Console.WriteLine("El operador de division es '/'. El resultado de 100 / 20 es: " & x)


        'De Comparación
        If (a > b) Then
            Console.WriteLine("A es mayor que B")
        End If

        If (b > a) Then
            Console.WriteLine("B es mayor que A")
        End If

        If (a = b) Then
            Console.WriteLine("A es igual a B")
        End If

        If (a <> b) Then
            Console.WriteLine("A es diferente de B")
        End If

        'De concatenación
        Console.WriteLine("Primera cadena " & "Segunda cadena")
        Dim cad1, cad2 As String
        cad1 = "Hola"
        cad2 = "Adios"
        Console.WriteLine("Concatenando variables")
        Console.WriteLine(cad1 & " " & cad2)

        'Lógicos
        Console.WriteLine(Not a > b)
        Console.WriteLine(Not 5 = 5)
        Console.WriteLine(Not 18 > 19 And 20 < 15)
        Console.WriteLine(Not (Not 5 > 4 And 15 = 15))


        'Prioridad de operadores
        Console.WriteLine(5 * 5 + 6 - 10)
        Console.WriteLine(5 + 5 * 6 + 20)
        Console.WriteLine((5 + 5) - 20 * 6)
        Console.WriteLine(((5 - 50) - 20) * 10)
        Console.WriteLine(10 / (2 * 2))

        Console.ReadLine()
    End Sub

    Sub SintexisVB()
        Dim arrAlfabetoGriego() As String = {"alpha", "beta", "gamma", "theta", "omega"}
        Console.WriteLine("arrAlfabetoGriego.Length: " & arrAlfabetoGriego.Length)
        Console.WriteLine("arrAlfabetoGriego[1]: " & arrAlfabetoGriego(1))
        Console.ReadLine()
    End Sub
End Module
