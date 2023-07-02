namespace ConsoleGame
{
    public static class ListExtension
    {
        public static int LastIndex<T>(this List<T> list)
        {
            return list.Count - 1;
        }
    }
}
