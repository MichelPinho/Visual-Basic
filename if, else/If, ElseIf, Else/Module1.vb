Module Module1

    Sub Main()
        ' programa para calcular a media do aluno
        ' Quem é o aluno
        ' Calculcar a média
        ' Mostrar a média para o usuário
        ' Se a média do aluno for maior ou igual 5, o aluno está aprovado
        ' Se a média do aluno estiver entre 4 e 4,99 , o aluno estará em recuperação
        ' Se a média for menor que 4 , o aluno estará reprovado.

        'Declaração das variáveis
        Dim aluno As String
        Dim nota1, nota2, nota3, nota4 As Double
        Dim media As Double

        ' Solicitando ao usuário informações 
        Console.Write("Informe seu nome: ")
        aluno = Console.ReadLine ' Salva as informações declaradas pelo usuário na variável

        Console.Write("informe a sua 1 nota: ")
        nota1 = Console.ReadLine

        Console.Write("informe a sua 2 nota: ")
        nota2 = Console.ReadLine

        Console.Write("informe a sua 3 nota: ")
        nota3 = Console.ReadLine

        Console.Write("informe a sua 4 nota: ")
        nota4 = Console.ReadLine

        ' Calculando as médias do aluno 
        media = (nota1 + nota2 + nota3 + nota4) / 4

        ' Inoformando as aluno a sua média 
        Console.WriteLine("{0} sua média foi de {1} ", aluno, media) ' {0} corresponde ao aluno, e {1} a sua média.

        If media >= 5 Then
            Console.WriteLine("{0} sua média foi de {1}, Aprovado ", aluno, media)

        ElseIf media >= 4 And media < 5 Then
            Console.WriteLine("{0} sua média foi de {1}, em Recuperação ", aluno, media)

        Else
            Console.WriteLine(" Aluno reprovado ")


        End If



        Console.ReadKey()

    End Sub

End Module
