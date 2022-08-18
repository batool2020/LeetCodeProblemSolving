public class Solution {
    public int NumIdenticalPairs(int[] nums) {
      
     Dictionary<int,int> hashmap = new Dictionary<int, int>(); // creating a dictionary of key and value of int. 
        
        for(int i=0; i< nums.Length; i++){
            
            if(hashmap.ContainsKey(nums[i])) 
                hashmap[nums[i]] +=1;
                        
            else
                hashmap[nums[i]] = 1; 
        }
        
     int k = 0;

            foreach (var keyValuePair in hashmap)

            {

                if (keyValuePair.Value == 1) continue;

                k += keyValuePair.Value * (keyValuePair.Value - 1) / 2;

            }
        
        return k;
  
            
            
        }
    
}
 
                        
                        
                                                
