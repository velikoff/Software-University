import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;

public class _01SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Please enter the length of the array: ");
		int n = input.nextInt();
		
		int[] array = new int[n];
		
		for(int i = 0; i < n; i++){
			System.out.printf("array[%d]: ", i);
			array[i] = input.nextInt();
		}
		
		Arrays.sort(array);
		
		System.out.println(Arrays.toString(array));

	}

}
