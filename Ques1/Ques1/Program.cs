/* Given an integer array nums, return true if any value appears at least twice in the array, 
  and return false if every element is distinct.*/

int[] nums = new int[4];
for (int i = 0; i<nums.Length; i++)
{
   int addNum = Convert.ToInt32(Console.ReadLine());
    nums[i] = addNum;
}
for (int i = 0;i<nums.Length;i++)
{
    int[] tArray = new int[4];
    tArray[i] = nums[i];
}