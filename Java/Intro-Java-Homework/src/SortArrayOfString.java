import java.util.Scanner;
import java.util.Arrays;

public class SortArrayOfString {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        String[] allWords = new String[n];
        for(int i=0;i<n;i++)
        {
                allWords[i] = sc.next();
        }
        Arrays.sort(allWords);
        for(int i=0;i<n;i++)
        {
                System.out.println(allWords[i]);
        }

	}

}
