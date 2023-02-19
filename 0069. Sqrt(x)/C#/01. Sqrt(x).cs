public class Solution {
    public int MySqrt(int x) {
        long res = x;
        while (res*res > x)
            res = (res + x/res) / 2;
        return (int) res;
    }
}