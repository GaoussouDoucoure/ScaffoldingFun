namespace ScaffoldingFun.Models
{
    /* This sets up the template for what our instances gonna look like */
    public interface IBaseballRepository
    {
        List<Manager> Managers { get; }

        public void AddManager(Manager manager);
    }
}
