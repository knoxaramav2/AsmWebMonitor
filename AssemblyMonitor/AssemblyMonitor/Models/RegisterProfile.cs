using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AssemblyMonitor.Models;

namespace AssemblyMonitor.Models
{
    public class RegisterProfile : DbContext
    {
        [Key]
        public string Id { get; set; }

        public List<Register> Registers { get; set; }

        public RegisterProfile
            (DbContextOptions<RegisterProfile> options) : base(options)
        {

        }

        public DbSet<AssemblyMonitor.Models.Register> Register { get; set; }
    }

    public class Register
    {
        [Key]
        public string name { get; set; }
        public int width { get; set; }

        List<SubRegister> SubRegisters { get; set; }
    }

    public class SubRegister
    {
        [Key]
        public string name { get; set; }
        public int width { get; set; }
    }
}
