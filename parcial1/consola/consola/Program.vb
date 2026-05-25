Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Calcula tu edad")
        Dim edad As Integer
        Integer.TryParse(Console.ReadLine(), edad)
        If edad >= 18 Then
            Console.WriteLine("Eres mayor de edad")
        Else
            Console.WriteLine("NO Eres mayor de edad")
        End If

        Console.Write("Ingresa su calificacion(0-100)")
        Dim calificacion As Integer
        Integer.TryParse(Console.ReadLine(), calificacion)

        Dim letra As String
        Select Case calificacion
            Case 90 To 100
                letra = "A --Exelente"
            Case 80 To 89
                letra = "B --TA BIEN"
            Case 70 To 79
                letra = "C --BUENO"
            Case 60 To 69
                letra = "D --MMM"
            Case 0 To 59
                letra = "E --MAMASTE"
            Case Else
                letra = "Calificacion invalida"

        End Select
        Console.WriteLine($"SU CALIFICACION ES: {letra}")

        Dim diasemana As String = DateTime.Now.ToString("ddd")
        Console.WriteLine($"Hoy es :{diasemana}")

        Select Case diasemana.ToLower

            Case "lum", "Mar", ",Mir", "Juv", "Vier"
                Console.WriteLine("es un dia laborable 9 a 6 chambea perro")
            Case "Sab"
                Console.WriteLine("es un dia laborable 9 a 3 chambea perro")
            Case "Dom"
                Console.WriteLine("ES dia de descanso mi loco")

        End Select
        Console.WriteLine("Extructura par: ")
        For i As Integer = 1 To 5
            Console.WriteLine($"numero: {i}")
        Next

        Console.WriteLine("Extructura inpar: ")
        For i As Integer = 0 To 20 Step 2
            Console.WriteLine($"numero: {i}")
        Next

        Console.WriteLine("Extructura negativo: ")
        For i As Integer = 10 To 0 Step -1
            Console.WriteLine($"numero: {i}")
        Next


        Console.WriteLine("Promedio alumno")
        Dim calificaciones() As Integer = {85, 90, 78, 92, 88}
        Dim suma As Integer = 0

        For i As Integer = 0 To calificaciones.Length - 1
            suma += calificaciones(i)
        Next
        Dim promedio As Decimal = CDec(suma) / calificaciones.Length
        Console.WriteLine($"EL promendio alumno {promedio: F2}")




        Console.WriteLine("ARRAY")
        Dim conso() As String = {"XBOX", "PLAY", "NINTENTO", "SEGA", "PC"}
        For i As Integer = 1 To conso.Length - 1
            Console.WriteLine($"Jugar en {i}: {conso(i)}")
        Next



        Console.WriteLine("LIST(OF T) CON FOR")
        Dim alumnos As New List(Of String)
        alumnos.Add("Carlos")
        alumnos.Add("Maria")
        alumnos.Add("Pedro")
        alumnos.Add("Luisa")

        For i As Integer = 0 To alumnos.Count - 1
            Console.WriteLine($"Alumno {i + 1}: {alumnos(i)}")
        Next













    End Sub
End Module
