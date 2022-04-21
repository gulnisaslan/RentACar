using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FakeCard:IEntity
    {
        public int Id { get; set; }
        public string CardNo { get; set; }
        public string CustomerNameSurname { get; set; }
        public string Expires { get; set; }
        public Int16 CVC { get; set; }
    }
}
