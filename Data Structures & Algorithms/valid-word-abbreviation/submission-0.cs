public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        if (word == abbr)
            return true;

        int i = 0;
        int j = 0;

        while (i < word.Length && j < abbr.Length) {
            if (char.IsDigit(abbr[j])) {
                if(abbr[j] == '0') return false;

                int count = 0;
                while (j < abbr.Length && char.IsDigit(abbr[j])) {
                    count = count * 10 + (abbr[j] - '0');
                    j++;
                }

                i += count;

                if (i > word.Length)
                    return false;
            } else {
                if (word[i] != abbr[j])
                    return false;

                i++;
                j++;
            }
        }

        return i == word.Length && j == abbr.Length;
    }
}