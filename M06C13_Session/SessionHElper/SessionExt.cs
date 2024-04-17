//using System.Net.Http.Json;

using Newtonsoft.Json;
 

namespace M06C13_Session.SessionHElper
{
    public static class SessionExt
    {
        public static void SetObjInSession(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static List<T> GetObjInSession<T>(this ISession session, string key)
        {
            var obj = session.GetString(key);
            return obj == null ? default(List<T>) : JsonConvert.DeserializeObject<List<T>>(obj);
        }
        public static T GetSessionObj<T>(this ISession session, string key)
        {
            var obj = session.GetString(key);
            return obj == null ? default(T) : JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
