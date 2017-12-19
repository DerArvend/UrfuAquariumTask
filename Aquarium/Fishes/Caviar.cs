using System;
using System.Drawing;
using System.Timers;

namespace Aquarium.Fishes
{
    class Caviar : IGameObject
    {
        public Size Size { get; protected set; }
        public Point Location { get; protected set; }
        public int EndY;
        private bool isBorn;

        public Caviar()
        {
            isBorn = false;
        }

        public void Update(IGame game)
        {
            if (Location.Y <= game.AquariumSize.Height - EndY)
                Location = new Point(0, game.Settings.Caviar.moveSpeed);
            else
                StartTimer(game.Settings.Caviar.spawnDelay);
            if (isBorn)
            {
                game.TryAddObject(Fish);
                return;
            }
        }

        private void StartTimer(int Delay)
        {
            Timer time = new Timer();
            time.Interval = Delay;
            time.Start();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            isBorn = true;
        }
    }
}