public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {

        int min = 1;
        int max = piles.Max();
        int result = 0;
        while (min <= max) {
            int k = (max + min) / 2;
            int count = 0;
            for (int i = 0; i < piles.Length; i++){
                count+= (piles[i] + k - 1)/k;
            }
            if (count <= h){
                result = k;
                max = k - 1;
            }else if (count > h){
                min = k +1;
            }
        }
        return result;
        
    }
}
