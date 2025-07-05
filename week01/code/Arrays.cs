public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        //create a lenth of the double var
        //for loop to go trhough the length and add to the results
        //return the datza

         // have to start ou t with an array first so ill get the length of the double var passed through and make it an array
        var results = new double[length];
        
        // have to do a for loop through the length of the array and store it 
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        // return it so the test can fail or pass it
        return results; 
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
        //create a number in a var of data.count minus amount
        //create a list of the range of the data vs the amount
        //add the remove range and insert it at the beginning
        
         // I think I should subtract the data for the count of the data vs the amount
        int subtrationOfData = data.Count - amount;

        // creat a list of the data with the range of the subtrated data vs the amount
        List<int> elementsToMove = data.GetRange(subtrationOfData, amount);

        // remove the range, because just using the list i created above didnt work and the numbers in the list were not ordered
        data.RemoveRange(subtrationOfData, amount);

        // insert the elements to move at the first of the list so it can be ordered correctly 
        data.InsertRange(0, elementsToMove);
    }
}
