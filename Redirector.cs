using ThemeMixer.RedirectionFramework.Extensions;

namespace ThemeMixer.RedirectionFramework
{
    public class Redirector<T>
    {
        public static void Deploy()
        {
            typeof(T).Redirect();
        }

        public static void Revert()
        {
            typeof(T).Revert();
        }

        public static bool IsDeployed()
        {
            return typeof(T).IsRedirected();
        }
    }
}