
void main () {

    string [] stringArray = new string [] {"Hello", "2", "end", "world", "asd"};
    string [] newStringArray = [];

    foreach (string item in stringArray)
    {
        if (item.Length <= 3)
        {
            string [] tempArray = new string [newStringArray.Length];
            Array.Copy(newStringArray, tempArray, newStringArray.Length);
            newStringArray = new string [newStringArray.Length + 1]; 
            Array.Copy(tempArray, newStringArray, tempArray.Length);
            newStringArray[newStringArray.Length - 1] = item;
        }      
    }
}

main();