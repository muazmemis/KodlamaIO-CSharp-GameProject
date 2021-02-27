using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Sale : IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CustomerId { get; set; }
    }
}
