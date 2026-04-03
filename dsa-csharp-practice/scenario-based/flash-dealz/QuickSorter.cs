class QuickSorter{
    public void QuickSort(Product[] products, int low, int high){
        // Check if sorting range is valid
        if (low < high){
            // Find the correct position of pivot
            int pivotIndex = Partition(products, low, high);
             // Recursively sort left side of pivot
            QuickSort(products, low, pivotIndex - 1);
            // Recursively sort right side of pivot
            QuickSort(products, pivotIndex + 1, high);
        }
    }
    // Partition method places pivot at correct position
    private int Partition(Product[] products, int low, int high){
        double pivot = products[high].Discount;
        int i = low - 1;
        for (int j = low; j < high; j++){
            if (products[j].Discount > pivot){
                i++;
                Swap(products, i, j);
            }
        }
        Swap(products, i + 1, high);
        return i + 1;
    }
    // Swap method to exchange two products
    private void Swap(Product[] products, int i, int j){
        Product temp = products[i];
        products[i] = products[j];
        products[j] = temp;
    }
}
