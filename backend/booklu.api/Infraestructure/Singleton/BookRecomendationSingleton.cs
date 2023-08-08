namespace booklu.api.Infraestructure.Singleton
{
    public class BookRecomendationSingleton
    {
        private static readonly object _lock = new object();
        private static BookRecomendationSingleton _instance = null;
        private List<string> recomendations = new List<string>();

        //private constructor
        private BookRecomendationSingleton()
        {
        }


        //global method access point
        public static BookRecomendationSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lock) // Asegura que solo un hilo pueda acceder a este bloque a la vez
                    {
                        _instance = new BookRecomendationSingleton();
                    }
                }
                    
                return _instance;
            }    
        }

        public void AddRecomendation(string libro)
        {
            recomendations.Add(libro);
        }

        public List<string> GetRecomendations()
        {
            return recomendations;
        }

    }
}
