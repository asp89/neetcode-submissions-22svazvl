public class MyHashSet {
    private readonly int _keyRange;
    private readonly LinkedList<int>[] _buckets;

    public MyHashSet() {
        _keyRange = 769;
        _buckets = new LinkedList<int>[_keyRange];        
    }
    
    private int Hash(int key) => key % _keyRange;

    public void Add(int key) {
        int bucketIndex = Hash(key);
        if (_buckets[bucketIndex] == null)
            _buckets[bucketIndex] = new LinkedList<int>();
        
        if (!_buckets[bucketIndex].Contains(key)) {
            _buckets[bucketIndex].AddLast(key);
        }
    }
    
    public void Remove(int key) {
        int bucketIndex = Hash(key);
        if (_buckets[bucketIndex] != null)
            _buckets[bucketIndex].Remove(key);
    }
    
    public bool Contains(int key) {
        int bucketIndex = Hash(key);
        return _buckets[bucketIndex] != null && _buckets[bucketIndex].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */