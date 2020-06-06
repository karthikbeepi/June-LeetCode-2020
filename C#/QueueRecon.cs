using System;
using System.Collections.Generic;

class QueueReconstruction {
    public int[][] ReconstructQueue(int[][] people) {

        Array.Sort(people, (x, y) => {
            if(x[0]==y[0] ) {
                return x[1]-y[1];
            } else {
                return -x[0]+y[0];
            }
        });

        List<int[]> list = new List<int[]>();
        for (int i = 0; i < people.Length; i++) {
            list.Insert(people[i][1], people[i]); 
        }
        return list.ToArray();
    }

    // public static void Main() {
    //     QueueReconstruction ob = new QueueReconstruction();
    //     int[][] res = ob.ReconstructQueue(new int[][] {
    //         new int[2] {7, 0},
    //         new int[2] {4, 4},
    //         new int[2] {7, 1},
    //         new int[2] {5, 0},
    //         new int[2] {6, 1},
    //         new int[2] {5, 2}
    //     });
    // }
}