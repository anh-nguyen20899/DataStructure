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
    public int RemoveDuplicatesTwice(int[] nums) {
        int count = 0;
        foreach(var i in nums)
        {
            if(count<2|| i > nums[count -2])
            {
                nums[count] = i;
                count++;
            }
        }
        return count;
        
    }
}