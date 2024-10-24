// Variáveis para armazenar o nome e a quantidade de XP do herói
let nomeHeroi = "Thor";
let experiencia = 8500;
let nivel = "";

// Estrutura de decisão para classificar o herói com base na experiência (XP)
if (experiencia < 1000) {
  nivel = "Ferro";
} else if (experiencia <= 2000) {
  nivel = "Bronze";
} else if (experiencia <= 5000) {
  nivel = "Prata";
} else if (experiencia <= 7000) {
  nivel = "Ouro";
} else if (experiencia <= 8000) {
  nivel = "Platina";
} else if (experiencia <= 9000) {
  nivel = "Ascendente";
} else if (experiencia <= 10000) {
  nivel = "Imortal";
} else {
  nivel = "Radiante";
}

// Saída final com o nome do herói e o nível correspondente
console.log(`O Herói de nome ${nomeHeroi} está no nível de ${nivel}`);