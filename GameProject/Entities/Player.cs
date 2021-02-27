using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Player : IEntity
    {
        public int PlayerId { get; set; }
        public long NationalId { get; set; }
        public string PLayerName { get; set; }
        public string PlayerSurname { get; set; }
        public int DateofBirth { get; set; }
    }
}
