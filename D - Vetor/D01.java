/* D01
   Faça um programa que preencha um vetor com nove números inteiros,
   calcule e mostre os números primos e suas respectivas posições.
*/

import java.security.SecureRandom;
import java.util.Arrays;

public class D01 {
    public static void main(String[] args) throws Exception {
        int[] n = new int[9];
        SecureRandom r = new SecureRandom();

        // Preenche o array com números aleatórios de 0 à 100
        for (int i = 0; i < n.length; i++) {
            n[i] = r.nextInt(101);
        }

        // Exibe o array
        System.out.println(Arrays.toString(n));

        boolean b = false;
        for (int i = 0; i < n.length; i++) {            
            // Verifica se é primo
            int s = 0;
            for (int j = n[i]; j > 0; j--) {
                if (n[i] % j == 0) {
                    s++;
                }                
            }

            // Exibe os valores primos
            if (s == 2) {
                System.out.println("Valor: " + n[i] + ", na posição: [" + i + "]");
                b = true;
            }
        }

        if (b == false) {
            System.out.println("Não há números primos");
        }
    }
}
