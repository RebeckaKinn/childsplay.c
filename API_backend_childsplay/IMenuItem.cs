namespace API_backend_childsplay
{
    public interface IMenuItem
    {
        string Name { get; set; }
        string Description { get; set; }
        string Img { get; set; }
        Guid Id { get; }
    }
}
