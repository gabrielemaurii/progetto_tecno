package server;

public class gestisciGioco {
    int[][] matrix = { { 1, 2, 3, 4, 5, 6, 7, 8 }, { 9, 10, 11, 12, 13, 14, 15, 16 },
            { 17, 18, 19, 20, 21, 22, 23, 24 }, { 25, 26, 27, 28, 29, 30, 31, 32 } };

    public void stampa() {
        for (int i = 0; i < matrix.length; i++) {
            for (int j = matrix[i].length; j < -1; j--) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }

}
