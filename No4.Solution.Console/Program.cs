namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator bytesFileGenerator = new RandomBytesFileGenerator();
            bytesFileGenerator.GenerateFiles(1, 20);

            RandomFileGenerator charsFileGenerator = new RandomCharsFileGenerator();
            charsFileGenerator.GenerateFiles(1, 20);
        }
    }
}
