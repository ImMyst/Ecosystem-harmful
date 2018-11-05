using System;

namespace TP_Nuisible
{
    public class Harmful
    {   
        public enum state
        {
            Dead,
            Alive,
            Zombie
        }
        public string _name;
        public state _state;
        public uint _speed;
        public Position _position;

        public Harmful(string name, uint X, uint Y, uint speed, state state) : this(name, new Position(X, Y), speed, state) {}
        public Harmful(string name, Position position, uint speed, state state)
        {   
            _name = name;
            _position = position;
            _speed = speed;
            _state = state;
        }

        public void Movements(uint XMax, uint YMax)
        {
            Random numberDirection = new Random();

            if (_state == state.Dead)
            {
                return;
            }

            for (uint i = 0; i < _speed; i++)
            {
                var Direction = numberDirection.Next(1, 5);   // 1 = en haut, 2 = à droite, 3 = en bas, 4 = à gauche

                if (Direction == 1 && _position.Y < YMax)
                {
                    _position.Y++;
                }
                else if (Direction == 2 && _position.X < XMax)
                {
                    _position.X++;
                }
                else if (Direction == 3 && _position.Y < 0)
                {
                    _position.Y--;
                }
                else if (Direction == 4 && _position.X < 0)
                {
                    _position.X--;
                }
            }
        }
        public bool IsAlive() 
        {
            return _state == state.Alive;
        }

        public void Collision(Harmful harmful)
        {
            if (harmful._state == state.Dead || _state == state.Dead)
            {
                return;
            }

            if (_state == state.Zombie)
            {
                harmful._state = state.Zombie;
                harmful._speed = Zombie._speed;
            }
            else if (harmful._state != state.Zombie && this.GetType() != harmful.GetType())
            {
                Random Kill = new Random();
                if (Kill.Next(0,2) == 0)
                {
                    harmful._state = state.Dead;
                }
                else
                {
                    this._state = state.Dead;
                }
            }
        }

        public bool IsSameCase(Harmful harmful)
        {
            return (this._position.X == harmful._position.X && this._position.Y == harmful._position.Y);
        }

        public void showSpecs()
        {
            Console.WriteLine(_name + " at Position " + _position.X + " in X and Position " + _position.Y + " in Y;" + " His state is : " + _state.ToString());
        }
    }
}