package ParadigmaFuncional;

import java.util.Arrays; //Foi importado esta biblioteca para exemplo

public class ComposicoesDeFuncoes {

    public static void main (String[] args){

        int [] valores = {1,2,3,4};

        // Funcional
        Arrays.stream(valores)
                .filter(numero -> numero % 2 ==0) //Verifica se o valor que esta entrando é divisivel por 2, neste caso o resto é 0
                .map(numero -> numero*2) // Caso o filter seja verdadeiro o valor será multiplicado por 2
                .forEach(numero -> System.out.println(numero)); //Após o map gerar o resultado o valor será mostrado na tela

        // Imperativo
        for (int i =0; i < valores.length; i++){
            int valor = 0;
            if (valores[i] % 2 ==0){
                valor = valores[i] * 2;

                if (valor !=0){
                    System.out.println(valor);
                }
            }
        }
    }
}
