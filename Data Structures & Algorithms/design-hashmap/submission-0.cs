public class MyHashMap {
    private readonly int[] values;
    private readonly bool[] exists;

    public MyHashMap() {
        values = new int[1_000_001];
        exists = new bool[1_000_001];
    }
    
    public void Put(int key, int value) {
        values[key] = value;
        exists[key] = true;
    }
    
    public int Get(int key) {
        return exists[key] ? values[key] : -1;
    }
    
    public void Remove(int key) {
        exists[key] = false;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */