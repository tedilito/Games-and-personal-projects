

//int[] numbers = new int[20];

//for (int i = 0; i < numbers.Length; i++)
//{

//    numbers[i] = int.Parse(Console.ReadLine());
//}

//SortArray(numbers);


//void SortArray(int[] numbers)
//{
//    QuickSort(numbers, 0, numbers.Length - 1);
//}

//void QuickSort(int[] numbers, int left, int right)
//{
//    int i = left;
//    int j = right;

//    var pivot = numbers[left];

//    while (i <= j)
//    {
//        while (numbers[i] < pivot)
//        {
//            i++;
//        }
//        while (numbers[j] > pivot) 
//        {  
//            j--; 
//        }

//        if (i <= j)
//        {
//            var tmp = numbers[i];
//            numbers[i] = numbers[j];
//            numbers[j] = tmp;
//            i++;
//            j--;
//        }
//    }

//    if (left < j )
//    {
//        QuickSort(numbers, left, i);
//    }

//    if (i < right)
//    {
//        QuickSort(numbers, i, right);
//    }

//}
//foreach (var number in numbers)
//{
//    Console.WriteLine(" "+number);

//}

//***************************************************CHAR********************************************************************************


//char[] chars = new char[] { 'b', 'a', 'x','y' ,'z' , 'c' };


//sortChars(chars);

//void sortChars(char[] chars)
//{
//    qickSort(chars,0, chars.Length-1);
//}

//void qickSort(char[] chars, int left, int right)
//{
//    int i = left;
//    int j = right;

//    var pivot = chars[left];


//    while (i <= j)
//    {
//        while (chars[i] < pivot)
//        {
//            i++;
//        }

//        while (chars[j] > pivot)
//        {
//            j--;
//        }


//        if (i <= j)
//        {
//            var tmp = chars[i];
//            chars[i] = chars[j];
//            chars[j] = tmp;

//            i++;
//            j--;
//        }
//    }

//    if (left < j)
//    {
//        qickSort(chars, left, j);
//    }


//    if (i < right)
//    {
//        qickSort(chars, i, right);
//    }
//}

//foreach (char cha in chars)
//{
//    Console.WriteLine(cha);
//}




