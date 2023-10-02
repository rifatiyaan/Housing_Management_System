using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagementSystemForAIUBStudents.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Sector { get; set; }
        public string Price { get; set; }
        public int Status { get; set; }
    }
}
