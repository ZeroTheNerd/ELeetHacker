import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class StringAnagrams {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String word1 = scanner.nextLine().toLowerCase();
        String word2 = scanner.nextLine().toLowerCase();
        Map<Character, Integer> map1 = new HashMap<>();
        Map<Character, Integer> map2 = new HashMap<>();
        for(int i = 0; i < word1.length(); i++){
            char char1 = word1.charAt(i);
            map1.put(char1, map1.getOrDefault(char1, 0) + 1);
        }
        for(int i = 0; i < word2.length(); i++) {
            char char2 = word2.charAt(i);
            map2.put(char2, map2.getOrDefault(char2, 0) + 1);
        }

        if(map1.equals(map2)) {
            System.out.println("Anagrams");
        } else {
            System.out.println("Not Anagrams");
        }

    }

}