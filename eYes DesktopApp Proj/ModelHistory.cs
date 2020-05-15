namespace eYes_DesktopApp_Proj
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelHistory : DbContext
    {
        public ModelHistory()
            : base("name=ModelHistory")
        {
        }

        public virtual DbSet<RecordHistory> RecordHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
