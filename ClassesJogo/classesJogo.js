// Classe Heroi que representa o herói de uma aventura
class Heroi {
    constructor(nome, idade, tipo) {
      this.nome = nome;  // Nome do herói
      this.idade = idade; // Idade do herói
      this.tipo = tipo;   // Tipo do herói (guerreiro, mago, monge, ninja)
    }
  
    // Método atacar que exibe a mensagem do tipo de ataque
    atacar() {
      let ataque;
      
      // Estrutura de decisão para definir o tipo de ataque
      switch (this.tipo.toLowerCase()) {
        case 'mago':
          ataque = 'magia';
          break;
        case 'guerreiro':
          ataque = 'espada';
          break;
        case 'monge':
          ataque = 'artes marciais';
          break;
        case 'ninja':
          ataque = 'shuriken';
          break;
        default:
          ataque = 'um ataque desconhecido';
      }
  
      // Exibindo a mensagem com o tipo de herói e ataque
      console.log(`O ${this.tipo} atacou usando ${ataque}`);
    }
  }
  
  // Exemplo de criação de instâncias de heróis
  const heroi1 = new Heroi('Arthur', 30, 'guerreiro');
  const heroi2 = new Heroi('Merlin', 150, 'mago');
  const heroi3 = new Heroi('Kenshi', 25, 'ninja');
  const heroi4 = new Heroi('Dhalsim', 40, 'monge');
  
  // Chamando o método atacar para cada herói
  heroi1.atacar();  // O guerreiro atacou usando espada
  heroi2.atacar();  // O mago atacou usando magia
  heroi3.atacar();  // O ninja atacou usando shuriken
  heroi4.atacar();  // O monge atacou usando artes marciais
  