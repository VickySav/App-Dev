using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_TJOK_SAVITRI
{
    public class Player
    {
        public string _playerName, _playerNum, _playerPos;
        public string playerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }

        public string playerNum
        {
            get { return _playerNum; }
            set { _playerNum = value; }
        }
        public string playerPos
        {
            get { return _playerPos; }
            set { _playerPos = value; }
        }
        public Player(string _playerName, string _playerNum, string _playerPos)
        {
            this._playerName = _playerName;
            this._playerNum = _playerNum;
            this._playerPos = _playerPos;
        }
    }
}
