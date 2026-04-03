using System;

class Program{
    static void Main(){
        Console.WriteLine("=== DYNAMIC ONLINE MARKETPLACE ===\n");
        var bookCatalog = new ProductCatalog<Product<BookCategory>>();
        var clothingCatalog = new ProductCatalog<Product<ClothingCategory>>();
        // -------- BOOK INPUT --------
        Console.Write("Enter number of Book products: ");
        int bookCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < bookCount; i++){
            Console.WriteLine($"\nEnter details for Book {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Genre: ");
            string genre = Console.ReadLine();
            var book = new Product<BookCategory>(id,name,price,new BookCategory(genre));
            bookCatalog.AddProduct(book);
        }
        // -------- CLOTHING INPUT --------
        Console.Write("\nEnter number of Clothing products: ");
        int clothCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < clothCount; i++){
            Console.WriteLine($"\nEnter details for Clothing Item {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Size: ");
            string size = Console.ReadLine();
            var cloth = new Product<ClothingCategory>(id,name,price,new ClothingCategory(size));
            clothingCatalog.AddProduct(cloth);
        }
        // -------- DISPLAY CATALOGS --------
        Console.WriteLine("\n---- Book Catalog ----");
        bookCatalog.DisplayCatalog();
        Console.WriteLine("\n---- Clothing Catalog ----");
        clothingCatalog.DisplayCatalog();
        // -------- DISCOUNT FEATURE --------
        Console.Write("\nDo you want to apply discount to a book? (yes/no): ");
        string choice = Console.ReadLine().ToLower();
        if (choice == "yes"){
            Console.Write("Enter Book ID to apply discount: ");
            int discountId = int.Parse(Console.ReadLine());
            var books = bookCatalog.GetAllProducts();
            Product<BookCategory> selectedBook = null;
            foreach (var b in books){
                if (b.Id == discountId){
                    selectedBook = b;
                    break;
                }
            }
            if (selectedBook != null){
                Console.Write("Enter discount percentage: ");
                double percent = double.Parse(Console.ReadLine());
                DiscountService.ApplyDiscount(selectedBook, percent);
                Console.WriteLine("\nUpdated Book Catalog:");
                bookCatalog.DisplayCatalog();
            }
            else{
                Console.WriteLine("Book not found!");
            }
        }
        Console.ReadLine();
    }
}
