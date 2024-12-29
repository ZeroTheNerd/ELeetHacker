import java.util.HashMap;

public class LongestSubstring {
    public static void main(String[] args) {
        HashMap<Character, Integer> characters = new HashMap<>();
        int maxLength = 0;
        int start = 0;
        for(int i = 0; i < s.length(); i++) {
            char currentChar = s.charAt(i);
            if(characters.containsKey(currentChar) && characters.get(currentChar) >= start) {
                start = characters.get(currentChar) + 1;
            }
            characters.put(currentChar, i);

            maxLength = Math.max(maxLength, i - start + 1);
        }
        return maxLength;
    }


}

