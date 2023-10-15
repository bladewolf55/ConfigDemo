using System.Web.Configuration;

namespace ConfigFramework
{
    public static class Settings
    {
        public static string TestKey = WebConfigurationManager.AppSettings["TestKey"];
    }
}