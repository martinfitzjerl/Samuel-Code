using GreenTomato.Library.Models;

namespace GreenTomato.Library.Attributes
{

    public class PlayerMaker
{
        public static IPlayer Create(PlayerSelector ps)//factory design, we have to keep going into this design everytime we need a new something from enum
        {
            switch (ps)
            {
                case PlayerSelector.Movie:
                return new MoviePlayer(new MovieCA());
                case PlayerSelector.Radio:
                ret
                default;
        }

    }
}
}