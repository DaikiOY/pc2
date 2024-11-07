namespace si730pc2u20201f846.API.WMS.Application.Internal.Commands
{
    /// <summary>
    /// Command to create a new category.
    /// </summary>
    public class CreateCategoryCommand
    {
        public string Name { get; set; } 
        public CreateCategoryCommand(string name)
        {
            Name = name;
        }
    }
}
