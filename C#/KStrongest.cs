using System;

class KStrongest {
    public int[] GetStrongest(int[] arr, int k) {
        int[] res = new int[k];
        // Array.Sort(arr, (x, y) => {
        //     if(Math.Abs(x-median)>Math.Abs(y-median)) {
        //         return 1;
        //     } else if(Math.Abs(x-median)==Math.Abs(y-median)) {

        //     } else 
        //         return -1;
            
        // });
        Array.Sort(arr);
        int medianIndex = ((arr.Length-1)/2);
        int median = arr[medianIndex];
        int noOfStrongest =0;
        int lastIndex = arr.Length-1;
        int begIndex = 0;
        while(noOfStrongest<k) {
            if(Math.Abs(arr[lastIndex]-median)>Math.Abs(arr[begIndex]-median)) {
                res[noOfStrongest] = arr[lastIndex];
                noOfStrongest++;
                lastIndex--;
            } else if(Math.Abs(arr[lastIndex]-median)<Math.Abs(arr[begIndex]-median)) {
                res[noOfStrongest] = arr[begIndex];
                noOfStrongest++;
                begIndex++;
            } else {
                res[noOfStrongest] = arr[lastIndex];
                noOfStrongest++;
                lastIndex--;
            }
        }
        return res;
    }

    // public static void Main() {
    //     KStrongest ob = new KStrongest();
    //     int[] res = ob.GetStrongest(new int[]{1,2,3,4,5}, 2);
    //     res = ob.GetStrongest(new int[]{1,1,3,5,5}, 2);
    //     res = ob.GetStrongest(new int[]{6,7,11,7,6,8}, 5);
    //     res = ob.GetStrongest(new int[]{6,-3,7,2,11}, 3);
    //     res = ob.GetStrongest(new int[]{-7,22,17,3}, 2);

    // }

}