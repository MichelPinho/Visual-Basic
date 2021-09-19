Module Module1

    Sub Main()
        'declarando as variáveis
        Dim aluno As String
        Dim nota1, nota2, nota3, nota4, media As Double
        Dim pergunta As String = "s"

        'iniciar com o loop do while pois precisamos fazer um teste lógico ( verificação)
        Do While pergunta.ToLower = "s"
            Console.Clear()  ' serve para limpar a tela e não deixar ela com as informações da última consulta.

            Console.Write(" Informe seu nome : ") ' recebendo a note do aluno pelo teclado .
            aluno = Console.ReadLine  ' guardando a nota recebida na sua variável.
            Console.Write("Informe a sua 1 nota : ")
            nota1 = Console.ReadLine
            Console.Write("Informe a sua 2 nota : ")
            nota2 = Console.ReadLine
            Console.Write("Informe a sua 3 nota : ")
            nota3 = Console.ReadLine
            Console.Write("Informe a sua 4 nota : ")
            nota4 = Console.ReadLine

            media = (nota1 + nota2 + nota3 + nota4) / 4  ' calculando a media do aluno.

            ' verificando a condição do aluno

            Select Case media
                Case >= 5
                    Console.WriteLine("{0} Parabéns você foi aprovado, sua média foi de {1}.", aluno, media)

                Case 4 To 4.99
                    Console.WriteLine("{0} você está em recuperação, sua média foi de {1}.", aluno, media)

                Case Else
                    Console.WriteLine("{0} você está reprovado(a), sua média foi de {1}.", aluno, media)

            End Select

            ' Perguntando ao usuário se deseja continuar

            Console.Write(" Deseja continuar (s/n): ")
            pergunta = Console.ReadLine

        Loop

        Console.WriteLine("Fim do Programa")


        Console.ReadKey()
    End Sub

End Module
