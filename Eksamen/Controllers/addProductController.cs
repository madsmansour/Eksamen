using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Eksamen.Controllers
{
    public class AddProductController : Controller
    {
        public string Index(int productId, int antal)
        {
            // Gemme i databasen
            string sessionID = HttpContext.Session.Id;
            return antal + " stykker af varenummer " + productId + " er tilføjet. Dit session ID er " + sessionID ;

        }
    }
}