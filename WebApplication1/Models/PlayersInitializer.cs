using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PlayersInitializer : DropCreateDatabaseAlways<PlayersContext>
    {
        protected override void Seed(PlayersContext context)
        {
            context.Players.Add(new Player {
                Id = 1,
                Nickname = "vlad",
                Tag = "team1",
                ClientCommand = 1});
            context.Players.Add(new Player
            {
                Id = 2,
                Nickname = "kiril",
                Tag = "team1",
                ClientCommand = 1
            });
            context.Players.Add(new Player
            {
                Id = 3,
                Nickname = "john",
                Tag = "team2",
                ClientCommand = 1
            });

            base.Seed(context);
        }
    }
}