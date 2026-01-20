using System;
    public class AadharManager {
        private long[] aadharNumbers;
        private RadixSorter sorter;
        private BinarySearcher searcher;
        public AadharManager(){
            sorter = new RadixSorter();
            searcher = new BinarySearcher();
            aadharNumbers = new long[]{234567890123,134567890123,234567890120,13456789012};
        }
        //display
        public void Display(){
            foreach(long num in aadharNumbers){
                Console.WriteLine(num);
            }
        }
        //sort adhar
        public void SortAadhar(){
            sorter.Sort(aadharNumbers);
            Console.WriteLine("Aadhar Numbers Sorted Successfully");
        }
        //search adhar
        public void SearchAadhar(long key){
            int index = searcher.Search(aadharNumbers, key);
            if(index != -1)
                Console.WriteLine("Aadhar Found at index: " + index);
            else
                Console.WriteLine("Aadhar Not Found");
        }
    }

