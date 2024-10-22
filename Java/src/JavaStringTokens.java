import java.util.Arrays;
import java.util.Scanner;

public class JavaStringTokens {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String message = scanner.nextLine();
        String[] messageArr = message.split("[^a-zA-Z]+");
        messageArr = Arrays.stream(messageArr)
                .filter(s -> !s.isEmpty())
                .toArray(String[]::new);
            System.out.println(messageArr.length);

        for(int i = 0; i < messageArr.length; i++) {
            System.out.println(messageArr[i]);
        }

    }
}
