using System.Collections.Generic;

namespace THA_W4_TJOK_SAVITRI
{
    public class Team //: Player
    {
        private string _teamName, _teamCountry, _teamCity;
        public List<Player> playerList;

        
        public string teamName
        {
            get { return _teamName; }
            set { _teamName = value; }
        }

        public string teamCountry
        {
            get { return _teamCountry; }
            set { _teamCountry = value; }
        }
        public string teamCity
        {
            get { return _teamCity; }
            set { _teamCity = value; }
        }

        public Team(string _teamName, string _teamCountry, string _teamCity)
        {
            this._teamName = _teamName;
            this._teamCountry = _teamCountry;
            this._teamCity = _teamCity;
            playerList = new List<Player>();
        }
        
    }
}
