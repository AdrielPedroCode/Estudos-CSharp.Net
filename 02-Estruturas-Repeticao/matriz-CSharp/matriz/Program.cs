
using System.Diagnostics;

string[] vet = Console.ReadLine().Split(' ');
int M = int.Parse(vet[0]);
int N = int.Parse(vet[1]);

int[,] Mat = new int[M, N];


for (int i = 0; i < M; i++) {
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++) {
        Mat[i, j] = int.Parse(values[j]);
    }
}

int x = int.Parse(Console.ReadLine());

/*Meu*/
for (int i = 0; i < M; i++) {
    for (int j = 0; j < N; j++) {
        if (Mat[i, j] == x) {
            Console.WriteLine("Posicao " + i + "," + j + ":");
            if (j > 0) {
                Console.WriteLine("Esquerda: " + Mat[i, j - 1]);
            }
            if (i > 0) {
                Console.WriteLine("Cima: " + Mat[i - 1, j]);
            }
            if (j < N - 1) {
                Console.WriteLine("Direita: " + Mat[i, j + 1]);
            }
            if (i < M - 1) {
                Console.WriteLine("Baixo: " + Mat[i + 1,j]);
            }

                }
            }
        }










