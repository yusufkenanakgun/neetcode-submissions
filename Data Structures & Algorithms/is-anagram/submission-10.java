class Solution {
    public boolean isAnagram(String s, String t) {
        char[] a = s.toCharArray();
        char[] b = t.toCharArray();

        Arrays.sort(a);
        Arrays.sort(b);

        String key1 = new String(a);
        String key2 = new String(b);
        if(key1.equals(key2)){
            return true;
        }
        return false;
    }
}
