namespace CustomerManagement.Common
{
    public class StringHandler
    {
        // this method:  insert a space before each uppercase letter in a given string
        public string InsertSpace(string source)
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