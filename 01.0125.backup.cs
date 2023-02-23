using System.Text.RegularExpressions;

public class Solution {

    public bool IsPalindrome(string s) {

            string regExp = @"[^0-9A-Za-z]";

            string tmp = Regex.Replace(s, regExp, "").Replace(" ", string.Empty).ToLower();

            return new string(tmp.Reverse().ToArray()).Equals(tmp);

    }

}

my computers is dead sorry :(
i am written this code with xiaomi note 11
