using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExmoData.Model
{
    public class Balances
    {
        public string USD { get; set; }
        public string EUR { get; set; }
        public string RUB { get; set; }
        public string PLN { get; set; }
        public string UAH { get; set; }
        public string BTC { get; set; }
        public string LTC { get; set; }
        public string DOGE { get; set; }
        public string DASH { get; set; }
        public string ETH { get; set; }
        public string WAVES { get; set; }
        public string ZEC { get; set; }
        public string USDT { get; set; }
        public string XMR { get; set; }
        public string XRP { get; set; }
        public string KICK { get; set; }
        public string ETC { get; set; }
        public string BCH { get; set; }
    }

    public class Reserved
    {
        public string USD { get; set; }
        public string EUR { get; set; }
        public string RUB { get; set; }
        public string PLN { get; set; }
        public string UAH { get; set; }
        public string BTC { get; set; }
        public string LTC { get; set; }
        public string DOGE { get; set; }
        public string DASH { get; set; }
        public string ETH { get; set; }
        public string WAVES { get; set; }
        public string ZEC { get; set; }
        public string USDT { get; set; }
        public string XMR { get; set; }
        public string XRP { get; set; }
        public string KICK { get; set; }
        public string ETC { get; set; }
        public string BCH { get; set; }
    }

    public class UserInfo: INotifyPropertyChanged
    {
        public int uid { get; set; }
        public int server_date { get; set; }
        public Balances balances { get; set; }
        public Reserved reserved { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
