import java.util.Arrays;
import java.util.Scanner;
import java.lang.reflect.Array;

public class _02SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String[] array = str.split(" ");
		
		System.out.print(array[0]);
		
		for (int i = 1; i < array.length; i++){
			if (array[i].equals(array[i - 1])){
				System.out.print(" " + array[i]);
			}
			else{
				System.out.println();
				System.out.print(array[i]);
			}
		}

	}

}
