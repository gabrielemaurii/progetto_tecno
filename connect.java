/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package server_progtecno;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.PrintWriter;
import java.net.Socket;

/**
 *
 * @author mauri_gabriele
 */
public class connect extends Thread{
    // dichiarazione delle variabili socket e dei buffer

    Socket client;
    BufferedReader in;
    PrintWriter out;

    public connect(Socket client) {
        this.client = client;
        // invoca automaticamente il metodo run()
        this.start();
    }

    public void run() {
        try {
            // inizializza i buffer in entrata e uscita
            in = new BufferedReader(new InputStreamReader(client.getInputStream()));
            out = new PrintWriter(new BufferedWriter(new OutputStreamWriter(client.getOutputStream())), true);

            System.out.println("Sto servendo il client che ha indirizzo " + client.getInetAddress());

            // eventuali elaborazioni e scambi di informazioni con il client
            // ...
            // chiusura dei buffer e del socket
            in.close();
            out.close();
            client.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}
