public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
           int p1 = m-1;
           int p2 = n-1;
           int i = m+n-1;

           while(p2>=0)
           {
               if( p1 >= 0 && nums1[p1] > nums2[p2]) {
                   nums1[i] = nums1[p1];
                   i--;
                   p1--;
               }                 
               else {
                nums1[i] = nums2[p2];
                  i--;
                  p2--;
               }
           }
        
    }
}
/* 
Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].
Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
*/