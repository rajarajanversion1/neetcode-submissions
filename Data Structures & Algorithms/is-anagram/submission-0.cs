public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> store = new Dictionary<char, int>();
        if(s.Length != t.Length){
            return false;
        }
        foreach( char i in s){
            if(store.ContainsKey(i)){
                store[i] = store[i] + 1;
            }
            else{
                store.Add(i, 1);
            }
        }
        foreach( char i in t){
            if(store.ContainsKey(i)){
                store[i] = store[i] - 1;
            }
        }
        foreach(var ele in store){
            if(ele.Value != 0){
                return false;
            }
        }
        return true;
    }
}
