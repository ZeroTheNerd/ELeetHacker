import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class JavaMap {
    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        Map<String, Integer> map = new HashMap<>();
        for(int i = 0; i < n; i++) {
            String name = scanner.nextLine();
            int number = scanner.nextInt();
            scanner.nextLine();
            map.put(name, number);
        }

        for(int i = 0; i < n; i++) {
            String query = scanner.nextLine();
            if (map.containsKey(query)) {
                System.out.println(query + "=" + map.get(query));
            } else {
                System.out.println("Not found");
            }
        }

    }
}
