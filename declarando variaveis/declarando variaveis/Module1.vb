Module Module1

    Sub Main()
        'Declaração de Variáveis'
        Dim nomeAluno As String
        Dim nota1, nota2, nota3, nota4, media As Double

        ' Entrada de informações do nome do usuário '
        Console.Write("Informe seu nome: ")
        nomeAluno = Console.ReadLine

        'Entrada das notas do Aluno '
        Console.Write("Informe a sua nota1: ")
        nota1 = Console.ReadLine

        Console.Write("Informe a sua nota2: ")
        nota2 = Console.ReadLine

        Console.Write("Informe a sua nota3: ")
        nota3 = Console.ReadLine

        Console.Write("Informe a sua nota4: ")
        nota4 = Console.ReadLine

        ' Calculando a média '
        media = (nota1 + nota2 + nota3 + nota4) / 4

        ' Mostrar a média do aluno'
        Console.WriteLine("{0} sua média foi de {1}", nomeAluno, media)

        Console.ReadKey()


    End Sub

End Module
