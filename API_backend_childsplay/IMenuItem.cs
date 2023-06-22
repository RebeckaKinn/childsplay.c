namespace API_backend_childsplay
{
    public interface IMenuItem
    {
        string Name { get; }
        string Description { get; }
        string Img { get; }
        Guid Id { get; }
    }
}
