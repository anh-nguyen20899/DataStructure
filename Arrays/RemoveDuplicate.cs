public class Duplicate {
    public int RemoveDuplicates(int[] nums) {
        int writer = 1;
        for(var reader = 1; reader < nums.Length; reader++)
        {
            if(nums[reader] != nums[reader - 1]){
                nums[writer] = nums[reader];
                writer++;
            }
            
        }
        return writer;
    }
}