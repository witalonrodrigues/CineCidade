import java.util.Scanner;

public class CineCidade
{
    public static void main(String[] args)
    {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Nome do cliente: ");
        String nomeCliente = scanner.nextLine();

        scanner.close();
    }
}