using ManageExamination.Models;
using Microsoft.EntityFrameworkCore;

namespace ManageExamination.Data
{
    public class ExamContext : DbContext
    {
        public ExamContext(DbContextOptions<ExamContext> options) : base(options)
        {
                
        }
        public DbSet<Questions> Question { get; set; }
    }
}
