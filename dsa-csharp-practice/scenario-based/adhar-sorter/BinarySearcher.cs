namespace AadharRadixSort {

    public class BinarySearcher {

        public int Search(long[] arr, long key){
            int low = 0, high = arr.Length - 1;
            while(low <= high){
                int mid = (low + high) / 2;
                if(arr[mid] == key){
                    return mid;
                }else if(arr[mid] < key){
                    low = mid + 1;
                }else {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}
