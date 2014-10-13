import java.util.Scanner;

public class _06CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String sentence = input.nextLine().toLowerCase();
		String word = input.nextLine().toLowerCase();
		String[] array = sentence.split("\\W+");
		int counter = 0;
		
		for(int i = 0; i < array.length; i++){
			if (word.equals(array[i])){
				counter++;
			}
		}
		
		System.out.println(counter);

	}

}
