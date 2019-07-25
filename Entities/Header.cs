namespace crgolden.Sage100
{
    using System.Collections.Generic;

    public abstract class Header<TLine> : Record
    {
        public virtual ICollection<TLine> Lines { get; set; } = new HashSet<TLine>();
    }
}