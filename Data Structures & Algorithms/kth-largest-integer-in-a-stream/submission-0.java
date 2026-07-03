class KthLargest {
    int k;
    int[] nums;

    public KthLargest(int k, int[] nums) {
        this.k = k;
        this.nums = nums;
    }
    
    public int add(int val) {
        int[] yeni = Arrays.copyOf(this.nums, this.nums.length + 1);
        yeni[yeni.length - 1] = val;
        this.nums = yeni;

        int a = this.k;
        Arrays.sort(this.nums);
        int ptr = this.nums.length ;
        while (a > 0){
            ptr = ptr -1;
            a = a - 1;
        }
        return this.nums[ptr];
    }
}
