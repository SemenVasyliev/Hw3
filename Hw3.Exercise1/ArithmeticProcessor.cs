namespace Hw3.Exercise1
{
    public static class ArithmeticProcessor
    {
        /// <summary>
        /// Calculates numbers by algorithm.
        /// </summary>
        /// <param name="numbers">Collection of numbers.</param>
        /// <returns>
        /// Returns <c>IEnumerable</c> of sorted numbers. 
        /// </returns>
        /// <exception cref="ArgumentNullException">Sequence is null.</exception>

        public static IEnumerable<int> Calculate(List<int> numbers)
        {
            var itemsPaired = numbers.Select((item, index) => new { Item = item, Index = index })
                .Where(n => n.Index % 2 == 0)
                .Select(n => n.Item);

            var itemsUnpaired = numbers.Select((item, index) => new { Item = item, Index = index })
                .Where(n => n.Index % 2 == 1)
                .Select(n => n.Item);

            itemsPaired = itemsPaired.Select(x => x * 2);
            itemsUnpaired = itemsUnpaired.Select(x => x - 10);
            var result = itemsPaired.Concat(itemsUnpaired).Distinct();
            result = result.OrderBy(x => x);
            return result;
        }
    }
}
