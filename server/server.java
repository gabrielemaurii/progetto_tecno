package server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class server implements Runnable {

    private int porta;
    private boolean running = false;
    private ServerSocket serverSocket;
    private String messaggio = "";

    public server(int port) {
        this.porta = port;
        try {
            serverSocket = new ServerSocket(port);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void start() {
        new Thread(this).start();
    }

    @Override
    public void run() {
        running = true;
        while (running) {
            if (!messaggio.equals("END")) {
                try {
                    Socket socket = serverSocket.accept();
                    initSocket(socket);
                } catch (IOException e) {
                    e.printStackTrace();
                }
            } else {
                shutdown();
            }
        }
    }

    private void initSocket(Socket socket) {
        Connection connection = new Connection(socket);
        new Thread(connection).start();
    }

    public void shutdown() {
        running = false;
        try {
            serverSocket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}