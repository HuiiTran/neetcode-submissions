// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        if(pairs.Count == 0) return [];

        List<List<Pair>> result = new List<List<Pair>>(); 
        result.Add(pairs.Select(pair => new Pair(pair.Key, pair.Value)).ToList());
        for(int i = 1; i < pairs.Count; i++){
            int key = pairs[i].Key;
            string value = pairs[i].Value;
            int j = i - 1;
            while(j >= 0 && pairs[j].Key > key){
                pairs[j + 1].Key = pairs[j].Key;
                pairs[j + 1].Value = pairs[j].Value;
                j--;
            }
            pairs[j + 1].Key = key;
            pairs[j + 1].Value = value;

            result.Add(pairs.Select(pair => new Pair(pair.Key, pair.Value)).ToList());
        }
        return result;
    }
}
