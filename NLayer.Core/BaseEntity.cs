using System;
namespace NLayer.Core
{
    //abstract olduğu için new lenemez..
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
