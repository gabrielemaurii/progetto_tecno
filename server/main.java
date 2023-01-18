package server;

/**
 *
 * @author mauri_gabriele
 */
public class main {
    public static void main(String[] args) {
        gestisciGioco gioco = new gestisciGioco();
        server s = new server(8080);
        s.start();
        gioco.stampa();
    }
}
