using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallXAML
{
    internal class Pitcher
    {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();
        private int pitcherNumer = 0;
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        void ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 29) && (ballEventArgs.Trajectory < 600))
                    CatchBall();
                else
                    CoverFristBase();
            }
        }

        private void CoverFristBase()
        {
            PitcherSays.Add("Rzut nr " + pitcherNumer + ": Złapałem piłkę.");
        }

        private void CatchBall()
        {
            PitcherSays.Add("Rzut nr " + pitcherNumer + ": Pokryłem pierwszą bazę.");
        }
    }
}
