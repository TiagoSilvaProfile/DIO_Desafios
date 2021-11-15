package ParadigmaFuncional;

import  java.util.function.UnaryOperator; //Foi importado esta biblioteca para exemplo

public class Imutabilidade {
    public static void main(String[] args) {

        int valor = 20;
        UnaryOperator<Integer> retornarDobro = v -> v*2; // Dentro da Lambda ela não permite a alteração do valor informado anteriormente

        System.out.println(retornarDobro.apply(valor)); //Irá mostrar 40, por causa da operação dentro da Lambida.
        System.out.println(valor);// Não irá mostrar 40, por que o valor não pode ser alterado, por este motivo o 20
    }
}
