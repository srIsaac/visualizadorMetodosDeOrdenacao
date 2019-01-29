namespace PraticaOrdenacao {
    class OrdenacaoEstatistica {
        
        public static int ccbolha;
        public static int ctbolha;

        public static int ccselecao;
        public static int ctselecao;

        public static int ccinsercao;
        public static int ctinsercao;

        public static int ccshellsort;
        public static int ctshellsort;

        public static int ccquicksort;
        public static int ctquicksort;

        public static int ccheapsort;
        public static int ctheapsort;

        public static int ccmergesort;
        public static int ctmergesort;

        public static void Bolha(int[] vet) {
            int i, j, temp;
            ccbolha = 0;
            ctbolha = 0;
            for (i = 0; i < vet.Length - 1; i++) {
                ccbolha++;
                for (j = vet.Length - 1; j > i; j--) {
                    ccbolha++;
                    if (vet[j] < vet[j - 1]) {
                        temp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;
                        ctbolha++;
                    }
                }
            }
        }

        public static void selecao(int[] vet)
        {
            int i, j, min, temp;
            ccselecao = 0;
            ctselecao = 0;
            for (i = 0; i < vet.Length - 1; i++)
            {
                ccselecao++;
                min = i;
                for (j = i + 1; j < vet.Length; j++)
                {ccselecao++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        ctselecao++;
                    }
                }
                temp = vet[i];
                vet[i] = vet[min];
                vet[min] = temp;
            }
        }

        public static void insercao(int[] vet)
        {
            ccinsercao = 0;
            ctinsercao = 0;
            int temp, i, j;
            for (i = 1; i < vet.Length; i++)
            {
                ccinsercao++;
                temp = vet[i];
                j = i - 1;
                while (j >= 0 && temp < vet[j])
                {
                    vet[j + 1] = vet[j];
                    j--;
                    ctinsercao++;
                }
                vet[j + 1] = temp;

            }
        }

        public static void shellSort(int[] vet)
        {
            ccshellsort = 0;
            ctshellsort = 0;
            int i, j, x, n;
            int h = 1;
            n = vet.Length;
            do
            {
                h = h * 3 + 1;
            } while (h <= n);
            do
            {
                h /= 3;
                for (i = h; i < n; i++)
                {
                    ccshellsort++;
                    x = vet[i];
                    j = i;
                    while (j > (h - 1) && vet[j - h] > x)
                    {
                        vet[j] = vet[j - h];
                        j -= h;
                        ctshellsort++;
                    }
                    vet[j] = x;
                }
            } while (h != 1);
        }

        public static void quickSort(int[] vet, int esq, int dir)
        {
            int i, j, x, temp;
            ccquicksort = 0;
            ctquicksort = 0;
            x = vet[(esq + dir) / 2]; // pivo
            i = esq;
            j = dir;
            do
            {
                while ((ccquicksort++ >= 0) && x > vet[i]) i++;
                while ((ccquicksort++ >= 0) && x < vet[j]) j--;
                if ((ctquicksort++ >= 0) && i <= j)
                {
                    temp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (esq < j) quickSort(vet, esq, j);
            if (i < dir) quickSort(vet, i, dir);
        }

        public static void heapSort(int[] v)
        {
            ccheapsort = 0;
            ctheapsort = 0;
            constroiMaxHeap(v);
            int n = v.Length;

            for (int i = v.Length - 1; i > 0; i--)
            {
                troca(v, i, 0);
                refaz(v, 0, --n);
            }
        }

        private static void constroiMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--)
                refaz(v, i, v.Length);

        }

        private static void refaz(int[] vetor, int pos, int tamanhoDoVetor)
        {

            int max = 2 * pos + 1, right = max + 1;
            if (max < tamanhoDoVetor)
            {

                if (right < tamanhoDoVetor && vetor[max] < vetor[right])
                    max = right;

                if (vetor[max] > vetor[pos])
                {
                    troca(vetor, max, pos);
                    refaz(vetor, max, tamanhoDoVetor);
                }
            }
        }

        public static void troca(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
        }

        private static void merge(int[] v, int i, int m, int j)
        {
            int[] temp = new int[m - i + 1];
            int k;
            for (k = i; k <= m; k++)
                temp[k - i] = v[k];
            int esq = 0, dir = m + 1;
            k = m - i + 1;
            while (esq < k && dir <= j)
            {
                ccmergesort++;
                if (temp[esq] <= v[dir])
                {
                    v[i++] = temp[esq++];
                    ccmergesort++;
                }
                else
                {
                    v[i++] = v[dir++];
                    ccmergesort++;
                }
            }
            while (esq < k) { 
            v[i++] = temp[esq++];
                ctmergesort++;
        }

        }
        public static void mergeSort(int[] v, int i, int j)
        {
            if (i < j)
            {
                int m = (i + j) / 2;
                mergeSort(v, i, m);
                mergeSort(v, m + 1, j);
                merge(v, i, m, j); // intercala v[i..m] e v[m+1..j] em v[i..j] 
            }
        }









    }
}
