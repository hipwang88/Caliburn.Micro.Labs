namespace GameLibrary.WPF.Framework.Results
{
    public class Show
    {
        public static OpenChildResult<TChild> Child<TChild>()
        {
            return new OpenChildResult<TChild>();
        }

        public static OpenChildResult<TChild> Child<TChild>(TChild child)
        {
            return new OpenChildResult<TChild>(child);
        }
    }
}