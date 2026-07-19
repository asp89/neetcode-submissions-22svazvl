public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder result = new();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;

            if (i >= 0) {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0) {
                sum += b[j] - '0';
                j--;
            }

            result.Append(sum % 2);
            carry = sum / 2;
        }

        char[] arr = result.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

// public string AddBinary(string a, string b) {

//         // Loop as long as there are characters left to process or a carry exists
//         while (i >= 0 || j >= 0 || carry > 0) {
//         }

//         // The result is built backwards, so reverse it
//         char[] arr = result.ToString().ToCharArray();
//         Array.Reverse(arr);
//         return new string(arr);
//     }