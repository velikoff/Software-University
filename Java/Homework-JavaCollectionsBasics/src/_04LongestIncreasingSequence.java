import java.util.Arrays;
import java.util.Scanner;
public class _04LongestIncreasingSequence {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String[] strArray = str.split(" ");
		int[] numArray = new int[strArray.length];
		
		for(int i = 0; i < numArray.length; i++){
			numArray[i] = Integer.parseInt(strArray[i]);
		}
		
		int counter = 1;
		int bestCounter = 1;
		int position  = 0;
		System.out.print(numArray[0]);
		for(int i = 1; i < strArray.length; i++){
			if(numArray[i] > numArray [i- 1] ){
				counter++;
				System.out.print(" " + numArray[i]);
			} else{
				counter = 1;
				System.out.println();
				System.out.print(numArray[i]);
			}
			if (counter > bestCounter){
				bestCounter = counter;
				position = i;
			}
		}
			
		System.out.println();
		
		System.out.print("Longest: ");
		
		for ( int j = 0; j < counter - 1; j++){
			System.out.print(numArray[position - bestCounter + 1 + j] + " ");
		}
		
		System.out.println(numArray[position]);
	}

}
