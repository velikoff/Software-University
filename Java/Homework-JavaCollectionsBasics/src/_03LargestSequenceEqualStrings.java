import java.util.Scanner;

public class _03LargestSequenceEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String str = input.nextLine();
		String[] array = str.split(" ");
		int count = 1;
		int bestCount = 1;
		int posWord = 0;
		
		for (int i = 1; i < array.length ; i++){
			if ( array[i].equals(array[i - 1])){
				count++;
			}
				else {
						count = 1;
					}
			if ( count > bestCount){
				bestCount = count;
				posWord = i;
				}
			
		}
		
		for ( int i = 0; i <= bestCount - 1; i ++){
			System.out.print(array[posWord] + " ");
		}
		
		

	}

}
