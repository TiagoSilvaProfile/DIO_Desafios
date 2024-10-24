// Importa a biblioteca readline-sync
const readline = require('readline-sync');

// Função para calcular o saldo de vitórias e determinar o nível
function calcularSaldoRankeadas(vitorias, derrotas) {
    // Calcula o saldo de vitórias
    const saldoVitorias = vitorias - derrotas;
    
    // Variável para armazenar o nível
    let nivel = '';

    // Determina o nível baseado no número de vitórias
    if (vitorias < 10) {
        nivel = 'Ferro';
    } else if (vitorias >= 11 && vitorias <= 20) {
        nivel = 'Bronze';
    } else if (vitorias >= 21 && vitorias <= 50) {
        nivel = 'Prata';
    } else if (vitorias >= 51 && vitorias <= 80) {
        nivel = 'Ouro';
    } else if (vitorias >= 81 && vitorias <= 90) {
        nivel = 'Diamante';
    } else if (vitorias >= 91 && vitorias <= 100) {
        nivel = 'Lendário';
    } else if (vitorias >= 101) {
        nivel = 'Imortal';
    }

    // Exibe a mensagem com o saldo de vitórias e o nível
    console.log(`O Herói tem de saldo de ${saldoVitorias} está no nível de ${nivel}`);
}

// Exemplo de uso
const vitorias = parseInt(readline.question('Digite o número de vitórias: '));
const derrotas = parseInt(readline.question('Digite o número de derrotas: '));

// Chama a função para calcular e exibir o resultado
calcularSaldoRankeadas(vitorias, derrotas);