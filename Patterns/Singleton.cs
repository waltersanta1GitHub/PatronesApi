namespace PatronesApi.Patterns;

public sealed class Singleton
{
    readonly Guid _guid;
    private Singleton(){

        _guid = Guid.NewGuid();

    }

    private static Singleton _instance;

    public static Singleton GetSingletonInstance(){
        if (_instance == null)
        {
            _instance = new Singleton();
            
        }
        return _instance;
    }

    public string Grettings(){

        return $"My Id de instancia es:{_guid.ToString()}";

    }
}