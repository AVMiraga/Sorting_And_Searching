// ========================================
// - Sorting Algorithms -
// ========================================

// ========================================
// - Miraga Aliyev [Heap Sort] -
// ========================================

//Create Heap Sort Algorithm
//using System;

//static void heapSort(int[] arr)
//{
//    int n = arr.Length;

//    // Build heap (rearrange array)
//    for (int i = n / 2 - 1; i >= 0; i--)
//        heapify(arr, n, i);

//    // One by one extract an element from heap
//    for (int i = n - 1; i >= 0; i--)
//    {
//        // Move current root to end
//        int temp = arr[0];
//        arr[0] = arr[i];
//        arr[i] = temp;

//        // call max heapify on the reduced heap
//        heapify(arr, i, 0);
//    }
//}

//static void heapify(int[] arr, int n, int i)
//{
//    int largest = i; // Initialize largest as root
//    int l = 2 * i + 1; // left = 2*i + 1
//    int r = 2 * i + 2; // right = 2*i + 2

//    // If left child is larger than root
//    if (l < n && arr[l] > arr[largest])
//        largest = l;

//    // If right child is larger than largest so far
//    if (r < n && arr[r] > arr[largest])
//        largest = r;

//    // If largest is not root
//    if (largest != i)
//    {
//        int swap = arr[i];
//        arr[i] = arr[largest];
//        arr[largest] = swap;

//        // Recursively heapify the affected sub-tree
//        heapify(arr, n, largest);
//    }
//}

////A utility function to print array of size n
//static void printArray(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 0; i < n; ++i)
//        Console.Write(arr[i] + " ");
//    Console.Read();
//}

//// Driver code

//int[] arr = { 12, 11, 13, 5, 6, 7 };
//int n = arr.Length;

//heapSort(arr);

//Console.WriteLine("Sorted array is");
//printArray(arr);

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Javidan Alizada [Merge Sort] -
// ========================================

//int[] dizi = { 12, 11, 13, 5, 6, 7 };
//Console.WriteLine("Sıralanmadan əvvəl massiv: ");
//foreach (var item in dizi) { Console.Write(item + " "); }
//MergeSort(dizi);
//Console.WriteLine("Sıralandıqdan sonra massiv: "); foreach (var item in dizi) { Console.Write(item + " "); }
//static void MergeSort(int[] dizi)
//{
//    int n = dizi.Length; if (n <= 1)
//    { return; }
//    int orta = n / 2;
//    int[] solDizi = new int[orta]; int[] sagDizi = new int[n - orta];
//    for (int i = 0; i < orta; i++)
//    {
//        solDizi[i] = dizi[i];
//    }
//    for (int i = orta; i < n; i++)
//    {
//        sagDizi[i - orta] = dizi[i];
//    }
//    MergeSort(solDizi);
//    MergeSort(sagDizi);
//    int solIndex = 0, sagIndex = 0, index = 0;
//    while (solIndex < orta && sagIndex < (n - orta))
//    {
//        if (solDizi[solIndex] <= sagDizi[sagIndex])
//        {
//            dizi[index] = solDizi[solIndex]; solIndex++;
//        }
//        else { dizi[index] = sagDizi[sagIndex]; sagIndex++; }
//        index++;
//    }
//    while (solIndex < orta)
//    {
//        dizi[index] = solDizi[solIndex];
//        solIndex++;
//        index++;
//    }
//    while (sagIndex < (n - orta))
//    {
//        dizi[index] = sagDizi[sagIndex];
//        sagIndex++;
//        index++;
//    }
//}

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Gunel Khanaliyeva [Selection Sort] -
// ========================================

//int[] arr = { 11, 4, 0, 7, 0, 2, 4 };
//int n = arr.Length;
//for (int i = 0; i < n - 1; i++)
//{
//    int min_ind = i;
//    for (int j = i + 1; j < n; j++)
//        if (arr[j] < arr[min_ind])
//            min_ind = j;
//    int temp = arr[min_ind];
//    arr[min_ind] = arr[i];
//    arr[i] = temp;
//}
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Zivar Hasanova [Insertion Sort] -
// ========================================

//int count = 0;
//int[] arr = { 5, 6, 11, 12, 13 };
//for (int i = 1; i < arr.Length; i++)
//{
//    int j = i - 1;
//    int key = arr[i];
//    Console.WriteLine(count);
//    while (j >= 0 && arr[j] > key)
//    {
//        arr[j + 1] = arr[j];
//        j--;

//    }
//    arr[j + 1] = key;
//}

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - End Of Sorting Algorithms -
// ========================================

// ========================================
// - Search Algorithms -
// ========================================

// ========================================
// - Miraga Aliyev [Fibonacci Search] -
// ========================================

//static int FibonacciSearch(int[] array, int target)
//{
//    //Initialize fibonacci numbers
//    int fibMMm2 = 0;
//    int fibMMm1 = 1;
//    int fibM = fibMMm2 + fibMMm1;

//    //fibM is going to store the smallest Fibonacci Number greater than or equal to array.Length
//    while (fibM < array.Length)
//    {
//        fibMMm2 = fibMMm1;
//        fibMMm1 = fibM;
//        fibM = fibMMm2 + fibMMm1;
//    }

//    int offset = -1;
//    //while there are elements to be inspected.
//    while (fibM > 1)
//    {
//        int i = Math.Min(offset + fibMMm2, array.Length - 1);
//        //if target is greater than the value at index fibMMm2, cut the subarray array from offset to i
//        if (array[i] < target)
//        {
//            fibM = fibMMm1;
//            fibMMm1 = fibMMm2;
//            fibMMm2 = fibM - fibMMm1;
//            offset = i;
//        }

//        else if (array[i] > target) //if target is greater than the value at index fibMMm2, cut the subarray after i+1
//        {
//            fibM = fibMMm2;
//            fibMMm1 = fibMMm1 - fibMMm2;
//            fibMMm2 = fibM - fibMMm1;
//        }

//        else return i; //element found
//    }
//    if (fibMMm1 == 1 && array[offset + 1] == target)
//        return offset + 1;

//    return -1;
//}

////Driver Code
//int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int target = 5;
//int index = FibonacciSearch(array, target);
//Console.WriteLine("Index of {0} is {1}", target, index); //{0} is a placeholder for target, {1} is a placeholder for index

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Zivar Hasanova [Jump Search] -
// ========================================

//int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
//int target = 17;
//int n = arr.Length;
//int step = (int)Math.Sqrt(n); // step= (int)sqrt(10)=3
//int prev = 0;
//while (arr[Math.Min(step, n) - 1] < target)
//{
//    prev = step;
//    step += (int)Math.Sqrt(n);
//    if (prev >= n)
//    {
//        Console.WriteLine("Element not found in the array");
//    }
//}
//while (arr[prev] < target)
//{
//    prev++;
//    if (prev == Math.Min(step, n))
//    {
//        Console.WriteLine("Element not found in the array");
//    }
//}
//if (arr[prev] == target)
//    Console.WriteLine("The index of target element: " + prev);
//else
//    Console.WriteLine("Element not found in the array");

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Gunel Khanaliyeva [Binary Search] -
// ========================================

//int input = 8;
//int[] arr = { 5, 56, 8, 9, 7, 0, 6 };
//int low = 0;
//int high = arr.Length - 1;
//int mid = default(int);
//while (low <= high)
//{
//    mid = (low + high) / 2;
//    if (arr[mid] == input)
//    {
//        Console.WriteLine("your number is found" + mid);
//        break;
//    }
//    else if (arr[mid] > input)
//    {
//        high = mid - 1;
//    }
//    else
//    {
//        low = mid + 1;
//    }
//}

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - Javidan Alizada [Ternary Search] -
// ========================================

//int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int aranan = 6;
//int sonuc = TernarySearch(dizi, aranan);
//if (sonuc == -1)
//    Console.WriteLine("Aranan öğe bulunamadı.");
//else
//    Console.WriteLine("Aranan öğe " + aranan + " indeksinde bulundu: " + sonuc);
// static int TernarySearch(int[] dizi, int aranan)
//{
//    int sol = 0;
//    int sag = dizi.Length - 1;
//    while (sol <= sag)
//    {
//        int aralik = (sag - sol) / 3;
//        int mid1 = sol + aralik;
//        int mid2 = sag - aralik;
//        if (dizi[mid1] == aranan)
//            return mid1;
//        if (dizi[mid2] == aranan)
//            return mid2;
//        if (aranan < dizi[mid1])
//            sag = mid1 - 1;
//        else if (aranan > dizi[mid2])
//            sol = mid2 + 1;
//        else
//        {
//            sol = mid1 + 1;
//            sag = mid2 - 1;
//        }
//    }
//    return -1;
//}

// ========================================
// - End Of Code -
// ========================================

// ========================================
// - End Of Searching Algorithms -
// ========================================