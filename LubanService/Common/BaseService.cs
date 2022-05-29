namespace LubanService
{
    public class BaseService<T> where T : BaseService<T>, new()
    {
        static T s_Service;

        public static T S
        {
            get
            {
                if (s_Service != null)
                {
                    return s_Service;
                }

                s_Service = new T();
                s_Service.Init();

                return s_Service;
            }
        }

        protected virtual void Init() { }
    }
}