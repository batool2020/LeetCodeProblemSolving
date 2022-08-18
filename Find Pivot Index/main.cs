class Solution {
    public int pivotIndex(int[] nums) {
      int total=0; 
        for(int i:nums)
            total+=i;
        
        int leftSide=0;
        for(int i=0;i<nums.length;i++){
            int rightSide = total-nums[i]-leftSide; // compute rightSide
            if(leftSide==rightSide)return i; // check if Equal to leftSide
            leftSide+=nums[i]; // add number to leftSide and move ahead
        }
        
        return -1;                    
}
}
