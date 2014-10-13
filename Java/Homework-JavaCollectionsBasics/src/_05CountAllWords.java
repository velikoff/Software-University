import java.util.Scanner;

public class _05CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String strInput = input.nextLine();
		String[] words = strInput.split("\\S");
		System.out.println(words.length);

	}

}
