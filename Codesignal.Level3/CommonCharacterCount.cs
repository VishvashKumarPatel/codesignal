namespace Codesignal.Level3
{
    public class CommonCharacterCount
    {
        public static int commonCharacterCount(string s1, string s2)
        {
            int[] a = new int[26], b = new int[26];
            foreach (char c in s1) a[c - 'a']++;
            foreach (char c in s2) b[c - 'a']++;
            int s = 0;
            for (int i = 0; i < 26; i++) s += Math.Min(a[i], b[i]);
            return s;
        }

    }
}