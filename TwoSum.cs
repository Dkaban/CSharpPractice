// THE PROBLEM
// ***************************
// Given a target value, find two numbers in an array, when summed equal the target value.
// Solution Created By: Dustin Kaban
// Date: June 10th, 2020
// ***************************

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    return new int[2] {i,j};
                }
            }
        }
        return new int[2] {0,0};
    }
}
