public class Solution {
    public class TrieNode {
        public TrieNode[] Children = new TrieNode[26];
        public bool IsWord;
    }

    public string LongestCommonPrefix(string[] strs) {
        TrieNode root = new TrieNode();

        foreach (string word in strs) {
            TrieNode current = root;

            foreach (char c in word) {
                int index = c - 'a';

                if (current.Children[index] == null)
                    current.Children[index] = new TrieNode();

                current = current.Children[index];
            }

            current.IsWord = true;
        }

        // Find common prefix
        TrieNode node = root;
        StringBuilder prefix = new StringBuilder();

        while (true) {
            int childCount = 0;
            int nextIndex = -1;

            for (int i = 0; i < 26; i++) {
                if (node.Children[i] != null) {
                    childCount++;
                    nextIndex = i;
                }
            }

            if (childCount != 1)
                break;

            if (node.Children[nextIndex].IsWord) {
                prefix.Append((char)('a' + nextIndex));
                break;
            }

            prefix.Append((char)('a' + nextIndex));
            node = node.Children[nextIndex];
        }

        return prefix.ToString();
    }
}