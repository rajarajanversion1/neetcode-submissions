public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        foreach(int i in nums){
            if(hs.Contains(i)){
                return true;
            }
            hs.Add(i);
        }
        return false;
    }
}