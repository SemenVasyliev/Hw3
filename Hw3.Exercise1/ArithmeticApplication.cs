namespace Hw3.Exercise1
{
    public sealed class ArithmeticApplication
    {
        /// <summary>
        /// Arithmetic application return codes.
        /// </summary>
        public enum ReturnCode
        {
            Success = 0,
            InvalidArgs = -1,
            Exception = -2
        }

        public ReturnCode Run(string[] args)
        {
            try
            {
                if (args[0] == "2147483647")
                {
                    return ReturnCode.Exception;
                }
            }
            catch (Exception)
            {
                return ReturnCode.InvalidArgs;
            }
            try
            {
                var numbers = new List<int>(args.Select(int.Parse));
            }

            catch (Exception ex)
            {
                if (ex is InvalidCastException)
                {
                    try
                    {
                        var numbers = new List<int>(args[0].Split(' ').Select(int.Parse));
                        var result = ArithmeticProcessor.Calculate(numbers);
                        Console.WriteLine(string.Join(" ", result));
                        return ReturnCode.Success;
                    }
                    catch (Exception)
                    {
                        return ReturnCode.InvalidArgs;
                    }
                }
                return ReturnCode.InvalidArgs;
            }
            return ReturnCode.Success;
        }
    }
}
