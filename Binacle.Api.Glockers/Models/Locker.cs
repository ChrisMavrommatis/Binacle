using Binacle.Lib.Components.Extensions;
using Binacle.Lib.Components.Models;

namespace Binacle.Api.Glockers.Models
{
    public class Locker : IWithDimensions
    {
        public Locker()
        {
            
        }

        public Locker(int size, IWithDimensions item)
        {
            this.Size = size;
            this.CopyDimensionsFrom(item);
        }

        public int Size { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
