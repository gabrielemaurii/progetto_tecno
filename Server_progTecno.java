/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package server_progtecno;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

/**
 *
 * @author mauri_gabriele
 */
public class Server_progTecno {

    /**
     * @param args the command line arguments
     * @throws java.io.IOException
     */
    public static void main(String[] args) throws IOException {
        // TODO code application logic here
        try {
            ServerSocket server = new ServerSocket(33333);

            // ciclo infinito, in attesa di connessioni
            while (true) {
                System.out.println("in attesa di un client");
                // chiamata bloccante, in attesa di una nuova connessione
                Socket client = server.accept();

                // la nuova richiesta viene gestita da un thread indipendente, si ripete il ciclo
                connect newClient = new connect(client);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

    }

}
