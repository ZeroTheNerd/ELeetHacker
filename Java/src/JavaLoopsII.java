import java.util.Scanner;

public class JavaLoopsII {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        for (int i = 0; i < n; i++) {
        int start = scanner.nextInt();
        int mult = scanner.nextInt();
        int n2 = scanner.nextInt();
        int sum = start;
        ;
        for (int j = 0; j <= n2 - 1; j++) {
            sum += Math.pow(2, j) * mult;
            System.out.print(sum + " ");
        }
        System.out.println();
    }
    }
}
