using System;
using System.Collections.Generic;

namespace appDimak.Models
{
    public partial class IntentosModificacion
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public decimal? OldUnitPrice { get; set; }
        public decimal? AttemptedNewPrice { get; set; }
        public DateTime? AttemptedModificationDate { get; set; }
        public string? Reason { get; set; }
    }
}
