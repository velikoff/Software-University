import java.util.Scanner;

public class _01SymmetricNumbers {
	
	public static boolean checkSymmetric(int num){
		if (Integer.toString(num).equals(new StringBuilder(Integer.toString(num)).reverse().toString())){
				return true;
		}
		
		else{
			return false;		
		}
	}

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("Please enter two numbers in the range [0...999]: ");
		int start = input.nextInt();
		int end = input.nextInt();
		if (start <= 0 || end >= 999){
			System.out.println("The numbers is not in the range [0...999]");
		}
		
		for (int num = start; num <= end; num++){
			if (checkSymmetric(num) == true){
				System.out.print(num + " ");
			}
		}
	}
		

}
