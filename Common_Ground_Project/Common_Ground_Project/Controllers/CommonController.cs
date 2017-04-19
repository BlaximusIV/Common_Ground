using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Ground_Project.DataAccess;
using Common_Ground_Project.Models;

namespace Common_Ground_Project.Controllers
{
    public class CommonController
    {
        // private Repository references.
        private IndividualSql ParticipantData;

        public CommonController()
        {
            // Initialize repositories
            ParticipantData = new IndividualSql();
        }



    }
}
