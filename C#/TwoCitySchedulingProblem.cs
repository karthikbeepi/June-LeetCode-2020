using System;
using System.Collections.Generic;
using System.Collections;
public class TwoCitySchedProblem {

    class DifferentCityCosts : IComparable<DifferentCityCosts> {
        int _cityACost, _cityBCost, _differenceCost;
        bool _isA;

        public int DifferenceInCosts{
            get => _differenceCost;
        }

        public bool CloserToA {
            get => _isA;
        }

        public int cityA {
            get => _cityACost;
        }

        public int cityB {
            get => _cityBCost;
        }

        public DifferentCityCosts(int[] cost){
            _cityACost = cost[0];
            _cityBCost = cost[1];
            _differenceCost = Math.Abs(_cityACost-_cityBCost);
            if(_cityACost>_cityBCost)
                _isA = false;
            else 
                _isA = true;
        }

        public int CompareTo(DifferentCityCosts ob) {
            return -this._differenceCost.CompareTo(ob._differenceCost);
        }
    }
    public int TwoCitySchedCost(int[][] costs) {

        int sum = 0;
        List<DifferentCityCosts> arr = new List<DifferentCityCosts>();
        foreach(int[] c in costs) {
            arr.Add(new DifferentCityCosts(c));
        }
        arr.Sort();
        int ALength = 0, BLength = 0;
        foreach (DifferentCityCosts candidate in arr) {
            if(ALength < (costs.Length / 2) && candidate.CloserToA) {
                sum += candidate.cityA;
                ALength++;
            } else if(BLength < (costs.Length/2) && !candidate.CloserToA) {
                sum+= candidate.cityB;
                BLength++;
            } else {
                if(ALength < BLength) {
                    sum+= candidate.cityA;
                    ALength++;
                } else {
                    sum+= candidate.cityB;
                    BLength++;
                }
            }
        }
        return sum;
    }

    public static void Main() {
        TwoCitySchedProblem ob = new TwoCitySchedProblem();
        int[][] cost = new int[][] {
            new int [] {259, 770}, 
            new int [] {448, 54}, 
            new int [] {926, 667}, 
            new int [] {840, 118},
            new int [] {184, 139},
            new int [] {577, 469}};
        Console.WriteLine(ob.TwoCitySchedCost(cost));
    }
}