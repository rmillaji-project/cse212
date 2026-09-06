public static class Arrays
{
    /// Firstly: creation of double array with lenght
    
    public static double[] MultiplesOf(double number, int length)
{
    // Step 1: Create a double array with the specified length.
    // Step 2: Loop through each position in the array.
    // Step 3: Calculate the multiple of the number using the position + 1.
    // Step 4: Store the calculated multiple in the current array position.
    // Step 5: Return the completed array.

    double[] result = new double[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = number * (i + 1);
    
    }
    return result;
}
    /// <summary>
   /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
         // Step 1: Get the last 'amount' elements and save them.
        // Step 2: Remove those elements from the end of the list.
       // Step 3: Insert the saved elements at the beginning of the list.
     var lastItems = data.GetRange(data.Count - amount, amount);
     
     
     data.RemoveRange(data.Count - amount, amount);
     

     data.InsertRange(0, lastItems);
    }
}
