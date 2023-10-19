public class RemoveElements {
    public int RemoveElement(int[] nums, int val) {
        int writer = 0;
        for(var reader = 0; reader< nums.Length; reader++){
            if(nums[reader] != val){
                nums[writer] = nums[reader];
                writer++;
            }
            
        }
        return writer;
}
}