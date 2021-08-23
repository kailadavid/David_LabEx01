namespace David_LabEx01.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly David_LabEx01DbContext _context;

        public InitialHostDbBuilder(David_LabEx01DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
