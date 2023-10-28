/*Reverse an array without using another temporary array.

Input:  21 43 22 67 43 12 4
Output :  4 12 43 67 22 43 21
*/

int[] nums = [21, 43, 22, 67, 43, 12, 4];

for (int i = 0, j = 5; i < (nums.Length/2)-1; i++,j--)
{
   
    
        int tempNum = nums[i];
        int temp = nums[j];
        nums[j] = tempNum;
        nums[i] = temp;
    
    
}
for (int i = 0;i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}