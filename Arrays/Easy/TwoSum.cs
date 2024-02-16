/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/
public class TwoSum
{
    public int[] AddTwoSum(int[] nums, int target) {

        if(nums == null || nums.Length ==0)
        {
            return null;
        }

        

        for(int i=0; i< nums.Length; i++)
        {
            int sum =0;
            int[] arrOutput = new int[2];
            for(int j=i+1; j< nums.Length; j++)
            {
                sum =nums[i] + nums[j];
                if(sum == target)
                {
                    arrOutput[0] = i;
                    arrOutput[1] = j;
                    return arrOutput;
                }
                sum = 0;

            }
            
            
        }
       return null;
    }
}