using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        PlayersContext context = new PlayersContext();

        // GET api/values
        public IEnumerable<Player> GetPlayers()
        {
            return context.Players;
        }

        // GET api/values/5
        public Player GetPlayer(int id)
        {
            Player player = context.Players.Find(id);
            return player;
        }

        // POST api/values
        [HttpPost]
        public void CreatePlayer([FromBody]Player player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        public void EditPlayer(int id, [FromBody]Player value)
        {
            if (id == value.Id)
            {
                context.Entry(value).State = EntityState.Modified;
                //edit player there
                context.SaveChanges();
            }
        }

        // DELETE api/values/5
        [HttpDelete]
        public void DeletePlayer(int id)
        {
            Player player = context.Players.Find(id);
            if (player != null)
            {
                context.Players.Remove(player);
                context.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
