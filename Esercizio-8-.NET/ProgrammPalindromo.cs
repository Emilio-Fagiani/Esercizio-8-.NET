namespace Esercizio_8_.NET
{
    internal class ProgrammPalindromo
    {
        public bool IsPalindromo(string input)
        {
            string cleanedInput = input.Replace(" ","").ToLower();

            int first = 0;  
            int last = cleanedInput.Length - 1;

            while (first < last) 
            {
                if (cleanedInput[first] != cleanedInput[last])
                {
                    return false;
                }    

                first++;
                last--;
            }

            return true;
        }
    }
}
