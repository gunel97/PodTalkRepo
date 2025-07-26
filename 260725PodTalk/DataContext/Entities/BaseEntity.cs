using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Data;

namespace _260725PodTalk.DataContext.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
