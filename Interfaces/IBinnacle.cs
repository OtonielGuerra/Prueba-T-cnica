namespace Jonathan_Guerra.Interfaces
{
    public interface IBinnacle
    {
        void add(object elemento);
        void update(object elemento);
        void delete(object elemento);
        object search(string id);
        void find();
        void ShowDetail(string type);
    }
}