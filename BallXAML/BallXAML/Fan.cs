using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BallXAML
{
    internal class Fan
    {
        public ObservableCollection<string> FanSays = new ObservableCollection<string>();
        private int pitcherNumber = 0;
        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

         void ball_BallInPlay(object sender, EventArgs e)
        {
            pitcherNumber++;
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance > 120 && ballEventArgs.Trajectory > 30)
                    FanSays.Add("Rzut nr " + pitcherNumber + ": Home run! Idę po piłkę");
                else FanSays.Add("Rzut nr " + pitcherNumber + ": Jeee! Do boju!");
            }
        }
    }
}
