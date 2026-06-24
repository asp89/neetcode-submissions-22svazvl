/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head is null)
            return null;

        Node node = head;

        while (node != null) {
            Node next = node.next;
            Node newNode = new Node(node.val);

            node.next = newNode;
            newNode.next = next;

            node = next;
        }

        node = head;
        while (node != null) {
            if (node.random != null)
                node.next.random = node.random.next;

            node = node.next.next;
        }
        Node ans = head.next;
        node = head;

        while (node != null) {
            Node node1 = node.next;
            node.next = node1.next;

            if (node.next != null) {
                node1.next = node.next.next;
            }

            node = node.next;
        }

        return ans;
    }
}
