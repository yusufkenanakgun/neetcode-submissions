public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var times = new double[position.Length];
        int fleet = 1;
        var cars = new (int pos, int spd)[position.Length];


        for (int i = 0; i < position.Length; i++){
            cars[i] = (position[i], speed[i]);
        }

        Array.Sort(cars, (a,b) => b.pos.CompareTo(a.pos));


        for (int i = 0; i < position.Length; i++){
            times[i] = (double)(target - cars[i].pos)/cars[i].spd;
        }
        
        for (int i = 0; i < position.Length -1 ; i++){
            if (times[i] < times[i+1] ){
                fleet++;
            } else{
                times[i+1] = times[i];
            }
        }

        return fleet;

        
    }
}
