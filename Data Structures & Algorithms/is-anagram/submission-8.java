class Solution {
    public boolean isAnagram(String s, String t) {
    if (s.length() != t.length()) return false;
    
    char[] a = s.toCharArray();
    char[] b = t.toCharArray();
    
    for (int i = 0; i < a.length; i++) {
        boolean bulundu = false;
        for (int j = 0; j < b.length; j++) {
            if (a[i] == b[j]) {
                b[j] = '#';  // gerçekten array'i değiştirir
                bulundu = true;
                break;
            }
        }
        if (!bulundu) return false;
    }
    
        return true;
    }
}
