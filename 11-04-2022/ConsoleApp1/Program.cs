namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AtBashEncryption(args[0]));
        }

        private static string AtBashEncryption(string text)
        {
            char[] charArray = text.ToCharArray();
            char[] newCharArray = new char[charArray.Length];

            int result;
            for(int i = 0; i < charArray.Length; i++)
            {
                if ((int)charArray[i] >= 97 && (int)charArray[i] <= 122)
                {
                    result = 122 - ((int)charArray[i] % 97);
                    newCharArray[i] = (char)result;
                }
                else if ((int)charArray[i] >= 65 && (int)charArray[i] <= 90)
                {
                    result = 90 - ((int)charArray[i] % 65);
                    newCharArray[i] = (char)result;
                }
                else
                {
                    newCharArray[i] = charArray[i];
                }
            }
            return String.Join("", newCharArray);
        }
    }
}