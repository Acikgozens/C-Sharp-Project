using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
            builder.ToTable("Employee")
                          .Property(e => e.EmployeeUserName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.Property(x => x.EmployeeName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmployeeLastname).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.EmployeeStatu).HasDefaultValue(true);
            builder.Property(x => x.EmployeeEmail).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.StartDate).HasColumnName("datetime").HasDefaultValueSql("getdate()");
            builder.Property(x => x.SortKey).HasDefaultValue(0);

            builder.HasData(new Employee
            {
                EmployeeName = "Enes",
                EmployeeLastname = "Acikgoz",
                EmployeeStatu = true,
                EmployeeUserName = "acikgozens",
                EmployeeEmail = "enesefea@gmail.com",
                EmployeeId = 1,
                SortKey = 1,
                

            });
    }

}
}
