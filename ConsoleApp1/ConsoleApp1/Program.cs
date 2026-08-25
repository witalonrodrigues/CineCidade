import java.util.Scanner;

public class CineCidade
{
    public static void main(String[] args)
    {

        Scanner scanner = new Scanner(System.in);

        System.out.print("Nome do cliente: ");
        String nomeCliente = scanner.nextLine();

        scanner.close();

        System.out.print("Quantidade de ingressos: ");
        int quantidadeIngressos = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Cupom de desconto: ");
        String cupom = scanner.nextLine();

        double taxaConveniencia = 5.00;
        double precoIngresso = 25.00;

        double custoBruto =
                taxaConveniencia + (quantidadeIngressos * precoIngresso);

    }
}