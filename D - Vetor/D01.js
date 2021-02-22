/* D01
Faça um programa que preencha um vetor com nove números inteiros,
calcule e mostre os números primos e suas respectivas posições.
*/

// Declara array
const numbers = [];
// Preenche array com 9 números inteiros de 0 a 100
for (let i=0; i<9; i++) {
    numbers.push(Math.floor(Math.random() * 101));
}

// Mostra os valores do array
console.log(numbers);

let possuiPrimo = false;
for (let i=0; i<numbers.length; i++) {
    // Verifica se é primo
    let cont = 0;
    for (let j=numbers[i]; j>0; j--) {
        if (numbers[i] % j === 0) {
            cont++;
        }
    }
    // Exibe o valor e a posição se for primo
    if (cont === 2) {
        console.log(`O valor ${numbers[i]} é primo e está na posição ${i}`);
        possuiPrimo = true;
    }
}

// Se não houver números primos, exibe o aviso na tela
if (possuiPrimo === false) {
    console.log("Não há números primos");
}