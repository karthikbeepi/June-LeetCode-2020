using System;

class ShuffleArray{
    public int[] Shuffle(int[] nums, int n) {
        int[] res = new int[2*n];
        int j =0;
        for(int i=0; i<n; i++) {
            res[j] = nums[i];
            j++;
            res[j] = nums[n+i];
            j++;
        }
        return res;    
    }

    // public static void Main() {
    //     ShuffleArray ob = new ShuffleArray();
    //     int[] res = ob.Shuffle(new int[] {1,1,2,2}, 2);
    //     Console.WriteLine();
    // }

}