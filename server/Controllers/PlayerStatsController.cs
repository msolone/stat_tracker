using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class PlayerStatsController : ControllerBase {
        private StatTrackerContext db { get; set; }

        public PlayerStatsController () {
            this.db = new StatTrackerContext ();
        }

            // GET api/playerstats
            [HttpGet]
            public ActionResult<IEnumerable<PlayerStats>> Get () {
                return this.db.PlayerStat;
            }

            // POST api/playerstats
            [HttpPost]
            public PlayerStats Post([FromBody] PlayerStats p) {
                this.db.Add(p);
                this.db.SaveChanges();
                return p;
            }
        }
    }