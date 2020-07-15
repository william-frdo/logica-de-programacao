/* D02
Uma pequena loja de artesanato possui apenas um vendedor e comercializa dez tipos de objetos. O
vendedor recebe, mensalmente, salário de R$ 545,00, acrescido de 5% do valor total de suas vendas.
O valor unitário dos objetos deve ser informado e armazenado em um vetor; a quantidade vendida de
cada peça deve ficar em outro vetor, mas na mesma posição. Crie um programa que receba os preços
e as quantidades vendidas, armazenando-os em seus respectivos vetores (ambos com tamanho dez).
Depois, determine e mostre:
um relatório contendo: quantidade vendida, valor unitário e valor total de cada objeto. Ao final,
deverão ser mostrados o valor geral das vendas e o valor da comissão que será paga ao vendedor; e
o valor do objeto mais vendido e sua posição no vetor (não se preocupe com empates).
*/

// Necessário para exibir valores monetários formatados
import java.text.NumberFormat;

// Necessário para definir formatação de acordo com o idioma escolhido
import java.util.Locale;

import java.util.Scanner;

public class D02 {
    public static void main(String[] args) throws Exception {
        // Define br como português do Brasil
        final Locale br = new Locale("pt", "BR");
        
        // useLocale necessário para entrar com valores separados por ","
        Scanner s = new Scanner(System.in).useLocale(br);

        int posicao = 0, qtdMaisVendido = 0;
        double vGeral = 0, comissao;
        double[] valor = new double[10];
        int[] qtd = new int[10];

        for (int i = 0; i < qtd.length; i++) {
            System.out.printf("Quantidade vendida do %dº produto: ", i + 1);
            qtd[i] = s.nextInt();
            System.out.printf("Valor do %dº produto: ", i + 1);
            valor[i] = s.nextDouble();
            System.out.println();
        }

        for (int i = 0; i < qtd.length; i++) {
            if (i == 0) {
                posicao = i;
                qtdMaisVendido = qtd[i];
            }
    
            if (qtd[i] > qtdMaisVendido) {
                posicao = i;    
                qtdMaisVendido = qtd[i];
            }
    
            double soma = qtd[i] * valor[i];
            vGeral += soma;
            System.out.printf("Quantidade vendida: %d%n", qtd[i]);
    
            // NumberFormat necessário para exibir valores monetários de acordo com idioma definido
            System.out.printf("Valor unitário: %s%n", NumberFormat.getCurrencyInstance(br).format(valor[i]));
            System.out.printf("Valor total: %s%n", NumberFormat.getCurrencyInstance(br).format(soma));
        }

        System.out.printf("Valor geral das vendas: %s%n", NumberFormat.getCurrencyInstance(br).format(vGeral));
        comissao = vGeral * 0.05;
        System.out.printf("Valor da comissão: %s%n", NumberFormat.getCurrencyInstance(br).format(comissao));
        System.out.printf("Quantidade do objeto mais vendido foi %d, na posição %d", qtdMaisVendido, posicao + 1);
    }
}
