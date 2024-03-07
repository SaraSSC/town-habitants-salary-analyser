namespace Exercicio6_teste
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int totalAgregados = 0;
            double totalRendimento = 0;
            int totalFilhos = 0;
            int totalAgregadosSemFilhos = 0;
            int totalAgregadosMenor900 = 0;
            double maiorRendimento = double.MinValue;
            double menorRendimento = double.MaxValue;
            
            while (true)
            {
                // Solicita dados
                Console.Write("Rendimento mensal do agregado (em euros): ");
                double rendimento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Número de filhos: ");
                int numeroFilhos = Convert.ToInt32(Console.ReadLine());

                // Atualiza totais (ilitirar x++ && x=x+y)
                totalAgregados++;
                totalRendimento += rendimento;
                totalFilhos += numeroFilhos;

                if (rendimento > maiorRendimento)
                {
                    maiorRendimento = rendimento;
                }

                if (rendimento < menorRendimento)
                {
                    menorRendimento = rendimento;
                }

                if (numeroFilhos == 0)
                {
                    totalAgregadosSemFilhos++;
                }

                if (rendimento < 900)
                {
                    totalAgregadosMenor900++;
                }

                // Pergunta ao usuário se deseja inserir mais dados
                Console.Write("Deseja inserir dados para outro agregado? (s/n): ");
                char resposta = Console.ReadLine().ToLower()[0]; //coloca o output para minúsculas

                //resposta diferente de s
                if (resposta != 's')
                {
                    break;
                }
            }

            // Calcular médias
            double mediaRendimento = totalRendimento / totalAgregados;
            double mediaFilhos = (double)totalFilhos / totalAgregados;

            // Calcular percentagens
            double percentagemSemFilhos = (double)totalAgregadosSemFilhos / totalAgregados * 100;
            double percentagemMenor900 = (double)totalAgregadosMenor900 / totalAgregados * 100;

            // variável :F2 = casas decimais apresentadas --> mais fácil de ler
            // Apresenta resultados
            Console.WriteLine($"Média de rendimento dos agregados familiares: {mediaRendimento:F2} euros");
            Console.WriteLine($"Média do número de filhos: {mediaFilhos:F2}");
            Console.WriteLine($"Maior rendimento no total de agregados familiares: {maiorRendimento:F2} euros");
            Console.WriteLine($"Menor rendimento no total de agregados familiares: {menorRendimento:F2} euros");
            Console.WriteLine($"Percentagem de agregados familiares sem filhos: {percentagemSemFilhos:F2}%");
            Console.WriteLine($"Percentagem de agregados familiares com rendimento menor que 900 euros: {percentagemMenor900:F2}%");
        }
    }
    
}
