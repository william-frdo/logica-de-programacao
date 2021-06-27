/* D02
   Uma pequena loja de artesanato possui apenas um vendedor e comercializa dez tipos de objetos.
   O vendedor recebe, mensalmente, salário de R$ 545,00, acrescido de 5% do valor total de suas
   vendas. O valor unitário dos objetos deve ser informado e armazenado em um vetor; a quantidade
   vendida de cada peça deve ficar em outro vetor, mas na mesma posição. Crie um programa que
   receba os preços e as quantidades vendidas, armazenando-os em seus respectivos vetores (ambos
   com tamanho dez).
   Depois, determine e mostre:
   um relatório contendo: quantidade vendida, valor unitário e valor total de cada objeto. Ao
   final, deverão ser mostrados o valor geral das vendas e o valor da comissão que será paga ao
   vendedor; e o valor do objeto mais vendido e sua posição no vetor (não se preocupe com empates).
 */

var input = require('fs').readFileSync('stdin', 'utf8');
var lines = input.split('\n');

let vUnitario = [], qtdVendida = [];

for (let i = 0; i < lines.length; i++) {
    if (i < 10) {
        vUnitario.push(parseFloat(lines[i]));
    } else {
        qtdVendida.push(parseInt(lines[i]));
    }    
}

let maisVendido = qtdVendida[0];
let indiceMaisVendido;
let totalObjeto;
let totVendas = 0;
for (let i = 0; i < vUnitario.length; i++) {
    console.log(`Quantidade vendida do objeto ${i}: ${qtdVendida[i]}`);
    console.log(`Valor unitário do objeto ${i}: ${vUnitario[i]}`);
    totalObjeto = qtdVendida[i] * vUnitario[i];
    console.log(`Valor total do objeto ${totalObjeto}`);
    totVendas += totalObjeto;
    if (qtdVendida[i] > maisVendido) {
        indiceMaisVendido = i;
    }
}

let comissao = totVendas * 0.05;
console.log(`Valor geral das vendas: ${totVendas}`);
console.log(`Valor da comissão: ${comissao}`);
console.log(`Valor do objeto mais vendido: ${vUnitario[indiceMaisVendido]}`);
console.log(`Posição no array do objeto mais vendido: ${indiceMaisVendido}`);
