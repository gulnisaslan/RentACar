using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DtOs
{
    public   class RentDetailDTOs: IDTo
    {
        public int Id { get; set; }
         public int  CarId { get; set; }
        public string CarName { get; set; }
        public string  UserName { get; set; }
         public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
