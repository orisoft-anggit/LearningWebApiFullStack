using System.ComponentModel.DataAnnotations;

namespace Web.Api.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public Guid id { get; set; }

        public string? createdBy { get; set; }

        public DateTimeOffset? createdAt { get; set; }

        public string? updatedBy { get; set; }

        public DateTimeOffset? updatedAt { get; set; }

        public string? deletedBy { get; set; }

        public DateTimeOffset? deletedAt { get; set; }
    }
}