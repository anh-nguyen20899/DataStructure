public class Duplicate {
    public int RemoveDuplicates(int[] nums) {
        int count = 1;
        for(var i = 1  ; i<nums.Length; i++)
        {
            if(nums[i]!=nums[i-1]||i==0){
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}