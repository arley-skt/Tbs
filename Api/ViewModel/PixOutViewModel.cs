using Data.Domain;

namespace Api.ViewModel
{
    public class PixOutViewModel
    {
        public PixOutViewModel()
        {
        }
        public Guid? Id { get; set; }
        public string? Nome { get; set; }

        public bool validaid(Guid? id)
        {
            if (id == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
