package ParadigmaFuncional;

import java.util.function.BiPredicate; //Foi importado esta biblioteca para exemplo

public class FuncoesPuras {
    public static void main(String[] args) {

        BiPredicate<Integer, Integer> verificarSeMaior =
                (paramentro, valorComparacao) -> paramentro > valorComparacao;// Na Lambda esta sendo informado dois paramentros para comparação

        System.out.println(verificarSeMaior.test(13,12)); // Se neste caso for "True" no próximo teste tem que ser o mesmo resultado
        System.out.println(verificarSeMaior.test(13,12));// Este resultado deve conter o mesmo do anterior.
    }
}
