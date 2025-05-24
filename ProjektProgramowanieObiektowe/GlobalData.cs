using ProjektProgramowanieObiektowe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektProgramowanieObiektowe
{
    public static class GlobalData
    {
        public static AppDbContextFactory factory = new AppDbContextFactory();
        public static AppDbContext context = factory.CreateDbContext(null);


    }
}
