/* D01
   Faça um programa que preencha um vetor com nove números inteiros,
   calcule e mostre os números primos e suas respectivas posições.
*/

var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

let n = [];
for (let i = 0; i < lines.length; i++) {
    n.push(parseInt(lines[i]));
}

// Exibe o array
console.log(JSON.stringify(n));

let b = false;
for (let i = 0; i <= n.length; i++) {
    let c = 0;
    // Verifica se há números primos
    for (let j = n[i]; j > 0; j--) {
        if (n[i] % j === 0) {
            c++;
        }
    }    
    // Mostra números primos
    if (c === 2) {
        console.log(`${n[i]} é primo e está na posição ${i}`);
        b = true;
    }
}

if (!b) {
    console.log("Não há números primos");
}
