import java.util.Scanner;
import java.util.regex.Pattern;
import java.util.regex.Matcher;

public class _08ExtractEmails {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		String text = in.nextLine().toLowerCase();
		Pattern emailPattern = Pattern
				.compile("[\\w-+]+(?:\\.[\\w-+]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,7}");
		Matcher matcher = emailPattern.matcher(text);
		while (matcher.find()) {
			System.out.println(matcher.group());
		}

	}

}
