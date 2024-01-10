namespace CustomerManagement.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// this method:  insert a space before each uppercase letter in a given string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpace(this string source)
        {

            string result= string.Empty; // " ";

            if(!string.IsNullOrWhiteSpace(source)) 
            {
            
                foreach(char letter in source)
                {
                  if(char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}