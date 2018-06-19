namespace PraticaOrdenacao {
    class OrdenacaoEstatistica {
        // TODO: contador de comparações e trocas
        // TODO: declarar demais métodos de ordenação
        public static int cc;
        public static int ct;
        public static void Bolha(int[] vet) {
            int i, j, temp;
            cc = 0;
            ct = 0;
            for (i = 0; i < vet.Length - 1; i++) {
                for (j = vet.Length - 1; j > i; j--) {
                    cc++;
                    if (vet[j] < vet[j - 1]) {
                        temp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;
                        ct++;
                    }
                }
            }
        }

        ///////////////////////////////////////////////////



    }
}
