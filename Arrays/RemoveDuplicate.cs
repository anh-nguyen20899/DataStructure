public class Duplicate {
    public int RemoveDuplicates(int[] nums) {
        int writer = 0;
        int reader = 0;
        while( reader < nums.Length) {
            if(nums[writer] != nums[reader]) {
                writer++;
                nums[writer] = nums[reader];
            }
            reader ++;   
        }
        return writer + 1;
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