using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace Backend_MusicTime.Customer.Domain.Model.Aggregates;

public partial class Customer : IEntityWithCreatedUpdatedDate
{
    [Column("CreatedAt")]public DateTimeOffset? CreatedDate { get; set; }
    [Column("UpdatedAt")]public DateTimeOffset? UpdatedDate { get; set; }
}