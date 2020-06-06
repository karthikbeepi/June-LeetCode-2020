using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class RandomWeight{

    private double[] probabilities; 
    public RandomWeight(int[] w) {
        double sum = 0;
        this.probabilities = new double[w.Length];
        foreach(int weight in w)
            sum += weight;
        for(int i = 0; i < w.Length; i++){
            w[i] += (i == 0) ? 0 : w[i - 1];
            probabilities[i] = w[i]/sum; 
        }
    }
    
    public int PickIndex() {
        return Math.Abs(Array.BinarySearch(this.probabilities, new Random().NextDouble())) - 1;
    }
}